using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Services
{
    class NavigationService : Interface.INavigationService
    {
        public Xamarin.Forms.Page MainPage => App.Current.MainPage;

        public async Task NavigateToDashboard()
        {
           await MainPage.Navigation.PushAsync(new Views.DashboardView());
        }

        public void NavigateToLogin()
        {

            App.Current.MainPage = new Views.LoginView();
        }

        public void CleanStack()
        {
            int maxStackSize = 8;
            if(MainPage.Navigation.NavigationStack.Count > maxStackSize)
            {
                var existingPages = MainPage.Navigation.NavigationStack.ToList();
                foreach (var page in existingPages)
                {
                    MainPage.Navigation.RemovePage(page);
                }
            }
        }

        public async Task NavigateToVistoriasMain()
        {
            await MainPage.Navigation.PushAsync(new Views.VistoriasTabbedView());
        }

        public Task NavigateToFaleConosco()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToCriarVistoriaDetail()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToCriarVistoriaFotoDetail()
        {
            throw new NotImplementedException();
        }
    }
}
