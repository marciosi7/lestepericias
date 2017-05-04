using LestePericiasMobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LestePericiasMobile.ViewModels
{
    class VistoriasFeitasViewModel : ViewModelBase
    {
        public ObservableCollection<VistoriaDTO> VistoriasList { get; set; }
        private readonly Services.Interface.IVistoriasService _vistoriasService;
        public VistoriasFeitasViewModel()
        {
            _vistoriasService = DependencyService.Get<Services.Interface.IVistoriasService>();
            VistoriasList = new ObservableCollection<VistoriaDTO>();
            LoadVistorias();
        }

        public void LoadVistorias()
        {
            List<VistoriaDTO> vistoriasTemp = null;
            try
            {
                vistoriasTemp = _vistoriasService.GetVistoriasFeitasList(App.UserInfo.IdUsuario);
            }
            catch (HttpRequestException e)
            {
                _messageService.ShowNetworkProblemError();
                System.Diagnostics.Debug.WriteLine(e);
            }
            if (vistoriasTemp == null)
            {
                return;
            }

            foreach (VistoriaDTO vistoria in vistoriasTemp)
            {
                VistoriasList.Add(vistoria);
            }
            Notify("VistoriasList");
        }

    }
}
