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
        void NavigateToDashboard();

        void NavigateToLogin();

        void NavigateToVistoriasNovas();

        void NavigateToVistoriasFeitas();

        void NavigateToFaleConosco();

        void NavigateToVistoriaNovaDetail(VistoriaDTO vistoria);

        void NavigateToMeusDados();

        void Back();

    }
}
