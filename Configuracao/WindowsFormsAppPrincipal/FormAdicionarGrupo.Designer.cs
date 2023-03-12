namespace WindowsFormsAppPrincipal
{
    partial class FormAdicionarGrupo
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
            System.Windows.Forms.Label nomeGrupoLabel;
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.buttonAdionarGrupoSalvar = new System.Windows.Forms.Button();
            this.buttonAdionarGrupoCancelar = new System.Windows.Forms.Button();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(86, 89);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(85, 13);
            nomeGrupoLabel.TabIndex = 1;
            nomeGrupoLabel.Text = "Nome do Grupo:";
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(177, 86);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(165, 20);
            this.nomeGrupoTextBox.TabIndex = 2;
            // 
            // buttonAdionarGrupoSalvar
            // 
            this.buttonAdionarGrupoSalvar.Location = new System.Drawing.Point(133, 142);
            this.buttonAdionarGrupoSalvar.Name = "buttonAdionarGrupoSalvar";
            this.buttonAdionarGrupoSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdionarGrupoSalvar.TabIndex = 3;
            this.buttonAdionarGrupoSalvar.Text = "Salvar";
            this.buttonAdionarGrupoSalvar.UseVisualStyleBackColor = true;
            this.buttonAdionarGrupoSalvar.Click += new System.EventHandler(this.buttonAdionarGrupoSalvar_Click);
            // 
            // buttonAdionarGrupoCancelar
            // 
            this.buttonAdionarGrupoCancelar.Location = new System.Drawing.Point(267, 142);
            this.buttonAdionarGrupoCancelar.Name = "buttonAdionarGrupoCancelar";
            this.buttonAdionarGrupoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdionarGrupoCancelar.TabIndex = 4;
            this.buttonAdionarGrupoCancelar.Text = "Cancelar";
            this.buttonAdionarGrupoCancelar.UseVisualStyleBackColor = true;
            this.buttonAdionarGrupoCancelar.Click += new System.EventHandler(this.buttonAdionarGrupoCancelar_Click);
            // 
            // FormAdicionarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 206);
            this.Controls.Add(this.buttonAdionarGrupoCancelar);
            this.Controls.Add(this.buttonAdionarGrupoSalvar);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Name = "FormAdicionarGrupo";
            this.Text = "Gestão - Cadastrar Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button buttonAdionarGrupoSalvar;
        private System.Windows.Forms.Button buttonAdionarGrupoCancelar;
    }
}