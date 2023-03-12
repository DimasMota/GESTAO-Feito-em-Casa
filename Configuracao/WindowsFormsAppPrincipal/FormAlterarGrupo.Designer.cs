namespace WindowsFormsAppPrincipal
{
    partial class FormAlterarGrupo
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAlterarGrupoBuscar = new System.Windows.Forms.Button();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.buttonAlterarGrupoSalvar = new System.Windows.Forms.Button();
            this.buttonAlterarGrupoCancelar = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Grupo";
            // 
            // buttonAlterarGrupoBuscar
            // 
            this.buttonAlterarGrupoBuscar.Location = new System.Drawing.Point(232, 105);
            this.buttonAlterarGrupoBuscar.Name = "buttonAlterarGrupoBuscar";
            this.buttonAlterarGrupoBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarGrupoBuscar.TabIndex = 1;
            this.buttonAlterarGrupoBuscar.Text = "Buscar";
            this.buttonAlterarGrupoBuscar.UseVisualStyleBackColor = true;
            this.buttonAlterarGrupoBuscar.Click += new System.EventHandler(this.buttonAlterarGrupoBuscar_Click);
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(101, 110);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 4;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(126, 107);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new System.Drawing.Point(32, 159);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(88, 13);
            nomeGrupoLabel.TabIndex = 6;
            nomeGrupoLabel.Text = "Nome do  Grupo:";
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(126, 156);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(252, 20);
            this.nomeGrupoTextBox.TabIndex = 7;
            // 
            // buttonAlterarGrupoSalvar
            // 
            this.buttonAlterarGrupoSalvar.Location = new System.Drawing.Point(137, 225);
            this.buttonAlterarGrupoSalvar.Name = "buttonAlterarGrupoSalvar";
            this.buttonAlterarGrupoSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarGrupoSalvar.TabIndex = 8;
            this.buttonAlterarGrupoSalvar.Text = "Salvar";
            this.buttonAlterarGrupoSalvar.UseVisualStyleBackColor = true;
            this.buttonAlterarGrupoSalvar.Click += new System.EventHandler(this.buttonAlterarGrupoSalvar_Click);
            // 
            // buttonAlterarGrupoCancelar
            // 
            this.buttonAlterarGrupoCancelar.Location = new System.Drawing.Point(255, 225);
            this.buttonAlterarGrupoCancelar.Name = "buttonAlterarGrupoCancelar";
            this.buttonAlterarGrupoCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarGrupoCancelar.TabIndex = 9;
            this.buttonAlterarGrupoCancelar.Text = "Cancelar";
            this.buttonAlterarGrupoCancelar.UseVisualStyleBackColor = true;
            this.buttonAlterarGrupoCancelar.Click += new System.EventHandler(this.buttonAlterarGrupoCancelar_Click);
            // 
            // FormAlterarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 302);
            this.Controls.Add(this.buttonAlterarGrupoCancelar);
            this.Controls.Add(this.buttonAlterarGrupoSalvar);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.buttonAlterarGrupoBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FormAlterarGrupo";
            this.Text = "Gestão - Alterar Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAlterarGrupoBuscar;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button buttonAlterarGrupoSalvar;
        private System.Windows.Forms.Button buttonAlterarGrupoCancelar;
    }
}