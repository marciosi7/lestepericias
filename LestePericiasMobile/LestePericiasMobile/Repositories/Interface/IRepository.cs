using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LestePericiasMobile.Repositories.Interface
{
    interface IRepository<T> 
    {
        Task<List<T>> GetAll(long idUsuario);


        Task<T> GetById(long id);


        Task<int> Save(T obj);


        Task<int> Delete(T id);

        Task<List<T>> Listar();
        
    }
}
