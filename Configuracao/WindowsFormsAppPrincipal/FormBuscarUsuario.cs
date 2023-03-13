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
    public partial class FormBuscarUsuario : Form
    {
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
            }
            else if(radioButton2.Checked)
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                       

                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorNomeAcesso(textBox1.Text);
              

            }
            else if (radioButton3.Checked)
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
              
                GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
               
               
                usuarioBindingSource.DataSource = usuarioBLL.BuscarUsuarioPorId (Convert.ToInt32(textBox1.Text));
                              
               
                grupoUsuariosBindingSource.DataSource = grupousuarioBLL.BuscarTodos_GruposPorUsuario(Convert.ToInt32(textBox1.Text));
            }

        }

        private void buttonBuscarAlterar_Click(object sender, EventArgs e)
        {
            using (FormAlterarUsuario frm = new FormAlterarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscarAdionar_Click(object sender, EventArgs e)
        {
            using (FormAdicionarUsuario frm = new FormAdicionarUsuario())
            {
                frm.ShowDialog();
               
                
            }
            
            
        }

        private void buttonBuscarExcluir_Click(object sender, EventArgs e)
        {
            using (FormExcluirUsuario frm = new FormExcluirUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscarAdicionarGrupo_Click(object sender, EventArgs e)
        {
            using (FormVincular_Usuario_Grupo frm = new FormVincular_Usuario_Grupo())
            {
                frm.ShowDialog();
            }
        }
    }
}
