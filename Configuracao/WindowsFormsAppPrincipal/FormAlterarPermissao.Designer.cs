namespace WindowsFormsAppPrincipal
{
    partial class FormAlterarPermissao
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label idLabel;
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSalvarAlteracaoPermissao = new System.Windows.Forms.Button();
            this.buttonCancelarAlteracaoPermissao = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(79, 209);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 1;
            descricaoLabel.Text = "Descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(143, 206);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(238, 20);
            this.descricaoTextBox.TabIndex = 2;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(118, 146);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(143, 143);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSalvarAlteracaoPermissao
            // 
            this.buttonSalvarAlteracaoPermissao.Location = new System.Drawing.Point(143, 277);
            this.buttonSalvarAlteracaoPermissao.Name = "buttonSalvarAlteracaoPermissao";
            this.buttonSalvarAlteracaoPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarAlteracaoPermissao.TabIndex = 6;
            this.buttonSalvarAlteracaoPermissao.Text = "Salvar";
            this.buttonSalvarAlteracaoPermissao.UseVisualStyleBackColor = true;
            this.buttonSalvarAlteracaoPermissao.Click += new System.EventHandler(this.buttonSalvarAlteracaoPermissao_Click);
            // 
            // buttonCancelarAlteracaoPermissao
            // 
            this.buttonCancelarAlteracaoPermissao.Location = new System.Drawing.Point(258, 277);
            this.buttonCancelarAlteracaoPermissao.Name = "buttonCancelarAlteracaoPermissao";
            this.buttonCancelarAlteracaoPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarAlteracaoPermissao.TabIndex = 7;
            this.buttonCancelarAlteracaoPermissao.Text = "Cancelar";
            this.buttonCancelarAlteracaoPermissao.UseVisualStyleBackColor = true;
            this.buttonCancelarAlteracaoPermissao.Click += new System.EventHandler(this.buttonCancelarAlteracaoPermissao_Click);
            // 
            // FormAlterarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 363);
            this.Controls.Add(this.buttonCancelarAlteracaoPermissao);
            this.Controls.Add(this.buttonSalvarAlteracaoPermissao);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Name = "FormAlterarPermissao";
            this.Text = "Gestão - Alterar Permissão";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSalvarAlteracaoPermissao;
        private System.Windows.Forms.Button buttonCancelarAlteracaoPermissao;
    }
}