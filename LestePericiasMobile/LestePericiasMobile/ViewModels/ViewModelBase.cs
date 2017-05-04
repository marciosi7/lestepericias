using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected readonly Services.Interface.IMessageService _messageService;
        protected readonly Services.Interface.INavigationService _navigationService;
        public ViewModelBase()
        {
            _messageService = Xamarin.Forms.DependencyService.Get<Services.Interface.IMessageService>();
            _navigationService = Xamarin.Forms.DependencyService.Get<Services.Interface.INavigationService>();
            IsBusy = false;

        }
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                Notify("IsBusy");
            }
        }
        protected void Notify(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
