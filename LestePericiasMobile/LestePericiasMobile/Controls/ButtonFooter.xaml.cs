using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile.Controls
{
    public partial class ButtonFooter : ContentView
    {
        public ButtonFooter()
        {
            InitializeComponent();
            
            innerLabel.TextColor = TextIdleColor;
            TextColor = TextIdleColor;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            innerLabel.TextColor = TextIdleColor;
            TextColor = TextIdleColor;
        }
        public static readonly BindableProperty IsActiveProperty =
        BindableProperty.Create("IsActive", typeof(bool), typeof(ButtonFooter), false, propertyChanged: OnActiveChanged);

        private static void OnActiveChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var button = (ButtonFooter)bindable;
            if ((bool)newValue)
            {
                button.TextColor = button.TextActiveColor;
                button.BackgroundColor = Color.FromRgba(0, 0, 0, 100);
            }
            else
            {
                button.TextColor = button.TextIdleColor;
                button.BackgroundColor = Color.FromRgba(0, 0, 0, 0);
            }
        }
        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set
            {
                SetValue(IsActiveProperty, value);
            }
        }
        public Color TextActiveColor { get; set; }

       
        public Color TextColor
        {
            get
            {
                return innerLabel.TextColor;
            }
            set
            {
                innerLabel.TextColor = value;
            }
        }

        public Color TextIdleColor { get; set; }
      
        public string Text
        {
            get { return innerLabel.Text; }
            set { innerLabel.Text = value; }
        }

        
    }
}
