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
           CleanStack();
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

        public Task NavigateToNovasVistorias()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToVistoriasFeitas()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToFaleConosco()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToFazerVistoria()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToVistoriaDetail()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToVistoriaFotoDetail()
        {
            throw new NotImplementedException();
        }
    }
}
