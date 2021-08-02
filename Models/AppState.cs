using System;

namespace BlazorToDoApp.Models
{
    public class AppState 
    {
        public string BackgroundColor { get; private set; }

        public event EventHandler OnBackgroundColorChange = delegate {};

        public void BackgroundColorChange(string backgroundColor)
        {
            BackgroundColor = backgroundColor;
            OnBackgroundColorChange(this , EventArgs.Empty);
   
        }

  
    }
}
