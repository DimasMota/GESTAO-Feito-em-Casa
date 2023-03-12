namespace WindowsFormsAppPrincipal
{
    partial class FormExcluirGrupo
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
            System.Windows.Forms.Label nomeGrupoLabel;
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.buttonExcluirGrupo = new System.Windows.Forms.Button();
            this.buttonCancelarExclusaoGrupo = new System.Windows.Forms.Button();
            this.buttonBuscarExcluir = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(96, 98);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(30, 141);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(85, 13);
            nomeGrupoLabel.TabIndex = 3;
            nomeGrupoLabel.Text = "Nome do Grupo:";
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(121, 95);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(121, 138);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(187, 20);
            this.nomeGrupoTextBox.TabIndex = 4;
            // 
            // buttonExcluirGrupo
            // 
            this.buttonExcluirGrupo.Location = new System.Drawing.Point(121, 194);
            this.buttonExcluirGrupo.Name = "buttonExcluirGrupo";
            this.buttonExcluirGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirGrupo.TabIndex = 5;
            this.buttonExcluirGrupo.Text = "Excluir";
            this.buttonExcluirGrupo.UseVisualStyleBackColor = true;
            this.buttonExcluirGrupo.Click += new System.EventHandler(this.buttonExcluirGrupo_Click);
            // 
            // buttonCancelarExclusaoGrupo
            // 
            this.buttonCancelarExclusaoGrupo.Location = new System.Drawing.Point(233, 194);
            this.buttonCancelarExclusaoGrupo.Name = "buttonCancelarExclusaoGrupo";
            this.buttonCancelarExclusaoGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarExclusaoGrupo.TabIndex = 6;
            this.buttonCancelarExclusaoGrupo.Text = "Cancelar";
            this.buttonCancelarExclusaoGrupo.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarExcluir
            // 
            this.buttonBuscarExcluir.Location = new System.Drawing.Point(233, 93);
            this.buttonBuscarExcluir.Name = "buttonBuscarExcluir";
            this.buttonBuscarExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarExcluir.TabIndex = 7;
            this.buttonBuscarExcluir.Text = "Buscar";
            this.buttonBuscarExcluir.UseVisualStyleBackColor = true;
            this.buttonBuscarExcluir.Click += new System.EventHandler(this.buttonBuscarExcluir_Click);
            // 
            // FormExcluirGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 294);
            this.Controls.Add(this.buttonBuscarExcluir);
            this.Controls.Add(this.buttonCancelarExclusaoGrupo);
            this.Controls.Add(this.buttonExcluirGrupo);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "FormExcluirGrupo";
            this.Text = "Gestão - Excluir Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button buttonExcluirGrupo;
        private System.Windows.Forms.Button buttonCancelarExclusaoGrupo;
        private System.Windows.Forms.Button buttonBuscarExcluir;
    }
}