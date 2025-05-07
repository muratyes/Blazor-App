using Blazored.LocalStorage;
using BlazorTodoApp.Model;

namespace BlazorTodoApp.Client.Services
{
    public class TaskService
    {
        private readonly ILocalStorageService _localStorage;
        private const string StorageKey = "tasks";

        public List<TodoItem> Tasks { get; private set; } = new();

        public event Action? OnChange;

        public TaskService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task InitializeAsync()
        {
            Tasks = await _localStorage.GetItemAsync<List<TodoItem>>(StorageKey) ?? new();
            NotifyStateChanged();
        }

        public async Task AddTask(string title)
        {
            var task = new TodoItem { Title = title };
            Tasks.Add(task);
            await SaveChangesAsync();
        }

        public async Task RemoveTask(TodoItem task)
        {
            Tasks.Remove(task);
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _localStorage.SetItemAsync(StorageKey, Tasks);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
