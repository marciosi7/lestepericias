using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Services.Interface
{
    public interface INavigationService
    {
        Task NavigateToDashboard();

        void NavigateToLogin();

        Task NavigateToNovasVistorias();

        Task NavigateToVistoriasFeitas();

        Task NavigateToFaleConosco();

        Task NavigateToVistoriaDetail();

        Task NavigateToVistoriaFotoDetail();
    }
}
