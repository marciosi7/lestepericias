using LestePericiasMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LestePericiasMobile.ViewModels
{
   public class CategoriaFotosViewModel
    {
        public ICommand ToFotoCommand { get; private set; }
        public ICommand AdicionarNovaFotoCommand { get; private set; }
        public FotoDTO LastTappedFoto { get; set; }
        public ObservableCollection<FotoDTO> Fotos { get; set; }
        public CategoriaFotosViewModel()
        {
            ToFotoCommand = new Command(toFoto);
            
        }

        private void toFoto()
        {
            if(LastTappedFoto == Fotos.Last())
            {
                // Adicionar Foto
            }
            else
            {
                // EditarFoto
            }
        }
        
    }
}
