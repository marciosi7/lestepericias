using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    public partial class CategoriaFotosView : ContentPage
    {
        public CategoriaFotosView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.CategoriaFotosViewModel();
        }
    }
}
