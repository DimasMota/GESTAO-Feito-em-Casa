namespace WindowsFormsAppPrincipal
{
    partial class FormAdicionarPermissao
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
            this.label1 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSalvarAdionarPermissao = new System.Windows.Forms.Button();
            this.buttonCancelarAdicionarPermissao = new System.Windows.Forms.Button();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(79, 134);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 2;
            descricaoLabel.Text = "Descricao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adionar Permissão";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.permissaoBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(143, 131);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(208, 20);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // buttonSalvarAdionarPermissao
            // 
            this.buttonSalvarAdionarPermissao.Location = new System.Drawing.Point(131, 200);
            this.buttonSalvarAdionarPermissao.Name = "buttonSalvarAdionarPermissao";
            this.buttonSalvarAdionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarAdionarPermissao.TabIndex = 6;
            this.buttonSalvarAdionarPermissao.Text = "Salvar";
            this.buttonSalvarAdionarPermissao.UseVisualStyleBackColor = true;
            this.buttonSalvarAdionarPermissao.Click += new System.EventHandler(this.buttonSalvarAdionarPermissao_Click);
            // 
            // buttonCancelarAdicionarPermissao
            // 
            this.buttonCancelarAdicionarPermissao.Location = new System.Drawing.Point(258, 200);
            this.buttonCancelarAdicionarPermissao.Name = "buttonCancelarAdicionarPermissao";
            this.buttonCancelarAdicionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarAdicionarPermissao.TabIndex = 7;
            this.buttonCancelarAdicionarPermissao.Text = "Cancelar";
            this.buttonCancelarAdicionarPermissao.UseVisualStyleBackColor = true;
            this.buttonCancelarAdicionarPermissao.Click += new System.EventHandler(this.buttonCancelarAdicionarPermissao_Click);
            // 
            // FormAdicionarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 371);
            this.Controls.Add(this.buttonCancelarAdicionarPermissao);
            this.Controls.Add(this.buttonSalvarAdionarPermissao);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormAdicionarPermissao";
            this.Text = "Gestão - Adicionar Permissão";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button buttonSalvarAdionarPermissao;
        private System.Windows.Forms.Button buttonCancelarAdicionarPermissao;
    }
}