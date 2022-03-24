using Anime_List_App.Core.ExtensionClasses;
using Anime_List_App.Core.Interfaces;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Anime_List_App.MVVM.View.UC
{
    /// <summary>
    /// Interaction logic for ProfileControl.xaml
    /// </summary>
    public partial class ProfileControl : UserControl, ISourceInitializer
    {
        public ProfileControl()
        {
            InitializeComponent();
            InitSource();
        }

        public void InitSource()
        {
            var images = new Dictionary<Image, string>()
            {
                //{"ia1205", Avatar },
                //{"login", Cover },
                { listAnimeIcon, "edit-list"},
                { listMangaIcon, "edit-list"},
                { MyRecIcon, "edit-list"},
                { SettingIcon, "setting"}
            };
            this.SetIconSource(images);
        }
    }
}
