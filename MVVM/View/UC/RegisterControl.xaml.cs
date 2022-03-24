using Anime_List_App.Core.ExtensionClasses;
using Anime_List_App.Core.Interfaces;
using Anime_List_App.Core.Model;
using Anime_List_App.Core.Models.RootModels;
using Anime_List_App.Core.StaticClasses;
using Anime_List_App.MVVM.View.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Anime_List_App.MVVM.View.UC
{
    /// <summary>
    /// Interaction logic for RegisterControl.xaml
    /// </summary>
    public partial class RegisterControl : UserControl, ISourceInitializer
    {
        public RegisterControl()
        {
            InitializeComponent();
            InitSource();
        }

        public void InitSource()
        {
            var images = new Dictionary<Image, string>()
            {
                { RegImage, "2"}
            };
            this.SetIconSource(images);
        }

        public void NavigateToLoginControl()
        {
            AutorizationWindow.WindowVM.ChangeScreenFrame(new LoginControl());
        }

        private async void RegisterButtonClick(object sender, RoutedEventArgs e)
        {
            await RegisterButtonClickAsync();
        }

        private async Task RegisterButtonClickAsync()
        {
            var user = new User(LoginTB.Text, PasswordTB.Text, EmailTB.Text);
            var users = new UserRoots();

            await users.UpdateItems();
            var error = users.Items.TryCheckUniqueness(user);

            if (error != null)
            {
                MessageBox.Show(error.Message);
                return;
            }

            users.Items.Add(user);
            var result = await FileConverter.TryWriteToJson(users, "Users");

            if (result.Data == true)
            {
                var res = MessageBox.Show("Успешная регистрация!", "Уря", MessageBoxButton.OK);
                if(res == MessageBoxResult.OK)
                {
                    NavigateToLoginControl();
                }
                
            }
            else if (result.Data == false)
            {
                MessageBox.Show("Неизвестная ошибка 0_0");
            }
        }
    }
}
