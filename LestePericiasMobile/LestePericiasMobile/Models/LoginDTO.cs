using SQLite;

namespace LestePericiasMobile.Models
{
    public class LoginDTO
    {
        [PrimaryKey]
        public long IdLogin { get; set; }

        public string Login { get; set; }
    }
}
