using LestePericiasMobile.Data;
using LestePericiasMobile.Helpers;
using LestePericiasMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Repositories
{
    public class VistoriasRepository : IRepository<VistoriaDTO>
    {
       

        public Task<List<VistoriaDTO>> GetAll(long idUsuario)
        {
            return VistoriasDatabase.Db.Table<VistoriaDTO>().Where(i => i.IdUsuario == idUsuario).ToListAsync();
        }

        public Task<VistoriaDTO> GetById(long id)
        {
            return VistoriasDatabase.Db.Table<VistoriaDTO>().Where(i => i.IdVistoria == id).FirstOrDefaultAsync();
        }

        public Task<int> Save(VistoriaDTO vistoria)
        {
            if (vistoria.IdVistoria != 0)
            {
                return VistoriasDatabase.Db.UpdateAsync(vistoria);
            }
            else
            {
                return VistoriasDatabase.Db.InsertAsync(vistoria);
            }
        }

        public Task<int> Delete(VistoriaDTO vistoria)
        {
            return VistoriasDatabase.Db.DeleteAsync(vistoria);
        }
      
    }
}
