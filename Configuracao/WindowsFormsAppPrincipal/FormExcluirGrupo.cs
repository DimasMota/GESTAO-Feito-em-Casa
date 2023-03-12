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
    public partial class FormExcluirGrupo : Form
    {
        public FormExcluirGrupo()
        {
            InitializeComponent();
        }

        private void buttonBuscarExcluir_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            GrupoUsuario grupousuario = new GrupoUsuario();
            grupousuario = grupousuarioBLL.BuscarGrupoPor_Id(Convert.ToInt32(idTextBox.Text));

            nomeGrupoTextBox.Text = grupousuario.NomeGrupo;

        }

        private void buttonExcluirGrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            GrupoUsuario grupousuario = new GrupoUsuario();
            grupousuario.Id = (Convert.ToInt32(idTextBox.Text));
           

            grupousuarioBLL.Excluir(grupousuario);

            MessageBox.Show("Grupo excluido com sucesso");

        }
    }
}
