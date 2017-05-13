using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    public partial class LoginView : ContentView
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.LoginViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }

    }
}
