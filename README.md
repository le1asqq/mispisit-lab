# SmartQueue

Система электронной очереди для сервисного центра «УльяновскСервис».

**Лабораторная работа №5**  
Дисциплина: методы и средства проектирования информационных систем  
Студент: Васильева А.С., гр. ИСТбд-41

## Содержание

Те же три функции и PostgreSQL, что в ЛР3–4. После создания талона в базе появляется запись в таблице **SystemEvents** и она видна на странице **События** (`/events`). Версия **0.0.5**.

## Событие

| Поле | Значение |
|------|----------|
| Действие | Создание талона (`/tickets/new`) |
| Вариант | Уведомление на странице приложения |
| Экран | Меню «События», таблица: тип события, номер талона, время, статус |

До первого талона список событий пуст. После создания талона появляется строка «Создан талон» с номером (например A-103).

## Стек

- .NET 8, Razor Pages, Entity Framework Core 8.0.11
- PostgreSQL 16
- Bootstrap 5.3.3
- Docker, Docker Compose

## Ветка и образ

- Ветка: `lab5`
- Имя проекта Compose: `mispisit-vasileva`
- Образ: `ghcr.io/le1asqq/mispisit-lab1:0.0.5` (linux/amd64)

Репозиторий: https://github.com/le1asqq/mispisit-lab  
Пакеты: https://github.com/le1asqq?tab=packages  
Pull Request: https://github.com/le1asqq/mispisit-lab/pull/5

## Запуск

```
git clone -b lab5 https://github.com/le1asqq/mispisit-lab.git
cd mispisit-lab
docker compose pull
docker compose up -d
```

Сайт: http://localhost:8080

Проверка события: откройте `/events`, создайте талон, снова откройте `/events`.

Проверка сохранения данных:

```
docker compose down
docker compose up -d
```
![Uploading image.png…]()
