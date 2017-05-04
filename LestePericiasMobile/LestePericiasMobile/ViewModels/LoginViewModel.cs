using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LestePericiasMobile.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        private string login;
        private readonly Services.ILoginService _loginService;
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
            _loginService = DependencyService.Get<Services.ILoginService>();
        }

        private async void tentaLogar()
        {
            Models.UserInfoDTO userInfo = null;
            try
            {
                userInfo = await _loginService.LoginServidor(Login, Senha);

            }catch(HttpRequestException e)
            {
                System.Diagnostics.Debug.WriteLine(e);
                await _messageService.ShowNetworkProblemError();
            }
            if (userInfo != null)
            {
                App.UserInfo = userInfo;
                await _navigationService.NavigateToDashboard();
            }
            else
            {
                await _messageService.ShowCustomMessageTitle("Erro", "Usuário e/ou senha incorretos");
            }
        }
    }
}
