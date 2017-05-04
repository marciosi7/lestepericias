using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    public partial class DashboardView : ContentPage
    {
        public DashboardView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.DashboardViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
