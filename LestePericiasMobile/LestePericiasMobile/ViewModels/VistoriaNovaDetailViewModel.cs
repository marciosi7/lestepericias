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
    class VistoriaNovaDetailViewModel : ViewModelBase
    {
        public VistoriaDTO Vistoria { get; set; }

        public ICommand ToVoltarCommand { get; set; }
        
        public VistoriaNovaDetailViewModel(VistoriaDTO vistoria)
        {
            Vistoria = vistoria;
            ToVoltarCommand = new Command(toVoltar);
        }

        private void toVoltar()
        {
            _navigationService.Back();
        }
    }
}
