# SmartQueue

Система электронной очереди для сервисного центра «УльяновскСервис».

**Лабораторная работа №1**  
Дисциплина: методы и средства проектирования информационных систем  
Студент: Васильева А.С., гр. ИСТбд-41

## Содержание

Стартовая веб-страница: название системы, краткое описание, отображение версии **0.0.1**.

## Стек

- .NET 8 (ASP.NET Core)
- Docker

## Ветка и образ

- Ветка: `lab1`
- Образ: `ghcr.io/le1asqq/mispisit-lab1:0.0.1` (linux/amd64, linux/arm64)

Репозиторий: https://github.com/le1asqq/mispisit-lab  
Пакеты: https://github.com/le1asqq?tab=packages

## Запуск

```
docker pull ghcr.io/le1asqq/mispisit-lab1:0.0.1
docker run --rm -p 8080:8080 ghcr.io/le1asqq/mispisit-lab1:0.0.1
```

Сайт: http://localhost:8080

Исходники этой работы:

```
git clone -b lab1 https://github.com/le1asqq/mispisit-lab.git
```
