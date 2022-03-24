using Anime_List_App.Core;
using Anime_List_App.Core.Interfaces;
using Anime_List_App.Core.StaticClasses;
using Anime_List_App.MVVM.View.UC;
using Anime_List_App.MVVM.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Anime_List_App.MVVM.ViewModel
{
    /// <summary>
    /// Need init in window class (VS gg wp love you)
    /// </summary>
    public class AutorizationWindowVM : ObservableObject, IFrameContains
    {
        private readonly AutorizationWindow _window;
        private Frame _frame;
       
        public AutorizationWindowVM(AutorizationWindow window)
        {
            _window = window;
            TotalScreenFrame = _window.ScreenFrame;// связываем отображаемое с свойством
        }

        public Frame TotalScreenFrame { get => _frame; set => Set(ref _frame, value); } 

        public void ChangeScreenFrame(UserControl value)            
        {
            if(TotalScreenFrame != null && value != null)
                TotalScreenFrame.Navigate(value);
            else//todo delete in release vers
                MessageBox.Show("Some error");
        }

        public void CloseBaseWindow()
        {
            if(_window != null)
                _window.Close();    
        }
    }
}
