using SQLite;

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
