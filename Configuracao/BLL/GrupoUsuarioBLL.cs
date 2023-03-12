﻿using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GrupoUsuarioBLL
    {

        public void Inserir(GrupoUsuario _grupousuario)
        {
            if (_grupousuario.NomeGrupo.Length < 4 || _grupousuario.NomeGrupo.Length > 46)
            {
                throw new Exception("Descrição pequena(menos de 4 caracteres) ou grande (mais de 46 caracteres ");
            }
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
           
            grupousuarioDAL.Inserir(_grupousuario);
        }

        public GrupoUsuario Buscar(string _grupo)
        {
            return new GrupoUsuario();
        }

        public List<GrupoUsuario> BuscarTodosGrupos()
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarTodosGrupos();

        }
        
        public GrupoUsuario BuscarGrupoPorNome(string _nome)
        {
           if (String.IsNullOrEmpty(_nome))
           {
               throw new Exception("Informe o nome do usuário");
           }
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarGrupoPorNome(_nome);

        }
        public GrupoUsuario BuscarGrupoPor_Id(int _id)
        {
           
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            return grupousuarioDAL.BuscarGrupoPorNome(_id);

        }



        public void Alterar(GrupoUsuario _grupousuario)
        {
            if (_grupousuario.NomeGrupo.Length < 4 || _grupousuario.NomeGrupo.Length > 46)
            {
                throw new Exception("Descrição pequena(menos de 4 caracteres) ou grande (mais de 46 caracteres ");
            }

            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.Alterar(_grupousuario);



        }
        public void Excluir(GrupoUsuario _id)
        {
            GrupoUsuarioDAL grupousuarioDAL = new GrupoUsuarioDAL();
            grupousuarioDAL.Excluir(_id);
        }
    }
}