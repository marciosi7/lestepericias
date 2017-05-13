using LestePericiasMobile.Helpers;
using LestePericiasMobile.Services;
using LestePericiasMobile.Services.Interface;
using LestePericiasMobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile
{
    public partial class App : Application
    {
       
        public static Models.UserInfoDTO UserInfo { get; set; }
        public static MainPage NavigationPage { get; private set; }

        public App()
        {
            InitializeComponent();
            RegistrarDependencias();
            NavigationPage = new Views.MainPage(new Views.LoginView());
            this.MainPage = NavigationPage;

        }

        private void RegistrarDependencias()
        {
            DependencyService.Register<INavigationService, NavigationService>();
            DependencyService.Register<IMessageService, MessageService>();
            DependencyService.Register<ILoginService, LoginService>();
            DependencyService.Register<IVistoriasService, VistoriasService>();
        }
    }
}
