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
    public partial class FormAlterarGrupo : Form
    {
        public FormAlterarGrupo()
        {
            InitializeComponent();
        }

        private void buttonAlterarGrupoBuscar_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            GrupoUsuario grupousuario = new GrupoUsuario();
            if (idTextBox.Text == "")
            {
                MessageBox.Show("Insira um ID.");
            }
            else
            {
                grupousuario = grupousuarioBLL.BuscarGrupoPor_Id(Convert.ToInt32(idTextBox.Text));

            }


            nomeGrupoTextBox.Text = grupousuario.NomeGrupo;

        }

        private void buttonAlterarGrupoSalvar_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            GrupoUsuario grupousuario = new GrupoUsuario();
            grupousuario.Id = Convert.ToInt32(idTextBox.Text);
            grupousuario.NomeGrupo = nomeGrupoTextBox.Text;
            grupousuarioBLL.Alterar(grupousuario);
            MessageBox.Show("Alteração realizada com sucesso!");
        }

        private void buttonAlterarGrupoCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alteração Cancelada!");
            Close();
        }
    }
}
