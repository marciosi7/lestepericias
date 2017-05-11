using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Models
{
    [Table("Usuarios")]
    public class UserInfoDTO
    {
        [PrimaryKey]
        public long IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
    }
}
