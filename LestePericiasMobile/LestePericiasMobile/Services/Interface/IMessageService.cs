using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Services.Interface
{
    public interface IMessageService
    {
        Task ShowCustomMessage(string message);

        Task ShowCustomMessageTitle(string title, string message);

        Task ShowNetworkProblemError();

        Task<string> ShowCustomActionSheet(string title, params string[] buttons);

        Task<bool> ShowCustomDialog(string title, string desc, string affirmative, string negative);

    }
}
