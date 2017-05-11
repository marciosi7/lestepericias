using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Models
{
    [Table("Vistorias")]
    public class VistoriaDTO
    {
        [PrimaryKey]
        public long IdVistoria { get; set; }

        public string VeiculoNome { get; set; }

        public string VeiculoPlaca { get; set; }

        public string Descricao { get; set; }

        public string Endereco { get; set; }

        public string Localizacao { get; set; }

        public string Thumbnail { get; set; }

        public bool FoiAceito { get; set; }

        public bool FoiEnviado { get; set; }
       
        public long IdUsuario { get; set; }

        public DateTime DataCriacao { get; set; }


    }
}
