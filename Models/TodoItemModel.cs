namespace BlazorToDoApp.Models
{
    public class TodoItemModel
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public bool Checked { get; set; } = false;

        private static int  _idIncrementer = 0;

        public TodoItemModel() { }

        public TodoItemModel(string name)
        {
            Name = name;
            Id = _idIncrementer++;
        }
    }
}