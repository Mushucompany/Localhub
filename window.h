// window.h - Расширенный заголовок для интеграции нативных функций
// Данный файл служит мостом между C# WinForms и низкоуровневым WinAPI.
// Используется для вызова функций, недоступных через стандартный .NET Framework.

#ifndef WINDOW_H
#define WINDOW_H

// Подключение необходимых библиотек Windows
#include <windows.h>
#include <shellapi.h>
#include <commctrl.h>

// Объявление функций для работы с реестром и системными путями
#ifdef __cplusplus
extern "C" {
#endif

// Функция для получения пути к папке "Мои документы"
// Возвращает путь в предоставленный буфер
__declspec(dllexport) HRESULT GetMyDocumentsPath(LPWSTR pszPath, DWORD cchPath);

// Функция для проверки существования файла (нативная версия)
__declspec(dllexport) BOOL FileExistsNative(LPCWSTR lpFileName);

// Функция для создания папки (нативная версия)
__declspec(dllexport) BOOL CreateDirectoryNative(LPCWSTR lpPathName, LPSECURITY_ATTRIBUTES lpSecurityAttributes);

// Функция для запуска внешнего процесса (аналог Process.Start, но через WinAPI)
__declspec(dllexport) BOOL ExecuteProcess(LPCWSTR lpApplicationName, LPWSTR lpCommandLine);

// Функция для добавления программы в автозагрузку через реестр
__declspec(dllexport) BOOL AddToStartup(LPCWSTR appName, LPCWSTR appPath);

#ifdef __cplusplus
}
#endif

#endif // WINDOW_H