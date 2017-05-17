using LestePericiasMobile.Data;
using LestePericiasMobile.Models;
using LestePericiasMobile.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LestePericiasMobile.Repositories
{
    public class LoginDTORepository : IRepository<LoginDTO>
    {

        public Task<List<LoginDTO>> Listar()
        {
            return LesteVistoriasDatabase.Conexao.Table<LoginDTO>().OrderBy(c => c.Login).ToListAsync();
        }

        Task<int> Delete(LoginDTO id)
        {
            throw new NotImplementedException();
        }

        Task<List<LoginDTO>> GetAll(long idUsuario)
        {
            throw new NotImplementedException();
        }

        Task<LoginDTO> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(LoginDTO obj)
        {
            //if (obj.IdLogin != 0)
            //{
            //    return database.UpdateAsync(obj);
            //}
            //else
            //{
            return LesteVistoriasDatabase.Conexao.InsertAsync(obj);
           // }
        }

        Task<List<LoginDTO>> IRepository<LoginDTO>.GetAll(long idUsuario)
        {
            throw new NotImplementedException();
        }

        Task<LoginDTO> IRepository<LoginDTO>.GetById(long id)
        {
            throw new NotImplementedException();
        }

        Task<int> IRepository<LoginDTO>.Delete(LoginDTO id)
        {
            throw new NotImplementedException();
        }

      
    }
}
