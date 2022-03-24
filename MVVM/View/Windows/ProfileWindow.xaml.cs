using Anime_List_App.Core.Interfaces;
using Anime_List_App.Core.Model;
using Anime_List_App.Core.StaticClasses;
using Anime_List_App.MVVM.View.UC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Anime_List_App.MVVM.View.Windows
{
    /// <summary>
    /// Interaction logic for ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        private User? _user;   

        public ProfileWindow(User user)
        {
            InitializeComponent();           
            _user = user;
            //_frameControl = new FrameControl();
           // _frameControl.SetWidnow(this);
            ScreenFrame.Navigate(new ProfileControl());// init base frame
        }
    }
}
