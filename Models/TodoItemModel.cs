using System;

namespace BlazorToDoApp.Models
{
    public class TodoItemModel
    {
        public string Text { get; set; }
        public string Id { get; set; }
        public string Date { get; set; }
        public bool Checked { get; set; }

        public TodoItemModel(string text)
        {
            Text = text;
            Id = Guid.NewGuid().ToString();
            Date = DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}