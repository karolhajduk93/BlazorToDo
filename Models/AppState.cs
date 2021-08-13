using System;

namespace BlazorToDoApp.Models
{
    public class AppState 
    {
        //state value

        public event EventHandler<TodoItemModel> StateChange = delegate {};

        protected virtual void OnStateChange(TodoItemModel e)
        {
            StateChange(this, e);
        }
    }
}
