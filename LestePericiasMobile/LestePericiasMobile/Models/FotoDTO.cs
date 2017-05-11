using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Models
{
    [Table("Fotos")]
    class FotoDTO
    {
        [PrimaryKey, AutoIncrement]
        public long IdFoto { get; set; }

        public long IdVistoria { get; set; }

        public string Descricao { get; set; }

        public byte[] Source { get; set; }

        public string Categoria { get; set; }
    }
}
