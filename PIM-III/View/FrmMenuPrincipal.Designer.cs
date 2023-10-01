namespace PIM_III
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_redefinirSenha = new System.Windows.Forms.Button();
            this.btn_relatorioEmpresa = new System.Windows.Forms.Button();
            this.btn_listarEmpresas = new System.Windows.Forms.Button();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.btn_cadastrarEmpresa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btn_redefinirSenha);
            this.panel1.Controls.Add(this.btn_relatorioEmpresa);
            this.panel1.Controls.Add(this.btn_listarEmpresas);
            this.panel1.Controls.Add(this.pct_logo);
            this.panel1.Controls.Add(this.btn_cadastrarEmpresa);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 301);
            this.panel1.TabIndex = 0;
            // 
            // btn_redefinirSenha
            // 
            this.btn_redefinirSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_redefinirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_redefinirSenha.ForeColor = System.Drawing.Color.White;
            this.btn_redefinirSenha.Location = new System.Drawing.Point(0, 250);
            this.btn_redefinirSenha.Name = "btn_redefinirSenha";
            this.btn_redefinirSenha.Size = new System.Drawing.Size(231, 50);
            this.btn_redefinirSenha.TabIndex = 4;
            this.btn_redefinirSenha.Text = "REDEFINIR SENHA RH";
            this.btn_redefinirSenha.UseVisualStyleBackColor = false;
            this.btn_redefinirSenha.Click += new System.EventHandler(this.btn_redefinirSenha_Click);
            // 
            // btn_relatorioEmpresa
            // 
            this.btn_relatorioEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_relatorioEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorioEmpresa.ForeColor = System.Drawing.Color.White;
            this.btn_relatorioEmpresa.Location = new System.Drawing.Point(0, 200);
            this.btn_relatorioEmpresa.Name = "btn_relatorioEmpresa";
            this.btn_relatorioEmpresa.Size = new System.Drawing.Size(231, 50);
            this.btn_relatorioEmpresa.TabIndex = 3;
            this.btn_relatorioEmpresa.Text = "RELATÓRIO DE \nFOLHAS X EMPRESA";
            this.btn_relatorioEmpresa.UseVisualStyleBackColor = false;
            this.btn_relatorioEmpresa.Click += new System.EventHandler(this.btn_relatorioEmpresa_Click);
            // 
            // btn_listarEmpresas
            // 
            this.btn_listarEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_listarEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarEmpresas.ForeColor = System.Drawing.Color.White;
            this.btn_listarEmpresas.Location = new System.Drawing.Point(0, 150);
            this.btn_listarEmpresas.Name = "btn_listarEmpresas";
            this.btn_listarEmpresas.Size = new System.Drawing.Size(231, 50);
            this.btn_listarEmpresas.TabIndex = 2;
            this.btn_listarEmpresas.Text = "LISTAR EMPRESAS";
            this.btn_listarEmpresas.UseVisualStyleBackColor = false;
            this.btn_listarEmpresas.Click += new System.EventHandler(this.btn_listarEmpresas_Click);
            // 
            // pct_logo
            // 
            this.pct_logo.Image = ((System.Drawing.Image)(resources.GetObject("pct_logo.Image")));
            this.pct_logo.Location = new System.Drawing.Point(0, 0);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(231, 100);
            this.pct_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_logo.TabIndex = 1;
            this.pct_logo.TabStop = false;
            // 
            // btn_cadastrarEmpresa
            // 
            this.btn_cadastrarEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cadastrarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrarEmpresa.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrarEmpresa.Location = new System.Drawing.Point(0, 100);
            this.btn_cadastrarEmpresa.Name = "btn_cadastrarEmpresa";
            this.btn_cadastrarEmpresa.Size = new System.Drawing.Size(231, 50);
            this.btn_cadastrarEmpresa.TabIndex = 1;
            this.btn_cadastrarEmpresa.Text = "CADASTRAR EMPRESA";
            this.btn_cadastrarEmpresa.UseVisualStyleBackColor = false;
            this.btn_cadastrarEmpresa.Click += new System.EventHandler(this.btn_cadastrarEmpresa_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1400, 700);
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cadastrarEmpresa;
        private System.Windows.Forms.Button btn_redefinirSenha;
        private System.Windows.Forms.Button btn_relatorioEmpresa;
        private System.Windows.Forms.Button btn_listarEmpresas;
        private System.Windows.Forms.PictureBox pct_logo;
    }
}