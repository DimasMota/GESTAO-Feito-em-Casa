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
    public partial class FormExcluirUsuario : Form
    {
        public FormExcluirUsuario()
        {
            InitializeComponent();
        }

        private void buttonExcluirBuscarId_Click(object sender, EventArgs e)
        {

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = usuarioBLL.BuscarUsuarioPorId(Convert.ToInt32(idTextBox.Text));

            nomeTextBox.Text = usuario.Nome;
            dataNascimentoTextBox.Text = usuario.DataNascimento;
            cpfTextBox.Text = usuario.Cpf;
            nomeUsuarioTextBox.Text = usuario.NomeUsuario;
            emailTextBox.Text = usuario.Email;
            senhaTextBox.Text = usuario.Senha;
            ativoCheckBox.Checked = usuario.Ativo;

        }

        private void buttonExluir_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Id = Convert.ToInt32(idTextBox.Text);
            usuarioBLL.Excluir(usuario );
            MessageBox.Show("Exclusão realizada com sucesso!");
            Close();

        }

        private void buttonCancelarExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exclusão cancelada!");
            Close();
        }
    }
}
