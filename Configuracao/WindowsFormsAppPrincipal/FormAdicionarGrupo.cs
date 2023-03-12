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
    public partial class FormAdicionarGrupo : Form
    {
        public FormAdicionarGrupo()
        {
            InitializeComponent();
        }

        private void buttonAdionarGrupoSalvar_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            GrupoUsuario grupousuario = new GrupoUsuario();

            grupousuario.NomeGrupo = nomeGrupoTextBox.Text;

            grupoUsuarioBLL.Inserir(grupousuario);

            MessageBox.Show("Grupo adicionado com realizado ");
        }

        private void buttonAdionarGrupoCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inserção Cancelada");
            Close();
        }
    }
}
