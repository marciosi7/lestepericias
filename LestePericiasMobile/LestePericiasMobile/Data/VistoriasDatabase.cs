using LestePericiasMobile.Helpers;
using LestePericiasMobile.Models;
using SQLite;
using Xamarin.Forms;

namespace LestePericiasMobile.Data
{

    public class VistoriasDatabase
    {

        public static SQLiteAsyncConnection Db { get; private set; }

        static VistoriasDatabase()
        {
            Db = new SQLiteAsyncConnection(DependencyService.Get<IFileHelperDatabase>().GetLocalFilePath("LestePericias.db3"));
            Db.CreateTablesAsync<VistoriaDTO, FotoDTO, CategoriaDTO, UserInfoDTO>().Wait();
        }
    }
}
