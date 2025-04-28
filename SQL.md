
___
```SQL
-- Создание таблицы Roles (Роли)
CREATE TABLE Roles (
    ID SERIAL PRIMARY KEY,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    role_name VARCHAR(50) NOT NULL UNIQUE,
    description TEXT
);

-- Создание таблицы Users (Пользователи)
CREATE TABLE Users (
    ID SERIAL PRIMARY KEY,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    email VARCHAR(100) UNIQUE,
    phone_number VARCHAR(20),
    role_id INT,
    FOREIGN KEY (role_id) REFERENCES Roles(ID)
);

-- Создание таблицы Statuses (Статусы заявок)
CREATE TABLE Statuses (
    ID SERIAL PRIMARY KEY,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    status_name VARCHAR(50) NOT NULL UNIQUE,
    description TEXT
);

-- Создание таблицы Priorities (Приоритеты заявок)
CREATE TABLE Priorities (
    ID SERIAL PRIMARY KEY,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    priority_name VARCHAR(50) NOT NULL UNIQUE,
    description TEXT
);

-- Создание таблицы Departments (Отделы)
CREATE TABLE Departments (
    ID SERIAL PRIMARY KEY,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    department_name VARCHAR(100) NOT NULL UNIQUE,
    description TEXT
);

-- Создание таблицы User_Departments (Связь пользователей с отделами)
CREATE TABLE User_Departments (
    ID SERIAL PRIMARY KEY,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    user_id INT,
    department_id INT,
    FOREIGN KEY (user_id) REFERENCES Users(ID),
    FOREIGN KEY (department_id) REFERENCES Departments(ID),
    UNIQUE (user_id, department_id)
);

-- Создание таблицы Tickets (Заявки)
CREATE TABLE Tickets (
    ID SERIAL PRIMARY KEY,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    title TEXT NOT NULL,
    description TEXT NOT NULL,
    solution TEXT,
    closed_at TIMESTAMP,
    client_id INT,
    priority_id INT,
    status_id INT,
    assigned_to INT,
    FOREIGN KEY (client_id) REFERENCES Users(ID),
    FOREIGN KEY (priority_id) REFERENCES Priorities(ID),
    FOREIGN KEY (status_id) REFERENCES Statuses(ID),
    FOREIGN KEY (assigned_to) REFERENCES Users(ID)
);

-- Создание таблицы Comments (Комментарии к заявкам)
CREATE TABLE Comments (
    ID SERIAL PRIMARY KEY,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    comment_text TEXT NOT NULL,
    ticket_id INT,
    user_id INT,
    FOREIGN KEY (ticket_id) REFERENCES Tickets(ID),
    FOREIGN KEY (user_id) REFERENCES Users(ID)
);

-- Создание таблицы Reports (Отчеты)
CREATE TABLE Reports (
    ID SERIAL PRIMARY KEY,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    report_name VARCHAR(255) NOT NULL,
    report_type VARCHAR(50) NOT NULL,
    report_data JSONB,
    user_id INT,
    FOREIGN KEY (user_id) REFERENCES Users(ID)
);

-- Создание триггера для автоматического обновления updated_at
CREATE OR REPLACE FUNCTION update_updated_at()
RETURNS TRIGGER AS $$
BEGIN
    NEW.updated_at = CURRENT_TIMESTAMP;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

-- Применение триггера ко всем таблицам
DO $$
DECLARE
    t text;
BEGIN
    FOR t IN 
        SELECT table_name FROM information_schema.tables 
        WHERE table_schema = 'public' AND table_type = 'BASE TABLE'
    LOOP
        EXECUTE format('CREATE TRIGGER update_%s_updated_at
                        BEFORE UPDATE ON %I
                        FOR EACH ROW EXECUTE FUNCTION update_updated_at()', 
                        t, t);
    END LOOP;
END;
$$ LANGUAGE plpgsql;
```
### Базовые данные:
```SQL
INSERT INTO Roles (role_name, description) VALUES 
('Admin', 'Полный доступ ко всем функциям системы'),
('ASU_staff', 'Доступ к заявкам и отчетам'),
('Client', 'Может создавать заявки и просматривать свои заявки');

INSERT INTO Statuses (status_name, description) VALUES 
('Новая', 'Заявка только создана и ожидает назначения'),
('В работе', 'Заявка назначена техническому специалисту и выполняется'),
('Решена', 'Заявка успешно решена'),
('Отклонена', 'Заявка отклонена как дубликат или некорректная');

INSERT INTO Priorities (priority_name, description) VALUES 
('Критический', 'Требуется немедленное решение, система не работает'),
('Высокий', 'Серьезная проблема, влияющая на работу'),
('Средний', 'Проблема с ограниченным воздействием'),
('Низкий', 'Незначительная проблема или запрос на улучшение');
```
### Тестовые данные:
```SQL
INSERT INTO Departments (department_name, description) VALUES 
('АСУ', 'Отдел автоматизированных систем управления'),
('Бухгалтерия', 'Финансовый отдел'),
('Терапия', 'Терапевтическое отделение'),
('Хирургия', 'Хирургическое отделение'),
('Лаборатория', 'Клинико-диагностическая лаборатория');

INSERT INTO Users (username, password, first_name, last_name, email, phone_number, role_id) VALUES 
-- Администраторы
('admin1', 'admin1', 'Иван', 'Иванов', 'admin1@labinsk-crb.ru', '+79181234567', 1),
('admin2', 'admin2', 'Петр', 'Петров', 'admin2@labinsk-crb.ru', '+79182234567', 1),

-- Сотрудники АСУ
('asu1', 'asu1', 'Алексей', 'Сидоров', 'asu1@labinsk-crb.ru', '+79183234567', 2),
('asu2', 'asu2', 'Сергей', 'Кузнецов', 'asu2@labinsk-crb.ru', '+79184234567', 2),
('asu3', 'asu3', 'Ольга', 'Смирнова', 'asu3@labinsk-crb.ru', '+79185234567', 2),
('asu4', 'asu4', 'Елена', 'Попова', 'asu4@labinsk-crb.ru', '+79186234567', 2),

-- Врачи и сотрудники
('doctor1', 'doctor1', 'Анна', 'Иванова', 'doctor1@labinsk-crb.ru', '+79187234567', 3),
('doctor2', 'doctor2', 'Михаил', 'Соколов', 'doctor2@labinsk-crb.ru', '+79188234567', 3),
('doctor3', 'doctor3', 'Татьяна', 'Лебедева', 'doctor3@labinsk-crb.ru', '+79189234567', 3),
('account1', 'doctor4', 'Наталья', 'Козлова', 'account1@labinsk-crb.ru', '+79180234567', 3),
('lab1', 'lab1', 'Виктор', 'Новиков', 'lab1@labinsk-crb.ru', '+79181234568', 3),
('lab2', 'lab2', 'Мария', 'Морозова', 'lab2@labinsk-crb.ru', '+79182234568', 3),
('nurse1', 'nurse1', 'Екатерина', 'Волкова', 'nurse1@labinsk-crb.ru', '+79183234568', 3),
('nurse2', 'nurse2', 'Дмитрий', 'Соловьев', 'nurse2@labinsk-crb.ru', '+79184234568', 3);

INSERT INTO User_Departments (user_id, department_id) VALUES 
-- АСУ
(3, 1), (4, 1), (5, 1), (6, 1),
-- Бухгалтерия
(10, 2),
-- Терапия
(7, 3), (13, 3),
-- Хирургия
(8, 4), (14, 4),
-- Лаборатория
(9, 5), (11, 5), (12, 5);

INSERT INTO Tickets (title, description, solution, closed_at, client_id, priority_id, status_id, assigned_to) VALUES 
-- Критические заявки
('Не работает сервер 1С', 'Сервер 1С не отвечает, бухгалтерия не может работать', 'Перезагружен сервер, восстановлена работа', '2023-05-15 14:30:00', 10, 1, 3, 3),
('Отключение интернета в хирургии', 'Полностью отсутствует интернет в хирургическом отделении', 'Обрыв кабеля, восстановлено подключение', '2023-05-16 11:15:00', 8, 1, 3, 4),

-- Высокий приоритет
('Не печатает принтер в регистратуре', 'Принтер HP LaserJet 400 выдает ошибку', 'Замена картриджа, проблема решена', '2023-05-10 16:45:00', 7, 2, 3, 5),
('Не открывается медицинская система', 'При входе в МИС "Аист" выдает ошибку авторизации', 'Сброшен пароль, восстановлен доступ', '2023-05-12 10:20:00', 9, 2, 3, 6),

-- Средний приоритет
('Требуется установка ПО на новый компьютер', 'В лабораторию поставлен новый компьютер, требуется установка ПО', 'Установлено необходимое ПО', '2023-05-18 13:10:00', 11, 3, 3, 3),
('Медленная работа компьютера', 'Компьютер в кабинете 205 работает очень медленно', 'Проведена очистка от временных файлов, дефрагментация', '2023-05-20 09:30:00', 12, 3, 3, 4),

-- Низкий приоритет
('Замена мыши', 'Сломалась компьютерная мышь в кабинете 301', 'Заменена на новую', '2023-05-22 15:00:00', 13, 4, 3, 5),
('Настройка почты на телефоне', 'Не получается настроить корпоративную почту на смартфоне', 'Помощь в настройке почтового клиента', '2023-05-25 11:45:00', 14, 4, 3, 6),

-- Заявки в работе
('Обновление ПО в терапевтическом отделении', 'Требуется обновить медицинское ПО на 5 компьютерах', NULL, NULL, 7, 3, 2, 3),
('Не работает сканер в бухгалтерии', 'Сканер Epson не определяется компьютером', NULL, NULL, 10, 2, 2, 4),

-- Новые заявки
('Установка антивируса', 'Требуется установить антивирус на новый компьютер', NULL, NULL, 8, 3, 1, NULL),
('Проблема с доступом к сетевой папке', 'Не могу получить доступ к общей папке с документами', NULL, NULL, 9, 2, 1, NULL),
('Не работает клавиатура', 'Клавиатура не реагирует на нажатия в кабинете 412', NULL, NULL, 11, 4, 1, NULL),
('Требуется дополнительный монитор', 'Для работы необходимо подключить второй монитор', NULL, NULL, 12, 4, 1, NULL);

INSERT INTO Comments (comment_text, ticket_id, user_id) VALUES 
-- Комментарии к заявке 1 (Не работает сервер 1С)
('Проблема зафиксирована, начинаю диагностику', 1, 3),
('Обнаружена проблема с сетевым подключением сервера', 1, 3),
('Перезагружаю сервер для восстановления работы', 1, 3),

-- Комментарии к заявке 2 (Отключение интернета в хирургии)
('Проверяю соединение на коммутаторе', 2, 4),
('Обнаружен физический обрыв кабеля в коридоре 2 этажа', 2, 4),
('Заменяю поврежденный участок кабеля', 2, 4),

-- Комментарии к заявке 3 (Не печатает принтер в регистратуре)
('Проверил подключение принтера - в порядке', 3, 5),
('Заменил картридж, проблема решена', 3, 5),

-- Комментарии к заявке 4 (Не открывается медицинская система)
('Пользователь заблокирован в системе из-за неправильного пароля', 4, 6),
('Сбросил пароль, провел инструктаж по безопасности', 4, 6),

-- Комментарии к заявке 11 (Обновление ПО в терапевтическом отделении)
('Начал обновление на первом компьютере', 11, 3),
('Обновил 3 из 5 компьютеров, продолжаю работу', 11, 3),

-- Комментарии к заявке 12 (Не работает сканер в бухгалтерии)
('Проверил драйверы - проблема не в них', 12, 4),
('Пробую подключить сканер к другому компьютеру', 12, 4),

-- Комментарии к заявке 13 (Установка антивируса)
('Новый компьютер добавлен в домен', 13, NULL),
('Готов приступить к установке антивируса', 13, NULL),

-- Комментарии к заявке 14 (Проблема с доступом к сетевой папке)
('Проверил права доступа - все в порядке', 14, NULL),
('Проблема может быть на стороне клиента', 14, NULL);

-- Заявки за март 2025 (критические и высокий приоритет)
INSERT INTO Tickets (title, description, solution, closed_at, client_id, priority_id, status_id, assigned_to, created_at, updated_at) VALUES 
('Аварийное отключение сервера 1С', 'Сервер 1С отключился в рабочее время, все отделы не могут работать', 'Перезапущены службы 1С, восстановлена работа', '2025-03-05 15:45:00', 10, 1, 3, 3, '2025-03-05 14:20:00', '2025-03-05 15:45:00'),
('Отказ системы видеонаблюдения', 'Не работает вся система видеонаблюдения по корпусу', 'Обнаружен сбой в коммутаторе, заменено оборудование', '2025-03-12 18:30:00', 8, 1, 3, 4, '2025-03-12 16:00:00', '2025-03-12 18:30:00'),
('Не работает электронная регистратура', 'Пациенты не могут записаться на прием через терминалы', 'Восстановлено подключение к основной БД', '2025-03-18 13:15:00', 7, 2, 3, 5, '2025-03-18 09:00:00', '2025-03-18 13:15:00');

-- Заявки за март 2025 (средний и низкий приоритет)
INSERT INTO Tickets (title, description, solution, closed_at, client_id, priority_id, status_id, assigned_to, created_at, updated_at) VALUES 
('Не печатает сетевой принтер в лаборатории', 'Принтер HP LaserJet 500 подключен, но не печатает', 'Обновлены драйверы, проблема решена', '2025-03-07 11:20:00', 11, 3, 3, 6, '2025-03-07 10:00:00', '2025-03-07 11:20:00'),
('Требуется установка специализированного ПО', 'Для нового анализатора нужна установка LabControl 3.0', 'Установлено и настроено ПО, проведено обучение', '2025-03-14 16:40:00', 9, 3, 3, 3, '2025-03-14 14:00:00', '2025-03-14 16:40:00'),
('Зависает компьютер в кабинете главврача', 'Компьютер периодически зависает при работе с документами', 'Проведена чистка системы, добавлена оперативная память', '2025-03-21 12:30:00', 1, 3, 3, 4, '2025-03-21 10:15:00', '2025-03-21 12:30:00'),
('Не работает мышь в регистратуре', 'Оптическая мышь не реагирует на движения', 'Заменена на новую', '2025-03-25 09:45:00', 7, 4, 3, 5, '2025-03-25 09:00:00', '2025-03-25 09:45:00'),
('Настройка почты на новом телефоне', 'Требуется помощь в настройке корпоративной почты на смартфоне', 'Настроен почтовый клиент Outlook для Android', '2025-03-28 14:15:00', 13, 4, 3, 6, '2025-03-28 13:30:00', '2025-03-28 14:15:00');

-- Незакрытая заявка за март 2025
INSERT INTO Tickets (title, description, solution, closed_at, client_id, priority_id, status_id, assigned_to, created_at, updated_at) VALUES 
('Обновление ОС на рабочих станциях', 'Требуется обновить Windows 10 до актуальной версии на 15 ПК', NULL, NULL, 2, 3, 2, 3, '2025-03-30 10:00:00', '2025-03-30 10:00:00');

-- Комментарии к заявкам за март 2025
INSERT INTO Comments (comment_text, ticket_id, user_id, created_at, updated_at) VALUES 
('Начал диагностику сервера 1С, проверяю логи', 15, 3, '2025-03-05 14:30:00', '2025-03-05 14:30:00'),
('Обнаружена проблема с лицензионным сервером', 15, 3, '2025-03-05 15:00:00', '2025-03-05 15:00:00'),
('Проблема с видеонаблюдением - нет питания на коммутаторе', 16, 4, '2025-03-12 16:30:00', '2025-03-12 16:30:00'),
('Принтер в лаборатории виден в сети, но не принимает задания', 18, 6, '2025-03-07 10:20:00', '2025-03-07 10:20:00'),
('Установил LabControl на 3 из 5 рабочих мест', 19, 3, '2025-03-14 15:00:00', '2025-03-14 15:00:00'),
('Компьютер главврача требует апгрейда памяти', 20, 4, '2025-03-21 11:00:00', '2025-03-21 11:00:00');
```