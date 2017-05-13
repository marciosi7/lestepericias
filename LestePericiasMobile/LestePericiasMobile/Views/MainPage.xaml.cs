using LestePericiasMobile.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using System.Runtime.CompilerServices;
using LestePericiasMobile.ViewModels;
using LestePericiasMobile.Services.Interface;

namespace LestePericiasMobile.Views
{
    public partial class MainPage : ContentPage
    {
       
        public ContentView MainContent { get; set; }
        public StackLayout FooterContent { get; set; }
        private MainPageViewModel _viewmodel;
        public MainPage(ContentView view)
        {
            InitializeComponent();
            MainContent = view;
            contentView.Content = view;
            FooterContent = Footer;
            _viewmodel = new MainPageViewModel();
            BindingContext = _viewmodel;

            MessagingCenter.Subscribe<INavigationService, ContentView>(this, Helpers.MessageConstant.PageChanged, (v, m) =>
            {
                OnPageChange(m);
            });
            
        }

        protected override bool OnBackButtonPressed()
        {
            _viewmodel.toBack();
            return true;
        }

        public async void OnPageChange(ContentView view)
        {
            await contentView.FadeTo(0, 300);
           
            MainContent.Content = view;
                       
            await contentView.FadeTo(1, 300);

        }


    }
}
