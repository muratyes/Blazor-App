# Blazor Todo App 📝

This project is a simple "To-Do List" application built with Blazor WebAssembly. It runs in the browser and stores tasks locally using `localStorage`. The UI is styled with Bootstrap for a clean and responsive design.

## 🚀 Features

- Add and remove tasks
- Mark tasks as completed
- View statistics of completed and pending tasks
- Persistent storage using browser `localStorage` (data is not lost on refresh)
- Responsive interface using Bootstrap

## 🛠️ Technologies

- [Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- [C#](https://docs.microsoft.com/dotnet/csharp/)
- [Bootstrap 5](https://getbootstrap.com/)
- [Blazored.LocalStorage](https://github.com/Blazored/LocalStorage)

## 🔧 Setup

1. Clone this repository:
    ```bash
    git clone https://github.com/yourusername/BlazorTodoApp.git
    cd BlazorTodoApp
    ```

2. Restore the required NuGet packages:
    ```bash
    dotnet restore
    ```

3. Run the application:
    ```bash
    dotnet run --project BlazorTodoApp.Client
    ```

4. Open `https://localhost:port` in your browser.

## 📁 Project Structure

