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

        Task NavigateToVistoriasMain();

        Task NavigateToFaleConosco();

        Task NavigateToCriarVistoriaDetail();

        Task NavigateToCriarVistoriaFotoDetail();

        void CleanStack();
    }
}
