using LestePericiasMobile.Models;
using LestePericiasMobile.Services.Interface;
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
    class VistoriasNovasViewModel : ViewModelBase
    {
        public ObservableCollection<VistoriaDTO> VistoriasList { get; set; }
        private readonly Services.Interface.IVistoriasService _vistoriasService;
        public VistoriasNovasViewModel()
        {
            _vistoriasService = DependencyService.Get<IVistoriasService>();
            VistoriasList = new ObservableCollection<VistoriaDTO>();
            LoadVistorias();
        }

        public void LoadVistorias()
        {
            List<VistoriaDTO> vistoriasTemp = null;
            try
            {
                vistoriasTemp = _vistoriasService.GetVistoriasNovasList(App.UserInfo.IdUsuario);
            }
            catch (HttpRequestException e)
            {
                _messageService.ShowNetworkProblemError();
                System.Diagnostics.Debug.WriteLine(e);    
            }
            if(vistoriasTemp == null)
            {
                return;
            }
            foreach(VistoriaDTO vistoria in vistoriasTemp)
            {
                VistoriasList.Add(vistoria);
            }
            Notify("VistoriasList");
        }
    }
}
