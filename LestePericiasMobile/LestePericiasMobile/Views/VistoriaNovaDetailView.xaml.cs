using LestePericiasMobile.ViewModels;

using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    public partial class VistoriaNovaDetailView : ContentView
    {
        public VistoriaNovaDetailView(Models.VistoriaDTO vistoria)
        {
            InitializeComponent();
            BindingContext = new VistoriaNovaDetailViewModel(vistoria);
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
