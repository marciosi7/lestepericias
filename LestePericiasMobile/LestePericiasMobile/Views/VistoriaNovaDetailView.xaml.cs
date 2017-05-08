using LestePericiasMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    public partial class VistoriaNovaDetailView : ContentPage
    {
        public VistoriaNovaDetailView(Models.VistoriaDTO vistoria)
        {
            InitializeComponent();
            BindingContext = new VistoriaNovaDetailViewModel(vistoria);
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
