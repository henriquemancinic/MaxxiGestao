namespace PIM_III
{
    partial class SubFrmRelatorioEmpresa
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_empresas = new System.Windows.Forms.ComboBox();
            this.dtg_empresas = new System.Windows.Forms.DataGridView();
            this.nm_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_liquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_download = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_empresas);
            this.panel1.Controls.Add(this.dtg_empresas);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Location = new System.Drawing.Point(39, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 529);
            this.panel1.TabIndex = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "EMPRESA";
            // 
            // cmb_empresas
            // 
            this.cmb_empresas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmb_empresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_empresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_empresas.ForeColor = System.Drawing.Color.Black;
            this.cmb_empresas.FormattingEnabled = true;
            this.cmb_empresas.Location = new System.Drawing.Point(39, 74);
            this.cmb_empresas.Name = "cmb_empresas";
            this.cmb_empresas.Size = new System.Drawing.Size(462, 32);
            this.cmb_empresas.TabIndex = 77;
            this.cmb_empresas.SelectedIndexChanged += new System.EventHandler(this.cmb_empresas_SelectedIndexChanged);
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
            this.nm_funcionario,
            this.ds_cargo,
            this.vl_bruto,
            this.vl_liquido,
            this.dt_vencimento,
            this.btn_download});
            this.dtg_empresas.Location = new System.Drawing.Point(13, 145);
            this.dtg_empresas.Name = "dtg_empresas";
            this.dtg_empresas.ReadOnly = true;
            this.dtg_empresas.Size = new System.Drawing.Size(1046, 372);
            this.dtg_empresas.TabIndex = 76;
            this.dtg_empresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_empresas_CellContentClick);
            // 
            // nm_funcionario
            // 
            this.nm_funcionario.HeaderText = "FUNCIONÁRIO";
            this.nm_funcionario.Name = "nm_funcionario";
            this.nm_funcionario.ReadOnly = true;
            this.nm_funcionario.Width = 325;
            // 
            // ds_cargo
            // 
            this.ds_cargo.HeaderText = "FUNÇÃO";
            this.ds_cargo.Name = "ds_cargo";
            this.ds_cargo.ReadOnly = true;
            this.ds_cargo.Width = 180;
            // 
            // vl_bruto
            // 
            this.vl_bruto.HeaderText = "BRUTO";
            this.vl_bruto.Name = "vl_bruto";
            this.vl_bruto.ReadOnly = true;
            this.vl_bruto.Width = 150;
            // 
            // vl_liquido
            // 
            this.vl_liquido.HeaderText = "LÍQUIDO";
            this.vl_liquido.Name = "vl_liquido";
            this.vl_liquido.ReadOnly = true;
            this.vl_liquido.Width = 150;
            // 
            // dt_vencimento
            // 
            this.dt_vencimento.HeaderText = "VENCIMENTO";
            this.dt_vencimento.Name = "dt_vencimento";
            this.dt_vencimento.ReadOnly = true;
            // 
            // btn_download
            // 
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download.HeaderText = "DOWNLOAD";
            this.btn_download.MinimumWidth = 20;
            this.btn_download.Name = "btn_download";
            this.btn_download.ReadOnly = true;
            this.btn_download.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(324, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 28);
            this.label1.TabIndex = 114;
            this.label1.Text = "RELATÓRIO DE FOLHAS X EMPRESA";
            // 
            // SubFrmRelatorioEmpresa
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
            this.Name = "SubFrmRelatorioEmpresa";
            this.Text = "CADASTRO EMPRESA";
            this.Load += new System.EventHandler(this.SubFrmRelatorioEmpresa_Load);
            this.LocationChanged += new System.EventHandler(this.SubFrmCadastroEmpresa_LocationChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_empresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_funcionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_liquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_vencimento;
        private System.Windows.Forms.DataGridViewButtonColumn btn_download;
    }
}