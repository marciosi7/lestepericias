using LestePericiasMobile.Services.Interface;
using LestePericiasMobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LestePericiasMobile.ViewModels
{
    class MainPageViewModel : ViewModelBase
    {
        public ICommand ToVistoriasNovasCommand { get; private set; }
        public ICommand ToVistoriasFeitasCommand { get; private set; }
        public ICommand ToFaleConoscoCommand { get; private set; }
        public ICommand ToMeusDadosCommand { get; private set; }

        public bool IsVistoriasFeitasActive { get; set; }
        public bool IsVistoriasNovasActive { get; set; }
        public bool IsFaleConoscoActive { get; set; }
        public bool IsMeusDadosActive { get; set; }
        public bool IsFooterVisible { get; set; }
        public MainPageViewModel()
        {
           
            ToVistoriasNovasCommand = new Command(toVistoriasNovas);
            ToVistoriasFeitasCommand = new Command(toVistoriasFeitas);
            ToFaleConoscoCommand = new Command(toFaleConosco);
            ToMeusDadosCommand = new Command(toMeusDados);
            IsFooterVisible = false;

            MessagingCenter.Subscribe<INavigationService, Type>(this, Helpers.MessageConstant.PageChanged, (v, m) =>
            {
                changeFooterIcon(m);
            });

            MessagingCenter.Subscribe<INavigationService, bool>(this, Helpers.MessageConstant.ShowFooter, (v, m) =>
            {
                IsFooterVisible = m;
                Notify("IsFooterVisible");
            });
        }
       

        private void changeFooterIcon(Type viewType)
        {
            IsVistoriasFeitasActive = false;
            IsVistoriasNovasActive = false;
            IsFaleConoscoActive = false;
            IsMeusDadosActive = false;
            if(viewType == typeof(VistoriasFeitasView))
            {
                IsVistoriasFeitasActive = true;
            }
            else if(viewType == typeof(VistoriasNovasView))
            {
                IsVistoriasNovasActive = true;
            }
            else if(viewType == typeof(FaleConoscoView))
            {
                IsFaleConoscoActive = true;
            }
            else if(viewType == typeof(MeusDadosView))
            {
                IsMeusDadosActive = true;
            }
            Notify("IsVistoriasFeitasActive");
            Notify("IsVistoriasNovasActive");
            Notify("IsFaleConoscoActive");
            Notify("IsMeusDadosActive");
        }

        private void toVistoriasNovas()
        {
            if(!IsVistoriasNovasActive)
            {
                _navigationService.NavigateToVistoriasNovas();
            }
        }
        private void toVistoriasFeitas()
        {
            if(!IsVistoriasFeitasActive)
            {
                _navigationService.NavigateToVistoriasFeitas();
            }
        }
        private void toFaleConosco()
        {
            if (!IsFaleConoscoActive)
            {
                _navigationService.NavigateToFaleConosco();
            }
        }
        private void toMeusDados()
        {
            if(!IsMeusDadosActive)
            {
                _navigationService.NavigateToMeusDados();
            }
        }

        public void toBack()
        {
            _navigationService.Back();
        }


    }
}
