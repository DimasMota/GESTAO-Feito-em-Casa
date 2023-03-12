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
    public partial class FormAlterarPermissao : Form
    {
        public FormAlterarPermissao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Permissao permissao = new Permissao();
            permissao = permissaoBLL.BuscarPermissao_Id(Convert.ToInt32(idTextBox.Text));

            descricaoTextBox.Text = permissao.Descricao;


        }

        private void buttonSalvarAlteracaoPermissao_Click(object sender, EventArgs e)
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Permissao permissao = new Permissao();
            permissao.Descricao = descricaoTextBox.Text;
            permissao.Id = Convert.ToInt32(idTextBox.Text);
            permissaoBLL.Alterar(permissao);

            MessageBox.Show("Alteração realizada com Sucesso!");

            idTextBox.Text = "";
            descricaoTextBox.Text = "";

        }

        private void buttonCancelarAlteracaoPermissao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alteração cancelada com sucesso");
            Close();
        }
    }
}
