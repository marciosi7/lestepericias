using LestePericiasMobile.Models;
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

        Task NavigateToVistoriasNovas();

        Task NavigateToVistoriasFeitas();

        Task NavigateToFaleConosco();

        Task NavigateToVistoriaNovaDetail(VistoriaDTO vistoria);

        Task Back();

        void CleanStack();
    }
}
