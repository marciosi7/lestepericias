using LestePericiasMobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LestePericiasMobile.Services.Interface
{
    interface IVistoriasService
    {
        List<Models.VistoriaDTO> GetVistoriasNovasList(long IdUsuario);

        List<Models.VistoriaDTO> GetVistoriasFeitasList(long IdUsuario);

        Task<int> Save(VistoriaDTO obj);

        Task<List<VistoriaDTO>> GetAll(long idUsuario);
    }
}
