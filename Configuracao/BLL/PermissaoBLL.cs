
using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Descricao.Length < 4 || _permissao.Descricao.Length > 145)
            {
                throw new Exception("Descrição pequena(menos de 4 caracteres) ou grande (mais de 145 caracteres ");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }

        public List<Permissao> BuscarTodasPermissoes()
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarTodasPermissoes();
        }
        public Permissao BuscarPermissao_Nome(string _nome)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarPermissao_Nome(_nome);
        }
        public Permissao BuscarPermissao_Id(int _id)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarPermissao_Id(_id);
        }


        public void Alterar(Permissao _permissao)
        {
            if (_permissao.Descricao.Length < 4 || _permissao.Descricao.Length > 145)
            {
                throw new Exception("Descrição pequena(menos de 4 caracteres) ou grande (mais de 145 caracteres ");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(_permissao);

        }
        public void Excluir(Permissao _id)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Excluir(_id);
        }
    }
}