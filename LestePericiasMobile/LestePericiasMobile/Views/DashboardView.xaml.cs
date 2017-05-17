
using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    public partial class DashboardView : ContentView
    {
        public DashboardView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.DashboardViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
