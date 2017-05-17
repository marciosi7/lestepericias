using LestePericiasMobile.Helpers;
using LestePericiasMobile.Models;
using SQLite;
using Xamarin.Forms;

namespace LestePericiasMobile.Data
{

    public class LesteVistoriasDatabase
    {

        static SQLiteAsyncConnection conexao;

        public static SQLiteAsyncConnection Conexao
        {
            get
            {
                if (conexao == null)
                {
                    conexao = new SQLiteAsyncConnection(DependencyService.Get<IFileHelperDatabase>().GetLocalFilePath("LestePericias.db3"));
                    conexao.CreateTablesAsync<VistoriaDTO, FotoDTO, CategoriaDTO, UserInfoDTO, LoginDTO>().Wait();
                }
                return conexao;
            }
        }
       
    }
}
