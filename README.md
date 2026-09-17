# LocalHub — Multi-Language Hub

Локальная витрина-хаб для ИИ-программ, игр и утилит: разработчики могут просматривать и запускать чужие проекты, а также публиковать свои. Проект выпускается в нескольких редакциях под разные языки программирования.

![LocalHub](Build/editions/hub/resources/banner-*.png)

## 🚀 Возможности

- 🗂️ Каталог проектов с карточками (название, категория, описание, кнопка «Запустить/Скачать»)
- 🧭 Навигация по категориям: Все / Игры / Программы / ИИ проекты
- ➕ Форма добавления своего проекта
- ✏️ Встроенный редактор кода
- 📧 Форма связи с разработчиком (у каждого издания — свой email)
- 🔐 Вход через GitHub, VK, Microsoft, Google (демо-режим)

## 📦 Издания (Editions)

| Издание | Файл | Email поддержки | Иконка |
|---|---|---|---|
| **Hub** | `Build\exe\LocalHub.exe` | hub@localhub.dev | `Resources\icon.ico` |
| **C++ Edition** | `Build\editions\cpp\exe\LocalHubCpp.exe` | cpp-edition@localhub.dev | `Resources\icon-cpp.ico` |
| **C# Edition** | `Build\editions\cs\exe\LocalHubCs.exe` | cs-edition@localhub.dev | `Resources\icon-cs.ico` |
| **C Edition** | `Build\editions\c\exe\LocalHubC.exe` | c-edition@localhub.dev | `Resources\icon-c.ico` |
| **Java Edition** | `Build\editions\java\exe\LocalHubJava.exe` | java-edition@localhub.dev | `Resources\icon-java.ico` |

Каждое издание — **отдельное приложение**: свой исходный код, свой `.exe`, своя иконка, свой email и цветовая схема.

## 🌐 Веб-версия

Каждое издание также имеет собственную HTML-страницу с баннером, редактором и формой обратной связи:

- `index.html` — главная (Hub)
- `Build\editions\cpp\html\index.html` — C++
- `Build\editions\cs\html\index.html` — C#
- `Build\editions\c\html\index.html` — C
- `Build\editions\java\html\index.html` — Java

## 🛠️ Сборка

Требуется [.NET SDK 8.0+](https://dotnet.microsoft.com/download).

```bash
# Hub
dotnet build Build\editions-src\Hub\LocalHubHub.csproj --configuration Release

# C++ Edition
dotnet build Build\editions-src\Cpp\LocalHubCpp.csproj --configuration Release

# C# Edition
dotnet build Build\editions-src\Cs\LocalHubCs.csproj --configuration Release

# C Edition
dotnet build Build\editions-src\C\LocalHubC.csproj --configuration Release

# Java Edition
dotnet build Build\editions-src\Java\LocalHubJava.csproj --configuration Release
```

Готовые `.exe` попадают в соответствующие папки `Build\editions\*\exe\` и `Build\exe\`.

## 📁 Структура проекта

```
LocalHub/
├── Form1.cs / Form1.Designer.cs   — исходники главного (Hub) приложения
├── Program.cs                     — точка входа
├── LocalHubApp.csproj             — проект Hub
├── index.html                     — веб-версия Hub
├── Resources/                     — иконки (.ico) всех изданий
├── Build/
│   ├── exe/                       — готовый .exe Hub
│   ├── editions/
│   │   ├── cpp/ (exe, html, resources, src)
│   │   ├── cs/  (exe, html, resources, src)
│   │   ├── c/   (exe, html, resources, src)
│   │   └── java/(exe, html, resources, src)
│   └── editions-src/              — исходники отдельных изданий
└── .gitignore
```

## 📄 Лицензия

Проект публикуется в учебно-демонстрационных целях. При использовании указывайте авторство.
