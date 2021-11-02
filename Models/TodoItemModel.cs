using System;

namespace BlazorToDoApp.Models
{
    public class TodoItemModel
    {
        public string Text { get; set; }
        public string Id { get; }
        public string Date { get; }
        public bool Checked { get; set; }

        public TodoItemModel(string text)
        {
            Text = text;
            Id = Guid.NewGuid().ToString();
            Date = DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}