using BlazorToDoApp.Models;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorToDoApp.Shared
{
    public class AppState
    {
        public static event Func<Task> OnResize;


        [JSInvokable]
        public static async void ResizedWindow()
        {
            await OnResize?.Invoke();
        }

    }
}
