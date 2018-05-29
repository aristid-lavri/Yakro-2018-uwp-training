using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakro_uwp.ViewModel
{

    public class ViewModelLocator
    {
        #region ViewKeys
        public const string MainViewKey = "MainView";
        public const string SettingViewKey = "SettingViewKey";
        public const string LoginViewKey = "LoginView";
        #endregion

        #region ViewModelProperty
        public LoginViewModel LoginVM => SimpleIoc.Default.GetInstance<LoginViewModel>();
        public SettingViewModel SettingVM => SimpleIoc.Default.GetInstance<SettingViewModel>();
        public MainViewModel MainVM => SimpleIoc.Default.GetInstance<MainViewModel>();
        #endregion

        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<IMessenger, Messenger>();

            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<SettingViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
        }
    }
}
