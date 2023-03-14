namespace WindowsFormsAppPrincipal
{
    partial class FormExcluir_Vinculo_Usuario_Grupo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nomeGrupoLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscar_ExluirUsuario_Grupo = new System.Windows.Forms.Button();
            this.buttonExcluir_Usuario_Grupo = new System.Windows.Forms.Button();
            this.buttonCancelar_ExcluirUsuario_Grupo = new System.Windows.Forms.Button();
            this.buttonLimparIdNome = new System.Windows.Forms.Button();
            this.radioButtonPesquisar_Id = new System.Windows.Forms.RadioButton();
            this.radioButtonPesquisar_nome = new System.Windows.Forms.RadioButton();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(43, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(69, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(165, 63);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(209, 60);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(316, 20);
            this.nomeTextBox.TabIndex = 4;
            // 
            // grupoUsuariosBindingSource
            // 
            this.grupoUsuariosBindingSource.DataMember = "GrupoUsuarios";
            this.grupoUsuariosBindingSource.DataSource = this.usuarioBindingSource;
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(18, 135);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 5;
            idLabel1.Text = "Id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuariosBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(43, 132);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(69, 20);
            this.idTextBox1.TabIndex = 6;
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(118, 135);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(85, 13);
            nomeGrupoLabel.TabIndex = 7;
            nomeGrupoLabel.Text = "Nome do Grupo:";
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuariosBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(209, 132);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(316, 20);
            this.nomeGrupoTextBox.TabIndex = 8;
            // 
            // grupoUsuariosDataGridView
            // 
            this.grupoUsuariosDataGridView.AllowUserToAddRows = false;
            this.grupoUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuariosDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuariosDataGridView.AutoGenerateColumns = false;
            this.grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(21, 199);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(649, 220);
            this.grupoUsuariosDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome do Grupo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // buttonBuscar_ExluirUsuario_Grupo
            // 
            this.buttonBuscar_ExluirUsuario_Grupo.Location = new System.Drawing.Point(531, 60);
            this.buttonBuscar_ExluirUsuario_Grupo.Name = "buttonBuscar_ExluirUsuario_Grupo";
            this.buttonBuscar_ExluirUsuario_Grupo.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar_ExluirUsuario_Grupo.TabIndex = 10;
            this.buttonBuscar_ExluirUsuario_Grupo.Text = "Buscar";
            this.buttonBuscar_ExluirUsuario_Grupo.UseVisualStyleBackColor = true;
            this.buttonBuscar_ExluirUsuario_Grupo.Click += new System.EventHandler(this.buttonBuscar_ExluirUsuario_Grupo_Click);
            // 
            // buttonExcluir_Usuario_Grupo
            // 
            this.buttonExcluir_Usuario_Grupo.Location = new System.Drawing.Point(531, 130);
            this.buttonExcluir_Usuario_Grupo.Name = "buttonExcluir_Usuario_Grupo";
            this.buttonExcluir_Usuario_Grupo.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir_Usuario_Grupo.TabIndex = 11;
            this.buttonExcluir_Usuario_Grupo.Text = "Excluir";
            this.buttonExcluir_Usuario_Grupo.UseVisualStyleBackColor = true;
            this.buttonExcluir_Usuario_Grupo.Click += new System.EventHandler(this.buttonExcluir_Usuario_Grupo_Click);
            // 
            // buttonCancelar_ExcluirUsuario_Grupo
            // 
            this.buttonCancelar_ExcluirUsuario_Grupo.Location = new System.Drawing.Point(612, 130);
            this.buttonCancelar_ExcluirUsuario_Grupo.Name = "buttonCancelar_ExcluirUsuario_Grupo";
            this.buttonCancelar_ExcluirUsuario_Grupo.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar_ExcluirUsuario_Grupo.TabIndex = 12;
            this.buttonCancelar_ExcluirUsuario_Grupo.Text = "Cancelar";
            this.buttonCancelar_ExcluirUsuario_Grupo.UseVisualStyleBackColor = true;
            this.buttonCancelar_ExcluirUsuario_Grupo.Click += new System.EventHandler(this.buttonCancelar_ExcluirUsuario_Grupo_Click);
            // 
            // buttonLimparIdNome
            // 
            this.buttonLimparIdNome.Location = new System.Drawing.Point(612, 60);
            this.buttonLimparIdNome.Name = "buttonLimparIdNome";
            this.buttonLimparIdNome.Size = new System.Drawing.Size(75, 23);
            this.buttonLimparIdNome.TabIndex = 13;
            this.buttonLimparIdNome.Text = "Limpar";
            this.buttonLimparIdNome.UseVisualStyleBackColor = true;
            this.buttonLimparIdNome.Click += new System.EventHandler(this.buttonLimparIdNome_Click);
            // 
            // radioButtonPesquisar_Id
            // 
            this.radioButtonPesquisar_Id.AutoSize = true;
            this.radioButtonPesquisar_Id.Location = new System.Drawing.Point(27, 37);
            this.radioButtonPesquisar_Id.Name = "radioButtonPesquisar_Id";
            this.radioButtonPesquisar_Id.Size = new System.Drawing.Size(103, 17);
            this.radioButtonPesquisar_Id.TabIndex = 14;
            this.radioButtonPesquisar_Id.TabStop = true;
            this.radioButtonPesquisar_Id.Text = "Pesquisar por ID";
            this.radioButtonPesquisar_Id.UseVisualStyleBackColor = true;
            // 
            // radioButtonPesquisar_nome
            // 
            this.radioButtonPesquisar_nome.AutoSize = true;
            this.radioButtonPesquisar_nome.Location = new System.Drawing.Point(209, 37);
            this.radioButtonPesquisar_nome.Name = "radioButtonPesquisar_nome";
            this.radioButtonPesquisar_nome.Size = new System.Drawing.Size(118, 17);
            this.radioButtonPesquisar_nome.TabIndex = 15;
            this.radioButtonPesquisar_nome.TabStop = true;
            this.radioButtonPesquisar_nome.Text = "Pesquisar por nome";
            this.radioButtonPesquisar_nome.UseVisualStyleBackColor = true;
            // 
            // FormExcluir_Vinculo_Usuario_Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.radioButtonPesquisar_nome);
            this.Controls.Add(this.radioButtonPesquisar_Id);
            this.Controls.Add(this.buttonLimparIdNome);
            this.Controls.Add(this.buttonCancelar_ExcluirUsuario_Grupo);
            this.Controls.Add(this.buttonExcluir_Usuario_Grupo);
            this.Controls.Add(this.buttonBuscar_ExluirUsuario_Grupo);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "FormExcluir_Vinculo_Usuario_Grupo";
            this.Text = "Gestão - Excluir Usuário do Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonBuscar_ExluirUsuario_Grupo;
        private System.Windows.Forms.Button buttonExcluir_Usuario_Grupo;
        private System.Windows.Forms.Button buttonCancelar_ExcluirUsuario_Grupo;
        private System.Windows.Forms.Button buttonLimparIdNome;
        private System.Windows.Forms.RadioButton radioButtonPesquisar_Id;
        private System.Windows.Forms.RadioButton radioButtonPesquisar_nome;
    }
}