using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Vincular_Usuario_GrupoDAL
    {
        public void Inserir(Vincular_Usuario_Grupo _id)
        {
            SqlConnection cn = new SqlConnection();
            try
            {

                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO Grupo_com_Usuario_N_N (cod_usuario, cod_GrupoUsuario)" +
                                  "VALUES (@cod_usuario, @cod_grupousuario)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@cod_usuario", _id.Id_usuario);
                cmd.Parameters.AddWithValue("@cod_grupousuario", _id.Id_grupo);
              

                cn.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco " + ex.Message);


            }
            finally
            {
                cn.Close();
            }


        }


      



    }

}
