namespace BlazorToDoApp.Models
{
    public class TodoItemModel
    {
        public string Name { get; set; }

        public TodoItemModel() { }

        public TodoItemModel(string name)
        {
            Name = name;
        }
    }
}