namespace WindowsFormsAppPrincipal
{
    partial class FormExcluirPermissao
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
            System.Windows.Forms.Label descricaoLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.buttonBuscarPermissaoExcluir = new System.Windows.Forms.Button();
            this.buttonExcluirPermissao = new System.Windows.Forms.Button();
            this.buttonCancelarExclusaoPermissao = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(141, 126);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(166, 123);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(102, 188);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 3;
            descricaoLabel.Text = "Descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(166, 185);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(246, 20);
            this.descricaoTextBox.TabIndex = 4;
            // 
            // buttonBuscarPermissaoExcluir
            // 
            this.buttonBuscarPermissaoExcluir.Location = new System.Drawing.Point(272, 121);
            this.buttonBuscarPermissaoExcluir.Name = "buttonBuscarPermissaoExcluir";
            this.buttonBuscarPermissaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPermissaoExcluir.TabIndex = 5;
            this.buttonBuscarPermissaoExcluir.Text = "Buscar";
            this.buttonBuscarPermissaoExcluir.UseVisualStyleBackColor = true;
            this.buttonBuscarPermissaoExcluir.Click += new System.EventHandler(this.buttonBuscarPermissaoExcluir_Click);
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(166, 275);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirPermissao.TabIndex = 6;
            this.buttonExcluirPermissao.Text = "Excluir";
            this.buttonExcluirPermissao.UseVisualStyleBackColor = true;
            this.buttonExcluirPermissao.Click += new System.EventHandler(this.buttonExcluirPermissao_Click);
            // 
            // buttonCancelarExclusaoPermissao
            // 
            this.buttonCancelarExclusaoPermissao.Location = new System.Drawing.Point(297, 275);
            this.buttonCancelarExclusaoPermissao.Name = "buttonCancelarExclusaoPermissao";
            this.buttonCancelarExclusaoPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarExclusaoPermissao.TabIndex = 7;
            this.buttonCancelarExclusaoPermissao.Text = "Cancelar";
            this.buttonCancelarExclusaoPermissao.UseVisualStyleBackColor = true;
            // 
            // FormExcluirPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 403);
            this.Controls.Add(this.buttonCancelarExclusaoPermissao);
            this.Controls.Add(this.buttonExcluirPermissao);
            this.Controls.Add(this.buttonBuscarPermissaoExcluir);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Name = "FormExcluirPermissao";
            this.Text = "Gestão - Excluir Permissão";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button buttonBuscarPermissaoExcluir;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.Button buttonCancelarExclusaoPermissao;
    }
}