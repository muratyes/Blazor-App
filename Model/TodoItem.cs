namespace BlazorTodoApp.Model
{
    public class TodoItem
    {
        public string Title { get; set; } = String.Empty;
        public bool IsCompleted {  get; set; }=false;
    }
}
