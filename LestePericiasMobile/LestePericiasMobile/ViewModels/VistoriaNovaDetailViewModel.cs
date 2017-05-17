using LestePericiasMobile.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LestePericiasMobile.ViewModels
{
    class VistoriaNovaDetailViewModel : ViewModelBase
    {
        public VistoriaDTO Vistoria { get; set; }

        public ICommand ToVoltarCommand { get; set; }

        //teste do banco de dados
        public ICommand ToSalvarCommand { get; set; }

        public ICommand ToGetAllCommand { get; set; }

        protected readonly Services.Interface.IVistoriasService _vistoriaService;

        public VistoriaNovaDetailViewModel(VistoriaDTO vistoria)
        {
            _vistoriaService = Xamarin.Forms.DependencyService.Get<Services.Interface.IVistoriasService>();
            Vistoria = vistoria;
            ToVoltarCommand = new Command(toVoltar);
            ToSalvarCommand = new Command(toSalvar);
            ToGetAllCommand = new Command(ToGetAllAsync);
        }


        private void toSalvar()
        {
            Vistoria.IdUsuario = 1;
            Task<int> retorno = _vistoriaService.Save(Vistoria);

            VistoriaDTO v = new VistoriaDTO()
            {
                VeiculoNome = "Kia Soul",
                VeiculoPlaca = "EUY9127",
                Descricao = "Falar com o Marcio",
                Endereco = "Rua Cantagalo 223",
                FoiEnviado = false,
                IdUsuario = 2,
                Thumbnail = "http://www.leftcoastclassics.com/1962-ford-galaxy/extras/bodygallery/slides/1962-ford-galaxy-300.jpg"
            };

            Task<int> r = _vistoriaService.Save(v);
            Debug.WriteLine(retorno);
        }

        private async void ToGetAllAsync()
        {
            List<VistoriaDTO> list = await _vistoriaService.GetAll(2);
            Debug.WriteLine(list);
        }

        private void toVoltar()
        {
            _navigationService.Back();
        }
    }
}
