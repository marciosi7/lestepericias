using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Models
{
    [Table("Categorias")]
    public class CategoriaDTO
    {
        [PrimaryKey]
        public string IdCategoria { get; set; }

        public string Nome { get; set; }
    }
}
