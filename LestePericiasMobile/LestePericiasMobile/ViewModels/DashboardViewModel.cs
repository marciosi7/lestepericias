using LestePericiasMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LestePericiasMobile.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        public UserInfoDTO UserInfo { get; set; }
        public ICommand ToVistoriasCommand { get; private set; }
        public ICommand ToVistoriasFeitasCommand { get; private set; }
        public ICommand ToFaleConoscoCommand { get; private set; }
        public ICommand ToMeusDadosCommand { get; private set; }
        public DashboardViewModel()
        {
            UserInfo = App.UserInfo;
        }


        private void toVistorias()
        {
            // TODO
        }

        private void toVistoriasFeitas()
        {
            // TODO

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
