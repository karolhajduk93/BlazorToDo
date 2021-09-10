using System;

namespace BlazorToDoApp.Models
{
    public class AppState 
    {
        //state value

        public event EventHandler StateChange = delegate {};

        public void OnStateChange()
        {
            StateChange(this, EventArgs.Empty);

        }
    }
}
