namespace PIM_III
{
    partial class SubFrmRecuperarSenhas
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_emailAcesso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_empresas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_cadastrar);
            this.panel1.Controls.Add(this.txt_senha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_emailAcesso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_empresas);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Location = new System.Drawing.Point(39, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 529);
            this.panel1.TabIndex = 113;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Location = new System.Drawing.Point(751, 330);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(132, 41);
            this.btn_cadastrar.TabIndex = 113;
            this.btn_cadastrar.Text = "SALVAR SENHA";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_senha.Enabled = false;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_senha.ForeColor = System.Drawing.Color.Black;
            this.txt_senha.Location = new System.Drawing.Point(633, 251);
            this.txt_senha.Multiline = true;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(250, 31);
            this.txt_senha.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "SENHA";
            // 
            // txt_emailAcesso
            // 
            this.txt_emailAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_emailAcesso.Enabled = false;
            this.txt_emailAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_emailAcesso.ForeColor = System.Drawing.Color.Black;
            this.txt_emailAcesso.Location = new System.Drawing.Point(191, 251);
            this.txt_emailAcesso.Multiline = true;
            this.txt_emailAcesso.Name = "txt_emailAcesso";
            this.txt_emailAcesso.Size = new System.Drawing.Size(354, 31);
            this.txt_emailAcesso.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "E-MAIL DE ACESSO AO SISTEMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "EMPRESA";
            // 
            // cmb_empresas
            // 
            this.cmb_empresas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_empresas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_empresas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmb_empresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_empresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_empresas.ForeColor = System.Drawing.Color.Black;
            this.cmb_empresas.FormattingEnabled = true;
            this.cmb_empresas.Location = new System.Drawing.Point(191, 166);
            this.cmb_empresas.Name = "cmb_empresas";
            this.cmb_empresas.Size = new System.Drawing.Size(692, 32);
            this.cmb_empresas.TabIndex = 77;
            this.cmb_empresas.SelectedIndexChanged += new System.EventHandler(this.cmb_empresas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 114;
            this.label1.Text = "REDEFINIR SENHA RH";
            // 
            // SubFrmRecuperarSenhas
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
            this.Name = "SubFrmRecuperarSenhas";
            this.Text = "CADASTRO EMPRESA";
            this.Load += new System.EventHandler(this.SubFrmRecuperarSenhas_Load);
            this.LocationChanged += new System.EventHandler(this.SubFrmCadastroEmpresa_LocationChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_empresas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_emailAcesso;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}