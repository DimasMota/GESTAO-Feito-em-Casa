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
    public partial class FormAdicionarPermissao : Form
    {
        public FormAdicionarPermissao()
        {
            InitializeComponent();
        }

        private void buttonSalvarAdionarPermissao_Click(object sender, EventArgs e)
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Permissao permissao = new Permissao();
            permissao = permissaoBLL.BuscarPermissao_Nome(descricaoTextBox.Text);
            
            
             if(permissao.Descricao == null)
            {
                permissao.Descricao = descricaoTextBox.Text;

                permissaoBLL.Inserir(permissao);
                MessageBox.Show("Cadastrado com Sucusso!");
            }
            else 
            {
                MessageBox.Show("Permissão já cadastrada! \n Decrição: " + permissao.Descricao + "ID: " + permissao.Id);
            }
        }

        private void buttonCancelarAdicionarPermissao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adição de Cadastro CANCELADA!");
            Close();
        }
    }
}
