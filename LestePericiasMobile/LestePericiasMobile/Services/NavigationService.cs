using LestePericiasMobile.Services.Interface;
using LestePericiasMobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LestePericiasMobile.Services
{
    class NavigationService : Interface.INavigationService
    {
        private List<ContentView> navigationStack = new List<ContentView>();
        private List<bool> footerStack = new List<bool>();
        private void ChangePage(ContentView view, bool showFooter=true)
        {
            MessagingCenter.Send<INavigationService, ContentView>(this, Helpers.MessageConstant.PageChanged, view);
            MessagingCenter.Send<INavigationService, Type>(this, Helpers.MessageConstant.PageChanged, view.GetType());
            MessagingCenter.Send<INavigationService, bool>(this, Helpers.MessageConstant.ShowFooter, showFooter);
            navigationStack.Add(view);
            footerStack.Add(showFooter);
            if (navigationStack.Count > 10)
            {
                navigationStack.RemoveAt(0);
                footerStack.RemoveAt(0);
            }
        }

        public void NavigateToDashboard()
        {
            ChangePage(new DashboardView(), false);
        }

        public void NavigateToLogin()
        {

            ChangePage(new LoginView(), false);
        }

     
        public void NavigateToVistoriasNovas()
        {
            ChangePage(new Views.VistoriasNovasView());
        }

        public void NavigateToVistoriasFeitas()
        {
            ChangePage(new Views.VistoriasFeitasView());
        }

        public void NavigateToFaleConosco()
        {
            ChangePage(new FaleConoscoView());
        }

        public void NavigateToVistoriaNovaDetail(Models.VistoriaDTO vistoria)
        {
            ChangePage(new Views.VistoriaNovaDetailView(vistoria));
        }

        public void NavigateToCriarVistoriaFotoDetail()
        {

        }

        public void NavigateToMeusDados()
        {
            ChangePage(new MeusDadosView());
        }

        public void Back()
        {
            if (navigationStack.Count == 1)
            {
                return;
            }
            navigationStack.Remove(navigationStack.Last());
            footerStack.Remove(footerStack.Last());
            ChangePage(navigationStack.Last(), footerStack.Last());
        }

        public void NavigateToTesteDB()
        {
            ChangePage(new Views.TesteDBView());
        }
    }
}
