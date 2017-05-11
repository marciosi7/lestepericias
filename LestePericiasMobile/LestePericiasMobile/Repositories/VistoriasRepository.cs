using LestePericiasMobile.Data;
using LestePericiasMobile.Helpers;
using LestePericiasMobile.Models;
using LestePericiasMobile.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Repositories
{
    public class VistoriasRepository : IVistoriasRepository
    {
        public Task<List<VistoriaDTO>> GetAll(long idUsuario)
        {
            return VistoriasDatabase.Db.Table<VistoriaDTO>().Where(i => i.IdUsuario == idUsuario).ToListAsync();
        }

        public Task<VistoriaDTO> GetById(long id)
        {
            return VistoriasDatabase.Db.Table<VistoriaDTO>().Where(i => i.IdVistoria == id).FirstOrDefaultAsync();
        }

        public Task<int> Save(VistoriaDTO obj)
        {
            if (obj.IdVistoria != 0)
            {
                return VistoriasDatabase.Db.UpdateAsync(obj);
            }
            else
            {
                return VistoriasDatabase.Db.InsertAsync(obj);
            }
        }

        public Task<int> Delete(VistoriaDTO id)
        {
            return VistoriasDatabase.Db.DeleteAsync(id);
        }

        public Task<List<VistoriaDTO>> GetVistoriasNaoAceitas(long idUsuario)
        {
            return VistoriasDatabase.Db.Table<VistoriaDTO>().Where(i => i.IdUsuario == idUsuario && i.FoiAceito == false).ToListAsync();
        }

        public Task<List<VistoriaDTO>> GetVistoriasAceitas(long idUsuario)
        {
            return VistoriasDatabase.Db.Table<VistoriaDTO>().Where(i => i.IdUsuario == idUsuario && i.FoiAceito == true).ToListAsync();
        }
    }
}
