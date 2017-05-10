using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.Helpers
{
    public interface IFileHelperDatabase
    {
        string GetLocalFilePath(string filename);
    }
}
