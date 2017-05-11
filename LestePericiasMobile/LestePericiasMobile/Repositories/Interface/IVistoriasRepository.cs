using LestePericiasMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Repositories.Interface
{
    interface IVistoriasRepository
    {
        Task<List<VistoriaDTO>> GetAll(long idUsuario);
        
        Task<VistoriaDTO> GetById(long id);

        Task<int> Save(VistoriaDTO obj);

        Task<int> Delete(VistoriaDTO id);

        Task<List<VistoriaDTO>> GetVistoriasNaoAceitas(long idUsuario);

        Task<List<VistoriaDTO>> GetVistoriasAceitas(long idUsuario);

    }
}
