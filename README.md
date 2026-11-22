# SmartQueue

Система электронной очереди для сервисного центра «УльяновскСервис».

**Лабораторная работа №3**  
Дисциплина: методы и средства проектирования информационных систем  
Студент: Васильева А.С., гр. ИСТбд-41

## Содержание

Те же страницы и функции, что в ЛР2. Данные сохраняются в **PostgreSQL**; запуск через **Docker Compose**. Версия **0.0.3**.

## Страницы

| Адрес | Назначение |
|-------|------------|
| `/` | Главная |
| `/queue` | Список очереди |
| `/tickets/new` | Создание талона |
| `/tickets/{id}` | Карточка талона |
| `/access-denied` | Отказ в доступе |

## Стек

- .NET 8, Razor Pages, Entity Framework Core
- PostgreSQL 16
- Docker, Docker Compose

## Ветка и образ

- Ветка: `lab3`
- Образ в `docker-compose.yml`: `ghcr.io/le1asqq/mispisit-lab1:0.0.3` (linux/amd64, linux/arm64)

Репозиторий: https://github.com/le1asqq/mispisit-lab  
Пакеты: https://github.com/le1asqq?tab=packages

## Запуск

```
git clone -b lab3 https://github.com/le1asqq/mispisit-lab.git
cd mispisit-lab
docker compose up -d
```

Сайт: http://localhost:8080

Проверка сохранения данных (том `dbdata` не удалять):

```
docker compose down
docker compose up -d
```

Полный сброс базы (пустая очередь):

```
docker compose down -v
docker compose up -d
```
