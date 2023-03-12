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
    public partial class FormAdicionarUsuario : Form
    {
        public FormAdicionarUsuario()
        {
            InitializeComponent();
        }

        private void buttonUsuarioAdionarCadastro_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = nomeTextBox.Text;
            usuario.DataNascimento = dataNascimentoTextBox.Text;
            usuario.Cpf = cpfTextBox.Text;
            usuario.Email = emailTextBox.Text;
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = Convert.ToBoolean(ativoCheckBox.Text);
            usuarioBLL.Inserir(usuario);

            MessageBox.Show("Cadastro realizado com sucesso!");
        }

        private void buttonAdionarCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastro CANCELADO com sucesso!");
            Close();


        }
    }
}
