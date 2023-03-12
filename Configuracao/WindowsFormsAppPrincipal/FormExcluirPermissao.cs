using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormExcluirPermissao : Form
    {
        public FormExcluirPermissao()
        {
            InitializeComponent();
        }

        private void buttonBuscarPermissaoExcluir_Click(object sender, EventArgs e)
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Permissao permissao = new Permissao();
            permissao = permissaoBLL.BuscarPermissao_Id(Convert.ToInt32(idTextBox.Text));
            if (permissao.Id == null)
            {
                MessageBox.Show("Permissão não encontrada!");
                idTextBox.Text = "";
                descricaoTextBox.Text = "";
            }
            else
            {
                descricaoTextBox.Text = permissao.Descricao;

            }
        }

        private void buttonExcluirPermissao_Click(object sender, EventArgs e)
        {
            string menssagem = "Deseja realmente EXCLUIR está permissão?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            string caption = "Error Detected in Input";
            result = MessageBox.Show(menssagem, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                Permissao permissao = new Permissao();
                permissao.Id = Convert.ToInt32(idTextBox.Text);
                permissaoBLL.Excluir(permissao);
                MessageBox.Show("Permissão excluida com sucesso!");
                Close();
            }
            else
            {
                Close();

            }





        }
    }
}
