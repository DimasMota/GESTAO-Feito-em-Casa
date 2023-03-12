using BLL;
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

            if (textBox1.Text == "")
            {

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
            }
            else
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorNomeAcesso(textBox1.Text);

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
    }
}
