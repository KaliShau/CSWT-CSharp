 
___

1. **Users (Пользователи):** 
    
    - `ID` INT PRIMARY KEY AUTO_INCREMENT (Уникальный идентификатор )
    - `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP (Дата и время создания записи)
    - `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP (Дата и время последнего обновления записи)
    
    - `username` VARCHAR(50) NOT NULL UNIQUE (Логин пользователя)
    - `password` VARCHAR(255) NOT NULL (Хэшированный пароль пользователя)
    
    - `first_name` VARCHAR(50) (Имя пользователя)
    - `last_name` VARCHAR(50) (Фамилия пользователя)
    - `email` VARCHAR(100) UNIQUE (Электронная почта пользователя)
    - `phone_number` VARCHAR(20) (Номер телефона пользователя)
    
     - `role_id` INT NOT NULL (Внешний ключ к таблице Roles)
    
2. **Roles (Роли):**
    
    - `ID` INT PRIMARY KEY AUTO_INCREMENT (Уникальный идентификатор )
    - `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP (Дата и время создания записи)
    - `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP (Дата и время последнего обновления записи)
    
    - `role_name` VARCHAR(50) NOT NULL UNIQUE (Название роли: Admin, ASU_staff, Сlient)
    - `description` TEXT (Описание роли)
    
3. **Tickets (Заявки):**
    
    - `ID` INT PRIMARY KEY AUTO_INCREMENT (Уникальный идентификатор )
    - `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP (Дата и время создания записи)
    - `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP (Дата и время последнего обновления записи)

    - `title` TEXT NOT NULL (Назавние проблемы)
    - `description` TEXT NOT NULL (Описание проблемы)
    - `solution` TEXT (Решение проблемы, добавляется сотрудником АСУ)
    
    - `closed_at` TIMESTAMP (Дата и время закрытия заявки)
    
	- `client_id` INT NOT NULL (Внешний ключ к таблице Users, ID клиента)
	- `priority_id` INT NOT NULL (Внешний ключ к таблице Priorities)
	- `status_id` INT NOT NULL (Внешний ключ к таблице Statuses)
    - `assigned_to` INT (Внешний ключ к таблице Users, ID сотрудника АСУ, которому назначена заявка, может быть NULL)
    
4. **Statuses (Статусы заявок):**
    
    - `ID` INT PRIMARY KEY AUTO_INCREMENT (Уникальный идентификатор )
    - `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP (Дата и время создания записи)
    - `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP (Дата и время последнего обновления записи)
    
    - `status_name` VARCHAR(50) NOT NULL UNIQUE (Название статуса: открыта, в работе, закрыта и т.д.)
    - `description` TEXT (Описание статуса)

5. **Priorities (Приоритеты заявок):**
    
    - `ID` INT PRIMARY KEY AUTO_INCREMENT (Уникальный идентификатор )
    - `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP (Дата и время создания записи)
    - `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP (Дата и время последнего обновления записи)
    
    - `priority_name` VARCHAR(50) NOT NULL UNIQUE (Название приоритета: низкий, средний, высокий)
    - `description` TEXT (Описание приоритета)
    
6. **Comments (Комментарии к заявкам):**
    
    - `ID` INT PRIMARY KEY AUTO_INCREMENT (Уникальный идентификатор )
    - `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP (Дата и время создания записи)
    - `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP (Дата и время последнего обновления записи)
    
    - `comment_text` TEXT NOT NULL (Текст комментария)

    - `ticket_id` INT NOT NULL (Внешний ключ к таблице Tickets)
    - `user_id` INT NOT NULL (Внешний ключ к таблице Users, ID автора комментария)
    
7. **Departments (Отделы):**
    
    - `ID` INT PRIMARY KEY AUTO_INCREMENT (Уникальный идентификатор )
    - `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP (Дата и время создания записи)
    - `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP (Дата и время последнего обновления записи)
    
    - `department_name` VARCHAR(100) NOT NULL UNIQUE (Название отдела больницы)
    - `description` TEXT (Описание отдела)
    
8. **User_Departments (Связь пользователей с отделами):**
    
    - `ID` INT PRIMARY KEY AUTO_INCREMENT (Уникальный идентификатор )
    - `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP (Дата и время создания записи)
    - `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP (Дата и время последнего обновления записи)
    
    - `user_id` INT NOT NULL (Внешний ключ к таблице Users)
    - `department_id` INT NOT NULL (Внешний ключ к таблице Departments)
    
9. **Reports (Отчеты):**
    - `ID` INT PRIMARY KEY AUTO_INCREMENT (Уникальный идентификатор )
    - `created_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP (Дата и время создания записи)
    - `updated_at` TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP (Дата и время последнего обновления записи)
    
	- `report_name` VARCHAR(255) NOT NULL
	- `report_type` VARCHAR(50) NOT NULL (Например: “статистика заявок”, “анализ по сотрудникам”)
	- `report_data` JSON (или TEXT) - Содержит сгенерированные данные отчета в виде JSON или текста.
	
	- `user_id` INT NOT NULL (Кто сгенерировал отчет)

### 🔗 Связанные ресурсы:
- **Приложение**: [[Application - CSharp]]
- **ER диаграмма**: [[ER.svg]]