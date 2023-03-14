using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormExcluir_Vinculo_Usuario_Grupo : Form
    {
        public FormExcluir_Vinculo_Usuario_Grupo()
        {
            InitializeComponent();
        }

        private void buttonBuscar_ExluirUsuario_Grupo_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            List<GrupoUsuario> grupousuario = new List<GrupoUsuario>();
            Usuario usuario = new Usuario();


            if (radioButtonPesquisar_Id.Checked)
            {
                if (idTextBox.Text == "")
                {
                    MessageBox.Show("Insira o ID ou Nome do Usuário para Buscar!!");
                }
                else
                {
                    usuario = usuarioBLL.BuscarUsuarioPorId(Convert.ToInt32(idTextBox.Text));
                    if (usuario.Nome == "")
                    {
                        MessageBox.Show("Usuário não encontrador!");
                        idTextBox.Text = "";
                        nomeTextBox.Text = "";
                    }

                    else
                    {
                        nomeTextBox.Text = usuario.Nome;
                    
                        grupoUsuariosBindingSource.DataSource = grupousuarioBLL.BuscarTodos_GruposPorUsuario(Convert.ToInt32(idTextBox.Text));
                        

                    }
                }

            }
            else if (radioButtonPesquisar_nome.Checked)
            {
                usuario = usuarioBLL.BuscarUsuarioPorNome(nomeTextBox.Text);
                if (usuario.Nome =="")
                {
                    MessageBox.Show("Usuário não encontrado!");
                    idTextBox.Text = "";
                    nomeTextBox.Text = "";
                }
                else
                {
                    idTextBox.Text = Convert.ToString(usuario.Id);
                    grupoUsuariosBindingSource.DataSource = grupousuarioBLL.BuscarTodos_GruposPorUsuario(Convert.ToInt32(idTextBox.Text));
                }
            }

        }

        private void buttonLimparIdNome_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nomeTextBox.Text = "";
            idTextBox1.Text = "";
            nomeGrupoTextBox.Text = "";
           
        }

        private void buttonExcluir_Usuario_Grupo_Click(object sender, EventArgs e)
        {
            string menssagem = "Deseja realmente EXCLUIR esta este vínculo com o grupo?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string caption = "Error Detected in Input";
            result = MessageBox.Show(menssagem, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {


                UsuarioBLL usuarioBLL = new UsuarioBLL();

                int id_usuario = Convert.ToInt32(idTextBox.Text);
                int id_grupo = Convert.ToInt32(idTextBox1.Text);


                usuarioBLL.Excluir_Vinculo_Usuario_Grupo(id_usuario, id_grupo);

                MessageBox.Show("Vínculo com o grupo cancelado!");
            }
            else
            {
                Close();
            }

        }

        private void buttonCancelar_ExcluirUsuario_Grupo_Click(object sender, EventArgs e)
        {
           
            Close();
        }
    }
}
