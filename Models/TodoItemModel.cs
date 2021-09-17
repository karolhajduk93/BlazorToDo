using System;

namespace BlazorToDoApp.Models
{
    public class TodoItemModel
    {
        public string Text { get; set; }
        public int Id { get; set; }
        public string Date { get; set; }
        public bool Checked { get; set; } 
        public int IdCompleted { get; set; }


        public static int  IdIncrementer = 0;
        public static int  IdCompletedIncrementer = 0;

        public TodoItemModel() { }

        public TodoItemModel(string text)
        {
            Text = text;
            Id = IdIncrementer++;
            Date = DateTime.Now.ToString("dd-MM-yyyy");
            IdCompleted = -1;
        }
    }
}