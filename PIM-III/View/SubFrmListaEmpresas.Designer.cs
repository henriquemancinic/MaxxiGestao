namespace PIM_III
{
    partial class SubFrmListaEmpresas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg_empresas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nm_razao_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd_cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr_qtd_funcionarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_email_sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_verMais = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_empresas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Tomato;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(989, 7);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(70, 22);
            this.btn_fechar.TabIndex = 74;
            this.btn_fechar.Text = "FECHAR";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Teal;
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_minimizar.ForeColor = System.Drawing.Color.White;
            this.btn_minimizar.Location = new System.Drawing.Point(959, 7);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(24, 22);
            this.btn_minimizar.TabIndex = 75;
            this.btn_minimizar.Text = "-";
            this.btn_minimizar.UseVisualStyleBackColor = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtg_empresas);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Location = new System.Drawing.Point(39, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 529);
            this.panel1.TabIndex = 113;
            // 
            // dtg_empresas
            // 
            this.dtg_empresas.AllowUserToAddRows = false;
            this.dtg_empresas.AllowUserToOrderColumns = true;
            this.dtg_empresas.BackgroundColor = System.Drawing.Color.White;
            this.dtg_empresas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_empresas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_empresas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_empresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nm_razao_social,
            this.cd_cnpj,
            this.nr_qtd_funcionarios,
            this.ds_telefone,
            this.ds_celular,
            this.ds_email,
            this.ds_email_sistema,
            this.btn_verMais});
            this.dtg_empresas.Location = new System.Drawing.Point(11, 35);
            this.dtg_empresas.Name = "dtg_empresas";
            this.dtg_empresas.ReadOnly = true;
            this.dtg_empresas.Size = new System.Drawing.Size(1048, 482);
            this.dtg_empresas.TabIndex = 76;
            this.dtg_empresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_empresas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(489, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 114;
            this.label1.Text = "EMPRESAS";
            // 
            // nm_razao_social
            // 
            this.nm_razao_social.HeaderText = "EMPRESA";
            this.nm_razao_social.Name = "nm_razao_social";
            this.nm_razao_social.ReadOnly = true;
            this.nm_razao_social.Width = 160;
            // 
            // cd_cnpj
            // 
            this.cd_cnpj.HeaderText = "CNPJ";
            this.cd_cnpj.Name = "cd_cnpj";
            this.cd_cnpj.ReadOnly = true;
            this.cd_cnpj.Width = 140;
            // 
            // nr_qtd_funcionarios
            // 
            this.nr_qtd_funcionarios.HeaderText = "QTD FUNCIONÁRIOS";
            this.nr_qtd_funcionarios.Name = "nr_qtd_funcionarios";
            this.nr_qtd_funcionarios.ReadOnly = true;
            // 
            // ds_telefone
            // 
            this.ds_telefone.HeaderText = "TELEFONE";
            this.ds_telefone.Name = "ds_telefone";
            this.ds_telefone.ReadOnly = true;
            this.ds_telefone.Width = 105;
            // 
            // ds_celular
            // 
            this.ds_celular.HeaderText = "CELULAR";
            this.ds_celular.Name = "ds_celular";
            this.ds_celular.ReadOnly = true;
            this.ds_celular.Width = 115;
            // 
            // ds_email
            // 
            this.ds_email.HeaderText = "EMAIL";
            this.ds_email.Name = "ds_email";
            this.ds_email.ReadOnly = true;
            this.ds_email.Width = 205;
            // 
            // ds_email_sistema
            // 
            this.ds_email_sistema.HeaderText = "ACESSO";
            this.ds_email_sistema.Name = "ds_email_sistema";
            this.ds_email_sistema.ReadOnly = true;
            this.ds_email_sistema.Width = 205;
            // 
            // btn_verMais
            // 
            this.btn_verMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verMais.HeaderText = "INFO";
            this.btn_verMais.MinimumWidth = 20;
            this.btn_verMais.Name = "btn_verMais";
            this.btn_verMais.ReadOnly = true;
            this.btn_verMais.Text = "";
            this.btn_verMais.Width = 50;
            // 
            // SubFrmListaEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1154, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1154, 707);
            this.MinimumSize = new System.Drawing.Size(1154, 707);
            this.Name = "SubFrmListaEmpresas";
            this.Text = "CADASTRO EMPRESA";
            this.Load += new System.EventHandler(this.SubFrmListaEmpresas_Load);
            this.LocationChanged += new System.EventHandler(this.SubFrmCadastroEmpresa_LocationChanged);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_empresas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg_empresas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_razao_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_qtd_funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_email_sistema;
        private System.Windows.Forms.DataGridViewButtonColumn btn_verMais;
    }
}