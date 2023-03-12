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
    public partial class FormAlterarUsuario : Form
    {
        public FormAlterarUsuario()
        {
            InitializeComponent();
        }

        private void buttonAlterarBuscarId_Click(object sender, EventArgs e)
        {
            
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = usuarioBLL.BuscarUsuarioPorId(Convert.ToInt32(Convert.ToInt32 (idTextBox.Text)));

            nomeTextBox.Text = usuario.Nome;
            dataNascimentoTextBox.Text = usuario.DataNascimento;
            cpfTextBox.Text = usuario.Cpf;
            nomeUsuarioTextBox.Text = usuario.NomeUsuario;
            emailTextBox.Text = usuario.Email;
            senhaTextBox.Text = usuario.Senha;
            ativoCheckBox.Checked = usuario.Ativo;

           


        }

        private void buttonAlterarSalvar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuario.Nome = nomeTextBox.Text;
            usuario.DataNascimento = dataNascimentoTextBox.Text;
            usuario.Cpf = cpfTextBox.Text;
            usuario.Email = emailTextBox.Text;
            usuario.NomeUsuario = nomeUsuarioTextBox.Text;
            usuario.Senha = senhaTextBox.Text;
            usuario.Ativo = ativoCheckBox.Checked;
            usuarioBLL.Alterar(usuario);

            MessageBox.Show("Cadastro Alterado com Sucesso!");

        }

        private void buttonAlterarCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alteração de cadastro cancelada com sucesso!");
            Close();
        }
    }
}
