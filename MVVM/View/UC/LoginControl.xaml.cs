using Anime_List_App.Core.ExtensionClasses;
using Anime_List_App.Core.Interfaces;
using Anime_List_App.Core.Models.RootModels;
using Anime_List_App.Core.StaticClasses;
using Anime_List_App.MVVM.View.Windows;
using Anime_List_App.MVVM.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Anime_List_App.MVVM.View.UC
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl, ISourceInitializer
    {
        public LoginControl()
        {
            InitializeComponent();
            InitSource();
        }

        public void InitSource()
        {
            var images = new Dictionary<Image, string>()
            {
                {AutorizationImage, "ia1205"},
                {UserImage, "login"},
                {LockImage, "lock"}
            };
            this.SetIconSource(images);
        }

        public void NavigateToRegisterControl()
        {
            AutorizationWindow.WindowVM.ChangeScreenFrame(new RegisterControl());
        }

        private void RegisterButttonClick(object sender, RoutedEventArgs e)
        {
            NavigateToRegisterControl();
        }

        private async void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            await LoginButtonClickAsync();
        }

        private async Task LoginButtonClickAsync()
        {
            var users = new UserRoots();
            await users.UpdateItems();

            foreach (var user in users.Items)
            {
                if (LoginTB.Text == user.Login &&
                   PasswordTB.Text == user.Password)
                {
                    new ProfileWindow(user).Show();
                    AutorizationWindow.WindowVM.CloseBaseWindow();
                }
            }
        }
    }
}
