using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class Vincular_Usuario_GrupoBLL
    {
        public void Inserir(Vincular_Usuario_Grupo _id)
        {
           

            Vincular_Usuario_GrupoDAL vincular_usuario_grupoDAL = new Vincular_Usuario_GrupoDAL();
            vincular_usuario_grupoDAL.Inserir(_id);
        }
    }
}
