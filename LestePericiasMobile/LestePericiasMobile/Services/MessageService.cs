using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Services
{
    class MessageService : Interface.IMessageService
    {

        public async Task ShowCustomMessage(string message)
        {
            await App.Current.MainPage.DisplayAlert("Alerta", message, "Ok");
        }

        public async Task ShowCustomMessageTitle(string title, string message)
        {
            await App.Current.MainPage.DisplayAlert(title, message, "Ok");
        }

        public async Task ShowNetworkProblemError()
        {
            await App.Current.MainPage.DisplayAlert("Erro", "Houve um erro na conexão. Cheque sua internet e tente novamente.", "Ok");
        }

        public async Task<bool> ShowCustomDialog(string title, string desc, string affirmative, string negative)
        {
            return await App.Current.MainPage.DisplayAlert(title, desc, affirmative, negative);
        }

        public async Task<string> ShowCustomActionSheet(string title, params string[] buttons)
        {
            return await App.Current.MainPage.DisplayActionSheet(title, "Cancelar", null, buttons);
        }

    }
}
