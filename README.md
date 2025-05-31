# Task Manager Application

Windows Forms приложение для управления задачами с использованием SQLite и Entity Framework Core.

##  Технологии
- .NET 6
- Windows Forms
- Entity Framework Core
- SQLite

##  Функционал
- Добавление задач с указанием:
  - Названия
  - Описания
  - Исполнителя (выбор из списка)
  - Статуса выполнения
- Редактирование существующих задач
- Удаление задач
- Просмотр списка всех задач

##  Запуск проекта
1. Клонируйте репозиторий
2. Откройте решение в Visual Studio 2022
3. Нажмите `F5` для запуска

##  Конфигурация
При первом запуске автоматически создается БД SQLite в папке приложения.

##  Примеры кода
### Асинхронные методы:
```csharp
public async Task<List<TaskItem>> GetAllTasksAsync() 
{
    return await context.Tasks.ToListAsync();
}
```

### Синхронные методы:
```csharp
private void RefreshTaskList()
{
    listBoxTasks.Items.Clear();
    foreach (var task in db.Tasks.ToList())
    {
        string status = task.IsCompleted ? "[✓]" : "[ ]";
        listBoxTasks.Items.Add($"{status} {task.Title} (Исполнитель: {task.Assignee})");
    }
}
```

