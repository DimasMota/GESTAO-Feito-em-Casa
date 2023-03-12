namespace WindowsFormsAppPrincipal
{
    partial class FormExcluirUsuario
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
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label nomeUsuarioLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label ativoLabel;
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.buttonExcluirBuscarId = new System.Windows.Forms.Button();
            this.buttonCancelarExcluir = new System.Windows.Forms.Button();
            this.buttonExluir = new System.Windows.Forms.Button();
            this.nomeUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            senhaLabel = new System.Windows.Forms.Label();
            nomeUsuarioLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            ativoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(224, 259);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 37;
            senhaLabel.Text = "Senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.senhaTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.senhaTextBox.Location = new System.Drawing.Point(271, 256);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 38;
            // 
            // buttonExcluirBuscarId
            // 
            this.buttonExcluirBuscarId.Location = new System.Drawing.Point(388, 66);
            this.buttonExcluirBuscarId.Name = "buttonExcluirBuscarId";
            this.buttonExcluirBuscarId.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirBuscarId.TabIndex = 36;
            this.buttonExcluirBuscarId.Text = "Buscar";
            this.buttonExcluirBuscarId.UseVisualStyleBackColor = true;
            this.buttonExcluirBuscarId.Click += new System.EventHandler(this.buttonExcluirBuscarId_Click);
            // 
            // buttonCancelarExcluir
            // 
            this.buttonCancelarExcluir.Location = new System.Drawing.Point(373, 361);
            this.buttonCancelarExcluir.Name = "buttonCancelarExcluir";
            this.buttonCancelarExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarExcluir.TabIndex = 35;
            this.buttonCancelarExcluir.Text = "Cancelar";
            this.buttonCancelarExcluir.UseVisualStyleBackColor = true;
            this.buttonCancelarExcluir.Click += new System.EventHandler(this.buttonCancelarExcluir_Click);
            // 
            // buttonExluir
            // 
            this.buttonExluir.Location = new System.Drawing.Point(292, 361);
            this.buttonExluir.Name = "buttonExluir";
            this.buttonExluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExluir.TabIndex = 34;
            this.buttonExluir.Text = "Excluir";
            this.buttonExluir.UseVisualStyleBackColor = true;
            this.buttonExluir.Click += new System.EventHandler(this.buttonExluir_Click);
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new System.Drawing.Point(188, 207);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new System.Drawing.Size(77, 13);
            nomeUsuarioLabel.TabIndex = 32;
            nomeUsuarioLabel.Text = "Nome Usuario:";
            // 
            // nomeUsuarioTextBox
            // 
            this.nomeUsuarioTextBox.Location = new System.Drawing.Point(271, 204);
            this.nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            this.nomeUsuarioTextBox.Size = new System.Drawing.Size(357, 20);
            this.nomeUsuarioTextBox.TabIndex = 33;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(227, 129);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 30;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(271, 126);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(357, 20);
            this.nomeTextBox.TabIndex = 31;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(246, 71);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 28;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(271, 68);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 29;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(230, 233);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(271, 230);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(357, 20);
            this.emailTextBox.TabIndex = 27;
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(173, 155);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 24;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // dataNascimentoTextBox
            // 
            this.dataNascimentoTextBox.Location = new System.Drawing.Point(271, 152);
            this.dataNascimentoTextBox.Name = "dataNascimentoTextBox";
            this.dataNascimentoTextBox.Size = new System.Drawing.Size(357, 20);
            this.dataNascimentoTextBox.TabIndex = 25;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(239, 181);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(26, 13);
            cpfLabel.TabIndex = 22;
            cpfLabel.Text = "Cpf:";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(271, 178);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(357, 20);
            this.cpfTextBox.TabIndex = 23;
            // 
            // ativoLabel
            // 
            ativoLabel.AutoSize = true;
            ativoLabel.Location = new System.Drawing.Point(231, 296);
            ativoLabel.Name = "ativoLabel";
            ativoLabel.Size = new System.Drawing.Size(34, 13);
            ativoLabel.TabIndex = 20;
            ativoLabel.Text = "Ativo:";
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.Location = new System.Drawing.Point(271, 291);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.ativoCheckBox.TabIndex = 21;
            this.ativoCheckBox.Text = "SIM";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormExcluirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.buttonExcluirBuscarId);
            this.Controls.Add(this.buttonCancelarExcluir);
            this.Controls.Add(this.buttonExluir);
            this.Controls.Add(nomeUsuarioLabel);
            this.Controls.Add(this.nomeUsuarioTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(ativoLabel);
            this.Controls.Add(this.ativoCheckBox);
            this.Name = "FormExcluirUsuario";
            this.Text = "Gestão - Excluir Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button buttonExcluirBuscarId;
        private System.Windows.Forms.Button buttonCancelarExcluir;
        private System.Windows.Forms.Button buttonExluir;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox dataNascimentoTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
    }
}