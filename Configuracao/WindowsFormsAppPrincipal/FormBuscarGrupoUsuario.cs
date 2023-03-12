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
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscarGrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupousuario = new GrupoUsuarioBLL();
           if(radioButton3.Checked) // BUSCAR TODOS
            {
            grupoUsuarioBindingSource.DataSource = grupousuario.BuscarTodosGrupos();

            }
           else if (radioButton1.Checked)//BUSCAR POR NOME
            {
                if (textBox1.Text != "")
                {
                    grupoUsuarioBindingSource.DataSource = grupousuario.BuscarGrupoPorNome(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Insira uma nome");
                }

            }
            else if(radioButton2.Checked)//buscar por ID
            {
                if (textBox1.Text != "")
                {
                grupoUsuarioBindingSource.DataSource = grupousuario.BuscarGrupoPor_Id(Convert.ToInt32(textBox1.Text));
                   
                }
                else
                {
                    MessageBox.Show("Insira uma ID");
                }
            }

            

        }

        private void buttonAlterarGrupo_Click(object sender, EventArgs e)
        {
            using (FormAlterarGrupo frm = new FormAlterarGrupo())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAdionarGrupo_Click(object sender, EventArgs e)
        {
            using (FormAdicionarGrupo frm = new FormAdicionarGrupo())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluirGrupo_Click(object sender, EventArgs e)
        {
            using (FormExcluirGrupo frm = new FormExcluirGrupo())
            {
                frm.ShowDialog();
            }
        }
    }
}
