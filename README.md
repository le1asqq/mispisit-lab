# SmartQueue

Система электронной очереди для сервисного центра «УльяновскСервис».

**Лабораторная работа №2**  
Дисциплина: методы и средства проектирования информационных систем  
Студент: Васильева А.С., гр. ИСТбд-41

## Содержание

Три функции электронной очереди. Данные хранятся **в памяти** (после перезапуска контейнера сбрасываются). Версия **0.0.2**.

## Страницы

| Адрес | Назначение |
|-------|------------|
| `/` | Главная |
| `/queue` | Список очереди |
| `/tickets/new` | Создание талона |
| `/tickets/{id}` | Карточка талона |
| `/access-denied` | Отказ в доступе |

## Стек

- .NET 8 (ASP.NET Core, Razor Pages)
- Docker

## Ветка и образ

- Ветка: `lab2`
- Образ: `ghcr.io/le1asqq/mispisit-lab1:0.0.2` (linux/amd64, linux/arm64)

Репозиторий: https://github.com/le1asqq/mispisit-lab  
Пакеты: https://github.com/le1asqq?tab=packages

## Запуск

```
docker pull ghcr.io/le1asqq/mispisit-lab1:0.0.2
docker run --rm -p 8080:8080 ghcr.io/le1asqq/mispisit-lab1:0.0.2
```

Сайт: http://localhost:8080

Исходники этой работы:

```
git clone -b lab2 https://github.com/le1asqq/mispisit-lab.git
```
