using Anime_List_App.Core.ExtensionClasses;
using Anime_List_App.Core.Interfaces;
using Anime_List_App.Core.Models.RootModels;
using Anime_List_App.MVVM.View.Windows;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Anime_List_App.MVVM.View.UC
{
    /// <summary>
    /// Interaction logic for LoginControl.xaml
    /// </summary>
    public partial class LoginControl : UserControl, IFrameNavigator, ISourceInitializer
    {
        public LoginControl()
        {
            InitializeComponent();
            InitSource();
        }

        public void InitSource()
        {
            var images = new Dictionary<string, Image>()
            {
                {"ia1205", AutorizationImage },
                {"login", UserImage },
                {"lock", LockImage }
            };
            this.SetImageSource(images);
        }

        public void NavigateToRegisterControl()
        {
            this.NavigateTo(new RegisterControl());
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
                    FrameNavigator.Close();
                }
            }
        }
    }
}
