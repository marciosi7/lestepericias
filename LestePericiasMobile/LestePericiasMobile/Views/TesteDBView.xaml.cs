
using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    
    public partial class TesteDBView : ContentView
    {
        public TesteDBView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.TesteDBViewModel();
        }
    }
}