using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LestePericiasMobile.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
                Notify("Login");
            }
        }

        private string senha;
        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                login = value;
                Notify("Senha");
            }
        }

        public ICommand TentaLogarCommand { get; private set; }

        public LoginViewModel()
        {
            TentaLogarCommand = new Command(tentaLogar);
        }

        private async void tentaLogar()
        {
            await _navigationService.NavigateToDashboard();
        }
    }
}
