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

        public Task NavigateToLogin()
        {

            throw new NotImplementedException();
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
    }
}
