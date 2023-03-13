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
            Vincular_Usuario_GrupoBLL vincular_Usuario_GrupoBLL = new Vincular_Usuario_GrupoBLL();
            Vincular_Usuario_Grupo vincular_usuario_grupo = new Vincular_Usuario_Grupo();

           vincular_usuario_grupo.Id_usuario = Convert.ToInt32(idTextBox_Usuario.Text);
            vincular_usuario_grupo.Id_grupo = Convert.ToInt32(idTextBox_Grupo.Text);

            vincular_Usuario_GrupoBLL.Inserir(vincular_usuario_grupo);
        }
    }
}
