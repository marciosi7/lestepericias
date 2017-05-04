using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LestePericiasMobile.Models;

namespace LestePericiasMobile.Services
{
    class LoginService : ILoginService
    {
        public async Task<UserInfoDTO> LoginServidor(string login, string password)
        {
            return await Task.Run( () => {
                return new UserInfoDTO()
                {
                    Nome = "Augustus Calvin",
                    IdUsuario = 1,
                    Username = "aug202"
                };
            });
            
        }
    }
}
