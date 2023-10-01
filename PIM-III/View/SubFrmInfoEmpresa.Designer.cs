namespace PIM_III
{
    partial class SubFrmInfoEmpresa
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
            this.label17 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_emailAcesso = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_numeroEndereco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_qtdFuncionarios = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_porteEmpresa = new System.Windows.Forms.ComboBox();
            this.lbl_cnpj = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_razaoSocial = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_dataRegistro = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_atualizarCadastro = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_dataAbertura = new System.Windows.Forms.MaskedTextBox();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.btn_verSenha = new System.Windows.Forms.Button();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(536, 491);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 112;
            this.label17.Text = "SENHA";
            // 
            // txt_senha
            // 
            this.txt_senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_senha.Enabled = false;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_senha.ForeColor = System.Drawing.Color.Black;
            this.txt_senha.Location = new System.Drawing.Point(539, 507);
            this.txt_senha.Multiline = true;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(298, 31);
            this.txt_senha.TabIndex = 111;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(119, 491);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 13);
            this.label18.TabIndex = 110;
            this.label18.Text = "EMAIL DE ACESSO AO SISTEMA";
            // 
            // txt_emailAcesso
            // 
            this.txt_emailAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_emailAcesso.Enabled = false;
            this.txt_emailAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_emailAcesso.ForeColor = System.Drawing.Color.Black;
            this.txt_emailAcesso.Location = new System.Drawing.Point(122, 507);
            this.txt_emailAcesso.Multiline = true;
            this.txt_emailAcesso.Name = "txt_emailAcesso";
            this.txt_emailAcesso.Size = new System.Drawing.Size(384, 31);
            this.txt_emailAcesso.TabIndex = 109;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(687, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 108;
            this.label14.Text = "SIGLA ESTADO";
            // 
            // txt_estado
            // 
            this.txt_estado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_estado.Enabled = false;
            this.txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_estado.ForeColor = System.Drawing.Color.Black;
            this.txt_estado.Location = new System.Drawing.Point(690, 438);
            this.txt_estado.MaxLength = 2;
            this.txt_estado.Multiline = true;
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(82, 31);
            this.txt_estado.TabIndex = 107;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(266, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 106;
            this.label15.Text = "CIDADE";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_cidade.Enabled = false;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_cidade.ForeColor = System.Drawing.Color.Black;
            this.txt_cidade.Location = new System.Drawing.Point(269, 438);
            this.txt_cidade.Multiline = true;
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(381, 31);
            this.txt_cidade.TabIndex = 105;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(119, 422);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 104;
            this.label16.Text = "BAIRRO";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_bairro.Enabled = false;
            this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_bairro.ForeColor = System.Drawing.Color.Black;
            this.txt_bairro.Location = new System.Drawing.Point(122, 438);
            this.txt_bairro.Multiline = true;
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(127, 31);
            this.txt_bairro.TabIndex = 103;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(758, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 102;
            this.label11.Text = "NÚMERO";
            // 
            // txt_numeroEndereco
            // 
            this.txt_numeroEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_numeroEndereco.Enabled = false;
            this.txt_numeroEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_numeroEndereco.ForeColor = System.Drawing.Color.Black;
            this.txt_numeroEndereco.Location = new System.Drawing.Point(761, 367);
            this.txt_numeroEndereco.Multiline = true;
            this.txt_numeroEndereco.Name = "txt_numeroEndereco";
            this.txt_numeroEndereco.Size = new System.Drawing.Size(76, 31);
            this.txt_numeroEndereco.TabIndex = 101;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(266, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 100;
            this.label12.Text = "ENDEREÇO";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_endereco.Enabled = false;
            this.txt_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_endereco.ForeColor = System.Drawing.Color.Black;
            this.txt_endereco.Location = new System.Drawing.Point(269, 367);
            this.txt_endereco.Multiline = true;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(455, 31);
            this.txt_endereco.TabIndex = 99;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(119, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 98;
            this.label13.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(685, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "CELULAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(542, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 94;
            this.label9.Text = "TELEFONE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(119, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "EMAIL";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.Location = new System.Drawing.Point(122, 302);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(384, 31);
            this.txt_email.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(609, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "QTD DE FUNCIONARIOS";
            // 
            // txt_qtdFuncionarios
            // 
            this.txt_qtdFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_qtdFuncionarios.Enabled = false;
            this.txt_qtdFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_qtdFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.txt_qtdFuncionarios.Location = new System.Drawing.Point(612, 216);
            this.txt_qtdFuncionarios.Multiline = true;
            this.txt_qtdFuncionarios.Name = "txt_qtdFuncionarios";
            this.txt_qtdFuncionarios.Size = new System.Drawing.Size(129, 31);
            this.txt_qtdFuncionarios.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(438, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "PORTE";
            // 
            // cmb_porteEmpresa
            // 
            this.cmb_porteEmpresa.Enabled = false;
            this.cmb_porteEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.cmb_porteEmpresa.FormattingEnabled = true;
            this.cmb_porteEmpresa.Items.AddRange(new object[] {
            "ME",
            "EPP",
            "EMP",
            "EGP"});
            this.cmb_porteEmpresa.Location = new System.Drawing.Point(441, 215);
            this.cmb_porteEmpresa.Name = "cmb_porteEmpresa";
            this.cmb_porteEmpresa.Size = new System.Drawing.Size(121, 30);
            this.cmb_porteEmpresa.TabIndex = 87;
            // 
            // lbl_cnpj
            // 
            this.lbl_cnpj.AutoSize = true;
            this.lbl_cnpj.BackColor = System.Drawing.Color.White;
            this.lbl_cnpj.Location = new System.Drawing.Point(215, 200);
            this.lbl_cnpj.Name = "lbl_cnpj";
            this.lbl_cnpj.Size = new System.Drawing.Size(34, 13);
            this.lbl_cnpj.TabIndex = 86;
            this.lbl_cnpj.Text = "CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(914, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "DATA DE ABERTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "RAZÃO SOCIAL";
            // 
            // txt_razaoSocial
            // 
            this.txt_razaoSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_razaoSocial.Enabled = false;
            this.txt_razaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_razaoSocial.ForeColor = System.Drawing.Color.Black;
            this.txt_razaoSocial.Location = new System.Drawing.Point(218, 149);
            this.txt_razaoSocial.Multiline = true;
            this.txt_razaoSocial.Name = "txt_razaoSocial";
            this.txt_razaoSocial.Size = new System.Drawing.Size(619, 31);
            this.txt_razaoSocial.TabIndex = 77;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(71, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_cep);
            this.panel1.Controls.Add(this.btn_verSenha);
            this.panel1.Controls.Add(this.txt_celular);
            this.panel1.Controls.Add(this.txt_telefone);
            this.panel1.Controls.Add(this.txt_cnpj);
            this.panel1.Controls.Add(this.txt_dataAbertura);
            this.panel1.Controls.Add(this.lbl_dataRegistro);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.btn_atualizarCadastro);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_minimizar);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(39, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 529);
            this.panel1.TabIndex = 113;
            // 
            // lbl_dataRegistro
            // 
            this.lbl_dataRegistro.AutoSize = true;
            this.lbl_dataRegistro.BackColor = System.Drawing.Color.White;
            this.lbl_dataRegistro.Location = new System.Drawing.Point(219, 501);
            this.lbl_dataRegistro.Name = "lbl_dataRegistro";
            this.lbl_dataRegistro.Size = new System.Drawing.Size(65, 13);
            this.lbl_dataRegistro.TabIndex = 115;
            this.lbl_dataRegistro.Text = "__/__/____";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(20, 501);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 13);
            this.label19.TabIndex = 114;
            this.label19.Text = "DATA DE CADASTRAMENTO MAXXI:";
            // 
            // btn_atualizarCadastro
            // 
            this.btn_atualizarCadastro.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_atualizarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_atualizarCadastro.ForeColor = System.Drawing.Color.White;
            this.btn_atualizarCadastro.Location = new System.Drawing.Point(950, 473);
            this.btn_atualizarCadastro.Name = "btn_atualizarCadastro";
            this.btn_atualizarCadastro.Size = new System.Drawing.Size(109, 41);
            this.btn_atualizarCadastro.TabIndex = 76;
            this.btn_atualizarCadastro.Text = "LIBERAR EDIÇÃO";
            this.btn_atualizarCadastro.UseVisualStyleBackColor = false;
            this.btn_atualizarCadastro.Click += new System.EventHandler(this.btn_atualizarCadastro_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(989, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 22);
            this.button1.TabIndex = 74;
            this.button1.Text = "FECHAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // txt_dataAbertura
            // 
            this.txt_dataAbertura.Enabled = false;
            this.txt_dataAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_dataAbertura.Location = new System.Drawing.Point(878, 74);
            this.txt_dataAbertura.Mask = "00/00/0000";
            this.txt_dataAbertura.Name = "txt_dataAbertura";
            this.txt_dataAbertura.Size = new System.Drawing.Size(113, 30);
            this.txt_dataAbertura.TabIndex = 116;
            this.txt_dataAbertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_celular
            // 
            this.txt_celular.Enabled = false;
            this.txt_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_celular.Location = new System.Drawing.Point(688, 225);
            this.txt_celular.Mask = "(00) 00000-0000";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(158, 30);
            this.txt_celular.TabIndex = 121;
            this.txt_celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Enabled = false;
            this.txt_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_telefone.Location = new System.Drawing.Point(506, 226);
            this.txt_telefone.Mask = "(00) 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(151, 30);
            this.txt_telefone.TabIndex = 120;
            this.txt_telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Enabled = false;
            this.txt_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_cnpj.Location = new System.Drawing.Point(179, 138);
            this.txt_cnpj.Mask = "00,000,000,0000/00";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(189, 30);
            this.txt_cnpj.TabIndex = 119;
            this.txt_cnpj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_verSenha
            // 
            this.btn_verSenha.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_verSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btn_verSenha.ForeColor = System.Drawing.Color.White;
            this.btn_verSenha.Location = new System.Drawing.Point(804, 432);
            this.btn_verSenha.MaximumSize = new System.Drawing.Size(80, 31);
            this.btn_verSenha.MinimumSize = new System.Drawing.Size(80, 31);
            this.btn_verSenha.Name = "btn_verSenha";
            this.btn_verSenha.Size = new System.Drawing.Size(80, 31);
            this.btn_verSenha.TabIndex = 122;
            this.btn_verSenha.Text = "OCULTAR";
            this.btn_verSenha.UseVisualStyleBackColor = false;
            this.btn_verSenha.Click += new System.EventHandler(this.btn_verSenha_Click);
            // 
            // txt_cep
            // 
            this.txt_cep.Enabled = false;
            this.txt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_cep.Location = new System.Drawing.Point(83, 293);
            this.txt_cep.Mask = "00000-000";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(106, 30);
            this.txt_cep.TabIndex = 123;
            this.txt_cep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cep.Leave += new System.EventHandler(this.txt_cep_Leave);
            // 
            // SubFrmInfoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1154, 707);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txt_emailAcesso);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_numeroEndereco);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_qtdFuncionarios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_porteEmpresa);
            this.Controls.Add(this.lbl_cnpj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_razaoSocial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1154, 707);
            this.MinimumSize = new System.Drawing.Size(1154, 707);
            this.Name = "SubFrmInfoEmpresa";
            this.Text = "CADASTRO EMPRESA";
            this.Load += new System.EventHandler(this.SubFrmInfoEmpresa_Load);
            this.LocationChanged += new System.EventHandler(this.SubFrmCadastroEmpresa_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_emailAcesso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_numeroEndereco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_qtdFuncionarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_porteEmpresa;
        private System.Windows.Forms.Label lbl_cnpj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_razaoSocial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_atualizarCadastro;
        private System.Windows.Forms.Label lbl_dataRegistro;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txt_dataAbertura;
        private System.Windows.Forms.Button btn_verSenha;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.MaskedTextBox txt_cep;
    }
}