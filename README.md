# SmartQueue

Система электронной очереди для сервисного центра.  
Дисциплина: методы и средства проектирования информационных систем.

Docker-образ: `ghcr.io/le1asqq/mispisit-lab1` (теги `0.0.1` … `0.0.4`, платформы linux/amd64 и linux/arm64).

---

## Версии

| Тег     | Содержание |
|---------|------------|
| 0.0.1   | Стартовая веб-страница, версия 0.0.1 |
| 0.0.2   | Талон, очередь, отказ в доступе; данные в памяти приложения |
| 0.0.3   | Те же страницы; талоны в PostgreSQL, запуск через docker compose |
| 0.0.4   | Те же функции и база; оформление интерфейса (Bootstrap), версия 0.0.4 |

Репозиторий: https://github.com/le1asqq/mispisit-lab  
Пакеты: https://github.com/le1asqq?tab=packages

---

### Запуск — 0.0.1

```text
docker pull ghcr.io/le1asqq/mispisit-lab1:0.0.1
docker run --rm -p 8080:8080 ghcr.io/le1asqq/mispisit-lab1:0.0.1
http://localhost:8080
---

### Запуск — 0.0.2

```text
docker pull ghcr.io/le1asqq/mispisit-lab1:0.0.2
docker run --rm -p 8080:8080 ghcr.io/le1asqq/mispisit-lab1:0.0.2
http://localhost:8080
Ветка: lab2

## Запуск — 0.0.3

```text
git clone -b lab3 https://github.com/le1asqq/mispisit-lab.git
cd mispisit-lab
docker compose up -d
http://localhost:8080
Образ в compose: ghcr.io/le1asqq/mispisit-lab1:0.0.3
Ветка: lab3

## Запуск — 0.0.4

```text
git clone -b lab4 https://github.com/le1asqq/mispisit-lab.git
cd mispisit-lab
docker compose up -d
http://localhost:8080

Образ в compose: ghcr.io/le1asqq/mispisit-lab1:0.0.4
Ветка: lab4
