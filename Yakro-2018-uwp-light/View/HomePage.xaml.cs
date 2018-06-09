using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Yakro_2018_uwp_light.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Yakro_2018_uwp_light.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        private HomeViewModel homeViewModel;
        public Home()
        {
            this.InitializeComponent();
            homeViewModel = new HomeViewModel();
            DataContext = homeViewModel;
            Loaded += Home_Loaded;
        }

        private void Home_Loaded(object sender, RoutedEventArgs e)
        {
            homeViewModel.Load();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog dial = new MessageDialog("hi");
            await dial.ShowAsync();
        }
    }
}
