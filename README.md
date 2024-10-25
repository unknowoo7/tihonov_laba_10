# Лабораторная работа №10 по дисциплине "Проектирование и программная реализация Web-приложений"
## Вариант №7

**Задание:**
В базе данных хранятся сведения со списком новых проектов it-компании, включая стоимость оплаты за руководство проектом, 
также в БД хранится список руководителей проектов, которые есть у компании (руководители еще не привязаны к проектам). 
Вывести сведения о проектах  и напротив каждого проекта разместите текстовое поле, куда будет вписываться 
id руководителя и текстовое поле с назначаемым размером оплаты за проект. Пользователь должен иметь возможность удалять проект из списка. 
Ниже списка проектов выводится список руководителей с их ID. После назначения руководителя на проект рядом с ним отображается название проекта, 
один руководитель может заниматься несколькими проектами. В самом низу страницы разместите сведения об общей сумме, за все проекты.

**Задача разбитая на подзадача**
Задания
1. Создать модели Project (включая стоимость), Manager (без привязки к проектам / пока ещё)

2. Вывести сведения о проектах 
3. Напротив каждого проекта разместите текстовое поле, куда будет вписываться id руководителя и текстовое поле с назначаемым размером оплаты за проект
4. Пользователь должен иметь возможность удалять проект из списка

5. Ниже списка проектов выводится список руководителей с их ID.
6. После назначения руководителя на проект рядом с ним отображается название проекта (один руководитель может заниматься несколькими проектами)

7. В самом низу страницы разместите сведения об общей сумме, за все проекты.



### SQL для вставки тестовых данных
-- Вставка данных в таблицу Manager
INSERT INTO "Managers" ("Name") VALUES
('John Doe'),
('Jane Smith'),
('Alice Johnson');

-- Вставка данных в таблицу Project
INSERT INTO "Projects" ("Name", "Description", "Price") VALUES
('Project A', 'Description for Project A', 1000.00),
('Project B', 'Description for Project B', 2000.00),
('Project C', 'Description for Project C', 1500.00),
('Project D', 'Description for Project D', 2500.00),
('Project E', 'Description for Project E', 3000.00),
('Project F', 'Description for Project F', 3500.00),
('Project G', 'Description for Project G', 4000.00),
('Project H', 'Description for Project H', 4500.00),
('Project I', 'Description for Project I', 5000.00),
('Project J', 'Description for Project J', 5500.00);