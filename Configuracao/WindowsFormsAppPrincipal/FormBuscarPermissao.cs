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
    public partial class FormBuscarPermissao : Form
    {
        public FormBuscarPermissao()
        {
            InitializeComponent();
        }

        private void buttonBuscarPermissao_Click(object sender, EventArgs e)
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            if (radioButtonBuscarTodos.Checked)
            {
                permissaoBindingSource.DataSource = permissaoBLL.BuscarTodasPermissoes();
            }
            else if (radioButtonBuscarPorNome.Checked)
            {
                permissaoBindingSource.DataSource = permissaoBLL.BuscarPermissao_Nome(textBoxPermissaoPesquisar.Text);
            }
            else if (radioButtonBuscarPor_Id.Checked)
            {
                permissaoBindingSource.DataSource = permissaoBLL.BuscarPermissao_Id(Convert.ToInt32(textBoxPermissaoPesquisar.Text));
            }
            else
            {
                MessageBox.Show("Escolha a forma de pesquisa");
            }
        }

        private void buttonAdicionarPermissao_Click(object sender, EventArgs e)
        {
            using (FormAdicionarPermissao frm = new FormAdicionarPermissao())
            {
                frm.ShowDialog();
            }

        }

        private void buttonAlterarPermissao_Click(object sender, EventArgs e)
        {
            using (FormAlterarPermissao frm = new FormAlterarPermissao())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluirPermissao_Click(object sender, EventArgs e)
        {
           using (FormExcluirPermissao frm = new FormExcluirPermissao())
            {
                frm.ShowDialog();
            }
        }
    }
}
