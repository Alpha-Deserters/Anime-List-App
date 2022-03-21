using Anime_List_App.Core.Interfaces;
using Anime_List_App.MVVM.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_List_App.Core.ExtensionClasses
{
    public static class FrameNavigator
    {
        private static AutorizationWindow? _window;

        public static void SetWidnow(AutorizationWindow window)
        {
            _window = window;
        }

        public static void NavigateTo(this IFrameNavigator _, IFrameNavigator newFrame)
        {
            if (_window == null) 
                return;

             _window.ScreenFrame.Navigate(newFrame);
        }

        public static void Close()
        {
            if (_window != null)
                _window.Close();
        }
    }
}
