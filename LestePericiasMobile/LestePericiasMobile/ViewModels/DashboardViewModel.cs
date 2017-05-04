using LestePericiasMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.ViewModels
{
    public class DashboardViewModel : ViewModelBase
    {
        public UserInfoDTO UserInfo { get; set; }

        public DashboardViewModel()
        {
            UserInfo = App.UserInfo;
            
        }

        
    }
}
