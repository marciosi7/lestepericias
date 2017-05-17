using LestePericiasMobile.Models;
using LestePericiasMobile.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LestePericiasMobile.Repositories
{
    public class VistoriasRepository : IRepository<VistoriaDTO>
    {
        public Task<int> Delete(VistoriaDTO id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VistoriaDTO>> GetAll(long idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task<VistoriaDTO> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<VistoriaDTO>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(VistoriaDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
