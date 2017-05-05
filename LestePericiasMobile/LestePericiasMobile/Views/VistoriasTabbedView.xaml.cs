using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    public partial class VistoriasTabbedView : TabbedPage
    {
        public VistoriasTabbedView(int index)
        {
            InitializeComponent();
            if(Device.OS == TargetPlatform.Android)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }
            
            CurrentPage = Children[index % 2];
        }
    }
}
