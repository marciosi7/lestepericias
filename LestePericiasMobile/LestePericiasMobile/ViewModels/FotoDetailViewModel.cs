using LestePericiasMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LestePericiasMobile.ViewModels
{
    public class FotoDetailViewModel
    {
        public FotoDTO FotoAtual { get; set; }
        public FotoDetailViewModel(FotoDTO foto)
        {
            FotoAtual = foto;
        }
    }
}
