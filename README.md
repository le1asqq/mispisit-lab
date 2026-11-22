# SmartQueue

Система электронной очереди для сервисного центра.  
Дисциплина: методы и средства проектирования информационных систем.

Docker-образ: `ghcr.io/le1asqq/mispisit-lab1` (теги 0.0.1–0.0.4, linux/amd64 и linux/arm64).

## Версии

| Тег | Содержание |
|-----|------------|
| 0.0.1 | Стартовая веб-страница, версия 0.0.1 |
| 0.0.2 | Талон, очередь, отказ; данные в памяти |
| 0.0.3 | Те же страницы; PostgreSQL; docker compose |
| 0.0.4 | Те же функции и база; интерфейс Bootstrap, версия 0.0.4 |
| 0.0.5 | ЛР4 + страница «События», уведомление о создании талона |

Репозиторий: https://github.com/le1asqq/mispisit-lab  
Пакеты: https://github.com/le1asqq?tab=packages

## Запуск 0.0.1

```
docker pull ghcr.io/le1asqq/mispisit-lab1:0.0.1
docker run --rm -p 8080:8080 ghcr.io/le1asqq/mispisit-lab1:0.0.1
```

Сайт: http://localhost:8080

## Запуск 0.0.2

```
docker pull ghcr.io/le1asqq/mispisit-lab1:0.0.2
docker run --rm -p 8080:8080 ghcr.io/le1asqq/mispisit-lab1:0.0.2
```

Сайт: http://localhost:8080  
Ветка: `lab2`

## Запуск 0.0.3

```
git clone -b lab3 https://github.com/le1asqq/mispisit-lab.git
cd mispisit-lab
docker compose up -d
```

Сайт: http://localhost:8080  
Образ в compose: `ghcr.io/le1asqq/mispisit-lab1:0.0.3`  
Ветка: `lab3`

## Запуск 0.0.4

```
git clone -b lab4 https://github.com/le1asqq/mispisit-lab.git
cd mispisit-lab
docker compose up -d
```

Сайт: http://localhost:8080  
Образ в compose: `ghcr.io/le1asqq/mispisit-lab1:0.0.4`  
Ветка: `lab4`  
Pull Request: https://github.com/le1asqq/mispisit-lab/pull/НОМЕР

Проверка сохранения данных:

```
docker compose down
docker compose up -d
```

### Запуск 0.0.5

```
git clone -b lab5 https://github.com/le1asqq/mispisit-lab.git
cd mispisit-lab
docker compose pull
docker compose up -d
```

Сайт: http://localhost:8080. Страница событий: http://localhost:8080/events  
Pull Request: https://github.com/le1asqq/mispisit-lab/pull/5

---
