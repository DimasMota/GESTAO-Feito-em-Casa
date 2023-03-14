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
    public partial class FormVincular_Usuario_Grupo : Form
    {
        public FormVincular_Usuario_Grupo()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario = usuarioBLL.BuscarUsuarioPorId(Convert.ToInt32(idTextBox_Usuario.Text));

            nomeTextBox.Text = usuario.Nome;
        }

        private void buttonBuscarGrupos_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            grupoUsuariosBindingSource.DataSource = grupousuarioBLL.BuscarTodosGrupos();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            GrupoUsuarioBLL grupousuarioBLL = new GrupoUsuarioBLL();
            Usuario usuario = new Usuario();
            GrupoUsuario grupousuario = new GrupoUsuario();
            
            usuario.Id = Convert.ToInt32(idTextBox_Usuario.Text);
            grupousuario.Id = Convert.ToInt32(idTextBox_Grupo.Text);

            usuarioBLL.Vincular_Usuario_Grupo(usuario, grupousuario);
        }
    }
}
