namespace BlazorWasm.MyBlazor.Models
{
    public class ToDoListModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsCompleted { get; set; }
        public string TaskName { get; set; }
    }
}
