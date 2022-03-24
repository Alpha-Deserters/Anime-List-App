using Anime_List_App.MVVM.View.UC;
using Anime_List_App.MVVM.ViewModel;
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

    public partial class AutorizationWindow : Window
    {
        public static AutorizationWindowVM WindowVM { get; set; }
        public AutorizationWindow()
        {
            InitializeComponent();
            WindowVM = new AutorizationWindowVM(this);
            WindowVM.ChangeScreenFrame(new LoginControl());// base control is login            
        }
    }
}
