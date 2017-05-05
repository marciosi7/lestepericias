using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LestePericiasMobile.Models;

namespace LestePericiasMobile.Services
{
    class VistoriasService : Interface.IVistoriasService
    {
        private List<VistoriaDTO> vistorias = new List<VistoriaDTO>()
        {
            new VistoriaDTO()
            {
                VeiculoNome = "Corolla",
                VeiculoPlaca = "DBC3351",
                FoiEnviado = true,
                Thumbnail = "http://ebaycarsellers.com/1s550e.jpg"
            },

            new VistoriaDTO()
            {
                VeiculoNome = "Siena",
                VeiculoPlaca = "ABC3050",
                FoiEnviado = false,
                Thumbnail = "http://www.benzinsider.com/wp-content/uploads/2011/12/%E2%80%9CHangover%E2%80%9D-Car-Being-Sold-on-Ebay-597x337.jpg"
            },

        };

        public List<VistoriaDTO> GetVistoriasFeitasList(long IdUsuario)
        {
            return vistorias;
        }

        public List<VistoriaDTO> GetVistoriasNovasList(long IdUsuario)
        {
            return vistorias;
        }
    }
}
