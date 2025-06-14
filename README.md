# Разработка ИС для учета работы отдела АСУ в ГБУЗ «Лабинская центральная районная больница» МЗ КК

## Описание проекта

Разработанная информационная система предназначена для автоматизации учета работы отдела автоматизированных систем управления (АСУ) в ГБУЗ «Лабинская центральная районная больница». Система решает следующие задачи:

- Учет и распределение заявок.
- Контроль сроков выполнения задач.
- Генерация отчетности.
- Управление пользователями и правами доступа.

## Технологии

- **Клиентская часть**: C#, Windows Forms, .NET Framework 4.7.2.
- **Серверная часть**: PostgreSQL 15.
- **Среда разработки**: Microsoft Visual Studio Community 2022.
- **Архитектура**: Трехуровневая (UI, бизнес-логика, данные).

## Функциональные модули

1. **Модуль авторизации и регистрации**:

   - Разграничение прав доступа (администратор, сотрудник АСУ, клиент).
   - Проверка уникальности данных при регистрации.

2. **Модуль управления заявками**:

   - Создание, назначение, контроль выполнения заявок.
   - Жизненный цикл заявки: от создания до закрытия.

3. **Модуль отчетности**:

   - Генерация отчетов в формате DOCX.
   - Печать отчетов.

4. **Административный модуль**:
   - Управление пользователями, ролями, настройками системы.

## Установка и настройка

1. **Требования**:

   - ОС: Windows 10 или новее.
   - PostgreSQL 15 (для серверной части).
   - .NET Framework 4.7.2.

2. **Настройка базы данных**:

   - Установите PostgreSQL и создайте базу данных.
   - Выполните SQL-скрипты из файла `SQL.md` для создания таблиц и заполнения тестовыми данными.

3. **Запуск клиентского приложения**:
   - Запустите исполняемый файл программы - exe.

## Руководство пользователя

Инструкции по работе с системой:

- **Авторизация**: Введите логин и пароль.
- **Создание заявки**: Заполните обязательные поля (название, описание, приоритет).
- **Управление заявками**: Просматривайте, редактируйте и комментируйте заявки в соответствии с вашей ролью.
- **Генерация отчетов**: Формируйте отчеты в разделе "Отчетность".

## Документация

- **Дипломная работа**: Полное описание проекта в файле `Diplom.docx`.
- **Текст для защиты**: Краткое изложение проекта в файле `ТЕКСТ ДЛЯ ЗАЩИТЫ ДИПЛОМНОГО ПРОЕКТА.docx`.
- **Рецензия и отзыв**: Оценка проекта рецензентом и руководителем в файлах `Рецензия.docx` и `Отзыв руководителя.docx`.
- **Акт внедрения**: Подтверждение успешного внедрения системы в файле `АКТ внедрения.docx`.

## Перспективы развития

- Добавление веб-интерфейса для удаленного доступа.
- Разработка мобильного приложения.
- Интеграция с другими медицинскими системами.

## Картинки

![Game Screenshot](./assets/sign-in.png)

![Game Screenshot](./assets/tickets.png)

![Game Screenshot](./assets/ticket.png)

![Game Screenshot](./assets/report.png)

## Контакты

Разработчик: Федоренко Андрей Юрьевич  
ГАПОУ КК «Лабинский аграрный техникум»  
2025 г.
