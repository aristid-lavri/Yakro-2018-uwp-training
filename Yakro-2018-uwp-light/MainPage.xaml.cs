using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Yakro_2018_uwp_light.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Yakro_2018_uwp_light
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private LoginViewModel loginViewModel;

        public MainPage()
        {
            this.InitializeComponent();
            loginViewModel = new LoginViewModel();
            DataContext = loginViewModel;
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            var enterredUserName = userName.Text;
            var enterredPassword = userName.Text;

            var loginResult = loginViewModel.Login(enterredUserName, enterredPassword);
            if (loginResult != null)
                Frame.Navigate(typeof(View.Home),loginResult);
        }
    }
}
