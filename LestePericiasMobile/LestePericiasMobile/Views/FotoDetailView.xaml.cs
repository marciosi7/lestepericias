using LestePericiasMobile.Models;
using LestePericiasMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    public partial class FotoDetailView : ContentView
    {
        public FotoDetailView(FotoDTO foto)
        {
            InitializeComponent();
            BindingContext = new FotoDetailViewModel(foto);
        }
    }
}
