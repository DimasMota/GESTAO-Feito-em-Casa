namespace WindowsFormsAppPrincipal
{
    partial class FormBuscarPermissao
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
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonBuscarPermissao = new System.Windows.Forms.Button();
            this.buttonExcluirPermissao = new System.Windows.Forms.Button();
            this.buttonAdicionarPermissao = new System.Windows.Forms.Button();
            this.buttonAlterarPermissao = new System.Windows.Forms.Button();
            this.buttonPermissaoAdicionarGrupo = new System.Windows.Forms.Button();
            this.buttonPermissaoExcluirGrupo = new System.Windows.Forms.Button();
            this.textBoxPermissaoPesquisar = new System.Windows.Forms.TextBox();
            this.radioButtonBuscarTodos = new System.Windows.Forms.RadioButton();
            this.radioButtonBuscarPor_Id = new System.Windows.Forms.RadioButton();
            this.radioButtonBuscarPorNome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(12, 163);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.Size = new System.Drawing.Size(493, 323);
            this.permissaoDataGridView.TabIndex = 1;
            // 
            // grupoUsuariosDataGridView
            // 
            this.grupoUsuariosDataGridView.AllowUserToAddRows = false;
            this.grupoUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuariosDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuariosDataGridView.AutoGenerateColumns = false;
            this.grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(511, 163);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(311, 323);
            this.grupoUsuariosDataGridView.TabIndex = 2;
            // 
            // buttonBuscarPermissao
            // 
            this.buttonBuscarPermissao.Location = new System.Drawing.Point(430, 96);
            this.buttonBuscarPermissao.Name = "buttonBuscarPermissao";
            this.buttonBuscarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPermissao.TabIndex = 3;
            this.buttonBuscarPermissao.Text = "Buscar";
            this.buttonBuscarPermissao.UseVisualStyleBackColor = true;
            this.buttonBuscarPermissao.Click += new System.EventHandler(this.buttonBuscarPermissao_Click);
            // 
            // buttonExcluirPermissao
            // 
            this.buttonExcluirPermissao.Location = new System.Drawing.Point(231, 134);
            this.buttonExcluirPermissao.Name = "buttonExcluirPermissao";
            this.buttonExcluirPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirPermissao.TabIndex = 4;
            this.buttonExcluirPermissao.Text = "Excluir";
            this.buttonExcluirPermissao.UseVisualStyleBackColor = true;
            this.buttonExcluirPermissao.Click += new System.EventHandler(this.buttonExcluirPermissao_Click);
            // 
            // buttonAdicionarPermissao
            // 
            this.buttonAdicionarPermissao.Location = new System.Drawing.Point(120, 134);
            this.buttonAdicionarPermissao.Name = "buttonAdicionarPermissao";
            this.buttonAdicionarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionarPermissao.TabIndex = 5;
            this.buttonAdicionarPermissao.Text = "Adicionar";
            this.buttonAdicionarPermissao.UseVisualStyleBackColor = true;
            this.buttonAdicionarPermissao.Click += new System.EventHandler(this.buttonAdicionarPermissao_Click);
            // 
            // buttonAlterarPermissao
            // 
            this.buttonAlterarPermissao.Location = new System.Drawing.Point(12, 134);
            this.buttonAlterarPermissao.Name = "buttonAlterarPermissao";
            this.buttonAlterarPermissao.Size = new System.Drawing.Size(75, 23);
            this.buttonAlterarPermissao.TabIndex = 6;
            this.buttonAlterarPermissao.Text = "Alterar";
            this.buttonAlterarPermissao.UseVisualStyleBackColor = true;
            this.buttonAlterarPermissao.Click += new System.EventHandler(this.buttonAlterarPermissao_Click);
            // 
            // buttonPermissaoAdicionarGrupo
            // 
            this.buttonPermissaoAdicionarGrupo.Location = new System.Drawing.Point(666, 134);
            this.buttonPermissaoAdicionarGrupo.Name = "buttonPermissaoAdicionarGrupo";
            this.buttonPermissaoAdicionarGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonPermissaoAdicionarGrupo.TabIndex = 7;
            this.buttonPermissaoAdicionarGrupo.Text = "Adicionar";
            this.buttonPermissaoAdicionarGrupo.UseVisualStyleBackColor = true;
            // 
            // buttonPermissaoExcluirGrupo
            // 
            this.buttonPermissaoExcluirGrupo.Location = new System.Drawing.Point(747, 134);
            this.buttonPermissaoExcluirGrupo.Name = "buttonPermissaoExcluirGrupo";
            this.buttonPermissaoExcluirGrupo.Size = new System.Drawing.Size(75, 23);
            this.buttonPermissaoExcluirGrupo.TabIndex = 8;
            this.buttonPermissaoExcluirGrupo.Text = "Excluir";
            this.buttonPermissaoExcluirGrupo.UseVisualStyleBackColor = true;
            // 
            // textBoxPermissaoPesquisar
            // 
            this.textBoxPermissaoPesquisar.Location = new System.Drawing.Point(12, 96);
            this.textBoxPermissaoPesquisar.Name = "textBoxPermissaoPesquisar";
            this.textBoxPermissaoPesquisar.Size = new System.Drawing.Size(395, 20);
            this.textBoxPermissaoPesquisar.TabIndex = 9;
            // 
            // radioButtonBuscarTodos
            // 
            this.radioButtonBuscarTodos.AutoSize = true;
            this.radioButtonBuscarTodos.Location = new System.Drawing.Point(12, 73);
            this.radioButtonBuscarTodos.Name = "radioButtonBuscarTodos";
            this.radioButtonBuscarTodos.Size = new System.Drawing.Size(91, 17);
            this.radioButtonBuscarTodos.TabIndex = 10;
            this.radioButtonBuscarTodos.TabStop = true;
            this.radioButtonBuscarTodos.Text = "Buscar Todos";
            this.radioButtonBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuscarPor_Id
            // 
            this.radioButtonBuscarPor_Id.AutoSize = true;
            this.radioButtonBuscarPor_Id.Location = new System.Drawing.Point(292, 73);
            this.radioButtonBuscarPor_Id.Name = "radioButtonBuscarPor_Id";
            this.radioButtonBuscarPor_Id.Size = new System.Drawing.Size(88, 17);
            this.radioButtonBuscarPor_Id.TabIndex = 11;
            this.radioButtonBuscarPor_Id.TabStop = true;
            this.radioButtonBuscarPor_Id.Text = "Buscar por Id";
            this.radioButtonBuscarPor_Id.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuscarPorNome
            // 
            this.radioButtonBuscarPorNome.AutoSize = true;
            this.radioButtonBuscarPorNome.Location = new System.Drawing.Point(146, 73);
            this.radioButtonBuscarPorNome.Name = "radioButtonBuscarPorNome";
            this.radioButtonBuscarPorNome.Size = new System.Drawing.Size(105, 17);
            this.radioButtonBuscarPorNome.TabIndex = 12;
            this.radioButtonBuscarPorNome.TabStop = true;
            this.radioButtonBuscarPorNome.Text = "Buscar por nome";
            this.radioButtonBuscarPorNome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Permissão - Buscar";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn3.HeaderText = "NomeGrupo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // grupoUsuariosBindingSource
            // 
            this.grupoUsuariosBindingSource.DataMember = "GrupoUsuarios";
            this.grupoUsuariosBindingSource.DataSource = this.permissaoBindingSource;
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FormBuscarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 498);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonBuscarPorNome);
            this.Controls.Add(this.radioButtonBuscarPor_Id);
            this.Controls.Add(this.radioButtonBuscarTodos);
            this.Controls.Add(this.textBoxPermissaoPesquisar);
            this.Controls.Add(this.buttonPermissaoExcluirGrupo);
            this.Controls.Add(this.buttonPermissaoAdicionarGrupo);
            this.Controls.Add(this.buttonAlterarPermissao);
            this.Controls.Add(this.buttonAdicionarPermissao);
            this.Controls.Add(this.buttonExcluirPermissao);
            this.Controls.Add(this.buttonBuscarPermissao);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.Controls.Add(this.permissaoDataGridView);
            this.Name = "FormBuscarPermissao";
            this.Text = "Gestão - Buscar Permissão";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button buttonBuscarPermissao;
        private System.Windows.Forms.Button buttonExcluirPermissao;
        private System.Windows.Forms.Button buttonAdicionarPermissao;
        private System.Windows.Forms.Button buttonAlterarPermissao;
        private System.Windows.Forms.Button buttonPermissaoAdicionarGrupo;
        private System.Windows.Forms.Button buttonPermissaoExcluirGrupo;
        private System.Windows.Forms.TextBox textBoxPermissaoPesquisar;
        private System.Windows.Forms.RadioButton radioButtonBuscarTodos;
        private System.Windows.Forms.RadioButton radioButtonBuscarPor_Id;
        private System.Windows.Forms.RadioButton radioButtonBuscarPorNome;
        private System.Windows.Forms.Label label1;
    }
}