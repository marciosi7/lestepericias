using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile.Controls
{
    public partial class IconWithLabel : ContentView
    {
        public IconWithLabel()
        {
            InitializeComponent();
        }

        public ImageSource Icon
        {
            get { return TopIcon.Source; }
            set { TopIcon.Source = value; }
        }

        public string Label
        {
            get { return BottomLabel.Text; }
            set { BottomLabel.Text = value; }
        }
    }
}
