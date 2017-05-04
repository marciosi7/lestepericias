﻿using LestePericiasMobile.Services;
using LestePericiasMobile.Services.Interface;
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
        public App()
        {
            InitializeComponent();
            UserInfo = new Models.UserInfoDTO()
            {
                IdUsuario = 1,
                Nome = "Edson Arantes do Nascimento",
                Username = "pelé"
            };
            RegistrarDependencias();
            this.MainPage = new NavigationPage(new Views.LoginView());
        }

        private void RegistrarDependencias()
        {
            DependencyService.Register<INavigationService, NavigationService>();
            DependencyService.Register<IMessageService, MessageService>();
        }
    }
}
