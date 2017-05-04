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
                FoiEnviado = true
            },

            new VistoriaDTO()
            {
                VeiculoNome = "Siena",
                VeiculoPlaca = "ABC3050",
                FoiEnviado = false
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
