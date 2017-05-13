using LestePericiasMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LestePericiasMobile.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        public UserInfoDTO UserInfo { get; set; }
        public ICommand ToVistoriasNovasCommand { get; private set; }
        public ICommand ToVistoriasFeitasCommand { get; private set; }
        public ICommand ToFaleConoscoCommand { get; private set; }
        public ICommand ToMeusDadosCommand { get; private set; }
        public DashboardViewModel()
        {
            UserInfo = App.UserInfo;

            ToVistoriasNovasCommand = new Command(toVistoriasNovas);
            ToVistoriasFeitasCommand = new Command(toVistoriasFeitas);
        }


        private void toVistoriasNovas()
        {
             _navigationService.NavigateToVistoriasNovas();
        }

        private void toVistoriasFeitas()
        {
             _navigationService.NavigateToVistoriasFeitas();
        }

        private void toFaleConosco()
        {
            // TODO

        }

        private void toMeusDados()
        {
            // TODO

        }

    }
}
