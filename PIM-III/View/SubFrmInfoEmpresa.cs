using PIM_III.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_III
{
    public partial class SubFrmInfoEmpresa : Form
    {
        private EmpresaModel _empresa;
        public SubFrmInfoEmpresa(EmpresaModel empresa)
        {
            InitializeComponent();
            _empresa = empresa;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        private void SubFrmCadastroEmpresa_LocationChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public async Task<EnderecoModel> retornaEndereco()
        {
            return await new EnderecoModel().getEndereco(_empresa.CdEndereco);
        }
        
        private async void SubFrmInfoEmpresa_Load(object sender, EventArgs e)
        {
            var endereco = await retornaEndereco();
            txt_razaoSocial.Text = _empresa.NmRazaoSocial;
            txt_dataAbertura.Text = _empresa.DtAbetura.ToString();
            txt_cnpj.Text = _empresa.CdCnpj;
            cmb_porteEmpresa.Text = _empresa.DsPorte;
            txt_qtdFuncionarios.Text = _empresa.QtdFuncionarios;
            txt_email.Text = _empresa.DsEmail;
            txt_telefone.Text = _empresa.DsTelefone;
            txt_celular.Text = _empresa.DsCelular;
            txt_emailAcesso.Text = _empresa.DsEmailSistema;
            txt_senha.Text = _empresa.DsSenha;
            lbl_dataRegistro.Text = _empresa.DtCadastro.ToString();

            txt_cep.Text = endereco.DsCep;
            txt_cidade.Text = endereco.NmCidade;
            txt_endereco.Text = endereco.NmRua;
            txt_numeroEndereco.Text = endereco.NrRua;
            txt_estado.Text = endereco.NmEstado;
            txt_bairro.Text = endereco.NmBairro;
        }

        private void btn_verSenha_Click(object sender, EventArgs e)
        {
            if (txt_senha.PasswordChar == '*')
            {
                txt_senha.PasswordChar = '\0';
                btn_verSenha.Text = "OCULTAR";
            }
            else
            {
                txt_senha.PasswordChar = '*';
                btn_verSenha.Text = "VER";
            }
        }

        private async void btn_atualizarCadastro_Click(object sender, EventArgs e)
        {
            if (btn_atualizarCadastro.Text == "LIBERAR EDIÇÃO")
            {
                //libera edição dos campos
                btn_atualizarCadastro.BackColor = Color.MediumSeaGreen;
                btn_atualizarCadastro.Text = "ATUALIZAR CADASTRO";
                txt_razaoSocial.Enabled = true;
                txt_dataAbertura.Enabled = true;
                txt_cnpj.Enabled = true;
                cmb_porteEmpresa.Enabled = true;
                txt_qtdFuncionarios.Enabled = true;
                txt_email.Enabled = true;
                txt_telefone.Enabled = true;
                txt_celular.Enabled = true;
                txt_emailAcesso.Enabled = true;
                txt_senha.Enabled = true;
                txt_cep.Enabled = true;
                txt_numeroEndereco.Enabled = true;
            }
            else
            {
                btn_atualizarCadastro.BackColor = Color.MediumPurple;
                btn_atualizarCadastro.Text = "LIBERAR EDIÇÃO";
                txt_razaoSocial.Enabled = false;
                txt_dataAbertura.Enabled = false;
                txt_cnpj.Enabled = false;
                cmb_porteEmpresa.Enabled = false;
                txt_qtdFuncionarios.Enabled = false;
                txt_email.Enabled = false;
                txt_telefone.Enabled = false;
                txt_celular.Enabled = false;
                txt_emailAcesso.Enabled = false;
                txt_senha.Enabled = false;
                txt_cep.Enabled = false;
                txt_numeroEndereco.Enabled = false;
                txt_endereco.Enabled = false;
                txt_cidade.Enabled = false;
                txt_bairro.Enabled = false;
                txt_estado.Enabled = false;

                List<EmpresaModel> empresas = await new EmpresaModel().getEmpresas();
                //verifico se TODOS os text box do form estão preenchidos
                if (Controls.OfType<TextBox>().All(txt => !string.IsNullOrWhiteSpace(txt.Text)))
                {
                    var endereco = await retornaEndereco();
                    //verifico se os campoos de endereço foram alterados, se algum foi adiciono o endereço
                    if (endereco.NmRua != txt_endereco.Text ||
                        endereco.NrRua != txt_numeroEndereco.Text ||
                        endereco.NmBairro != txt_bairro.Text ||
                        endereco.NmCidade != txt_cidade.Text ||
                        endereco.NmEstado != txt_estado.Text ||
                        endereco.DsCep != txt_cep.Text)
                    {
                        endereco.NmRua = txt_endereco.Text;
                        endereco.NrRua = txt_numeroEndereco.Text;
                        endereco.NmBairro = txt_bairro.Text;
                        endereco.NmCidade = txt_cidade.Text;
                        endereco.NmEstado = txt_estado.Text;
                        endereco.DsCep = txt_cep.Text;
                        endereco = await endereco.addEndereco(endereco);
                    }

                    
                    if (_empresa.CdEndereco != endereco.CdEndereco ||
                        _empresa.NmRazaoSocial != txt_razaoSocial.Text ||
                        _empresa.DsPorte != cmb_porteEmpresa.Text ||
                        _empresa.CdCnpj != txt_cnpj.Text ||
                        _empresa.DsEmail != txt_email.Text ||
                        _empresa.DsTelefone != txt_telefone.Text ||
                        _empresa.QtdFuncionarios != txt_qtdFuncionarios.Text ||
                        _empresa.DsCelular != txt_celular.Text ||
                        _empresa.DsEmailSistema != txt_emailAcesso.Text ||
                        _empresa.DsSenha != txt_senha.Text)
                    {
                        _empresa.CdEndereco = endereco.CdEndereco;
                        _empresa.NmRazaoSocial = txt_razaoSocial.Text;
                        _empresa.DsPorte = cmb_porteEmpresa.Text;
                        _empresa.CdCnpj = txt_cnpj.Text;
                        _empresa.DsEmail = txt_email.Text;
                        _empresa.DsTelefone = txt_telefone.Text;
                        _empresa.QtdFuncionarios = txt_qtdFuncionarios.Text;
                        _empresa.DsCelular = txt_celular.Text;
                        _empresa.DsEmailSistema = txt_emailAcesso.Text;
                        _empresa.DsSenha = txt_senha.Text;

                        DateTime dataAbertura;
                        //Se for válido a data de abertura, ele amazena na dataAbertura através do "out dataAbertura"
                        if (DateTime.TryParseExact(txt_dataAbertura.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataAbertura))
                        {
                            _empresa.DtAbetura = dataAbertura;
                            _empresa = await _empresa.editEmpresa(_empresa);
                            if (_empresa != null) { MessageBox.Show("Empresa alterada com sucesso!!"); }
                        }
                        else MessageBox.Show("DATA INCORRETA");
                    }
                }
                else { MessageBox.Show("Preencha todos os campos!!"); }
            }
            
        }

        private async void txt_cep_Leave(object sender, EventArgs e)
        {
            ViaCepModel viaCep = await new ViaCepModel().buscaCep(txt_cep.Text);
            if (viaCep.NmRua != null)
            {
                txt_endereco.Text = viaCep.NmRua;
                txt_cidade.Text = viaCep.DsLocalidade;
                txt_bairro.Text = viaCep.NmBairro;
                txt_estado.Text = viaCep.SgEstado;
            }
            else
            {
                //Caso ocorra erro ou não encontre no viacep, libera manual a digitação
                MessageBox.Show("Cep não localizado, tente novamente ou insira manualmente");
                txt_endereco.Text = "";
                txt_cidade.Text = "";
                txt_bairro.Text = "";
                txt_estado.Text = "";
                txt_endereco.Enabled = true;
                txt_cidade.Enabled = true;
                txt_bairro.Enabled = true;
                txt_estado.Enabled = true;
            }
        }
    }
}
