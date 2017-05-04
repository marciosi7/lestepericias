using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Services.Interface
{
    interface IVistoriasService
    {
        List<Models.VistoriaDTO> GetVistoriasNovasList(long IdUsuario);

        List<Models.VistoriaDTO> GetVistoriasFeitasList(long IdUsuario);
    }
}
