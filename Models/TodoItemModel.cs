namespace BlazorToDoApp.Models
{
    public class TodoItemModel
    {
        public string Text { get; set; }
        public int Id { get; set; }

        public bool Checked { get; set; } 

        private static int  _idIncrementer = 0;

        public TodoItemModel() { }

        public TodoItemModel(string text)
        {
            Text = text;
            Id = _idIncrementer++;
        }
    }
}