﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LestePericiasMobile.Models;
using LestePericiasMobile.Repositories;
using LestePericiasMobile.Data;

namespace LestePericiasMobile.Services
{
    class VistoriasService : Interface.IVistoriasService
    {
        private List<VistoriaDTO> vistorias = new List<VistoriaDTO>()
        {
            new VistoriaDTO()
            {
                VeiculoNome = "Corolla",
                VeiculoPlaca = "DBC3351",
                Descricao = "Falar com o Carlos",
                Endereco = "Avenida Caquito 222",
                FoiEnviado = true,
                Thumbnail = "http://i.ebayimg.com/00/s/NTA2WDkwMA==/z/tPoAAOSw6EhUUMHY/$_32.JPG"
            },

            new VistoriaDTO()
            {
                VeiculoNome = "Galaxy",
                VeiculoPlaca = "ABC3050",
                Descricao = "Falar com o Vinicius",
                Endereco = "Rua Cantagalo 223",
                FoiEnviado = false,
                Thumbnail = "http://www.leftcoastclassics.com/1962-ford-galaxy/extras/bodygallery/slides/1962-ford-galaxy-300.jpg"
            },

        };

        public Task<List<VistoriaDTO>> GetAll(long idUsuario)
        {
          //  Task<List<VistoriaDTO>> r = App.Database.GetAll(idUsuario);

            return null;

          
        }

        public List<VistoriaDTO> GetVistoriasFeitasList(long IdUsuario)
        {
            return vistorias;
        }

        public List<VistoriaDTO> GetVistoriasNovasList(long IdUsuario)
        {
            return vistorias;
        }

        //public Task<int> Save(VistoriaDTO obj)
        //{
        //   return new VistoriasRepository().Save(obj);
        //}

        public Task<int> Save(VistoriaDTO obj)
        {
            return null;
        }
    }
}
