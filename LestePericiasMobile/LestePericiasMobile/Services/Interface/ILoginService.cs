using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Services
{
    public interface ILoginService
    {

        Task<Models.UserInfoDTO> LoginServidor(string login, string password);
    }
}
