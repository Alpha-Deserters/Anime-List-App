using Anime_List_App.Core.ExtensionClasses;
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
    /// Interaction logic for AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
            FrameNavigator.SetWidnow(this);
            ScreenFrame.Navigate(new LoginControl());// init base frame
        }
    }
}
