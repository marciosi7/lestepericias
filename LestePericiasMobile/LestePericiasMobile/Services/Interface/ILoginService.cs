using System.Threading.Tasks;

namespace LestePericiasMobile.Services
{
    public interface ILoginService
    {

        Task<Models.UserInfoDTO> LoginServidor(string login, string password);
    }
}
