using LestePericiasMobile.Models;
using LestePericiasMobile.Repositories;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LestePericiasMobile.ViewModels
{
    public class TesteDBViewModel :ViewModelBase
    {
        //private LoginDTO loginDTO;
        //public LoginDTO LoginDTO {
        //    get
        //    {
        //        return loginDTO;
        //    }
        //    set
        //    {
        //        loginDTO = value;
        //        Notify("LoginDTO");
        //    }
        //}

        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
                Notify("Login");
            }
        }

        private long idLogin;
        public long IdLogin
        {
            get
            {
                return idLogin;
            }
            set
            {
                idLogin = value;
                Notify("IdLogin");
            }
        }

        public ICommand ToInserLoginDTO { get; private set; }

        public ObservableCollection<LoginDTO> LoginDTOList { get; set; }

        public TesteDBViewModel()
        {
            ToInserLoginDTO = new Command(toInsertLoginDTO);
            //     LoginDTO = new LoginDTO();
            LoginDTOList = new ObservableCollection<LoginDTO>();

        }

        public void toInsertLoginDTO()
        {
         LoginDTO l =   new LoginDTO()
            {
                IdLogin = IdLogin,
                Login = Login
            };
          

            new LoginDTORepository().Save(l);

            LoadListLoginDTOAsync();

        }

        public async Task LoadListLoginDTOAsync()
        {
            List<LoginDTO> r = await new LoginDTORepository().Listar();

            foreach (LoginDTO l in r)
            {
                LoginDTOList.Add(l);
                Debug.WriteLine(l.Login);
            }

            Notify("LoginDTOList");


        }
    }
}
