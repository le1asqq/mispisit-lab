# SmartQueue

Система электронной очереди для сервисного центра «УльяновскСервис».

**Лабораторная работа №4**  
Дисциплина: методы и средства проектирования информационных систем  
Студент: Васильева А.С., гр. ИСТбд-41

## Содержание

Функции и база данных как в ЛР3. Оформление интерфейса на **Bootstrap 5** (включая ресурсы в образе). В подвале отображается версия **0.0.4**.

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
- Bootstrap 5
- Docker, Docker Compose

## Ветка и образ

- Ветка: `lab4`
- Образ в `docker-compose.yml`: `ghcr.io/le1asqq/mispisit-lab1:0.0.4` (linux/amd64, linux/arm64)

Репозиторий: https://github.com/le1asqq/mispisit-lab  
Пакеты: https://github.com/le1asqq?tab=packages  
Pull Request: https://github.com/le1asqq/mispisit-lab/pull/НОМЕР

## Запуск

```
git clone -b lab4 https://github.com/le1asqq/mispisit-lab.git
cd mispisit-lab
docker compose up -d
```

Сайт: http://localhost:8080

Проверка сохранения данных:

```
docker compose down
docker compose up -d
```
