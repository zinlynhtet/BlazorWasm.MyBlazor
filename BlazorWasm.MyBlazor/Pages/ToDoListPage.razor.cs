using BlazorWasm.MyBlazor.Models;

namespace BlazorWasm.MyBlazor.Pages
{
    public partial class ToDoListPage
    {
        private static List<ToDoListModel> data = new List<ToDoListModel>();
        private ToDoListModel reqModel { get; set; } = new ToDoListModel();
        public void Add()
        {
            data.Add(reqModel);
            reqModel = new ToDoListModel();
        }
        public void Cancel()
        {
            reqModel = new ToDoListModel();
        }
        private void ToggleTask(ToDoListModel item)
        {
            int index = data.FindIndex(x => x.Id == item.Id);
            data[index].IsCompleted = !data[index].IsCompleted;
            Console.WriteLine(data[index].IsCompleted);
        }
        public void Remove(string id)
        {
            data = data.Where(x => x.Id != id).ToList();
        }
    }
}
