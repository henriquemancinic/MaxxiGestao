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
    public partial class SubFrmCadastroEmpresa : Form
    {
        public SubFrmCadastroEmpresa()
        {
            InitializeComponent();


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

        private async void btn_cadastrar_Click(object sender, EventArgs e)
        {
            var empresaExiste = false;
            List<EmpresaModel> empresas = await new EmpresaModel().getEmpresas();
            foreach (var empresa in empresas)
            {
                if (txt_cnpj.Text.Trim() == empresa.CdCnpj || txt_razaoSocial.Text.Trim() == empresa.NmRazaoSocial)
                {
                    MessageBox.Show("Essa empresa já consta na nossa base, verifique a razão social e/ou cnpj!");
                    empresaExiste = true;
                }
                else empresaExiste = false;
            }
            if (!empresaExiste)
            {
                //verifico se TODOS os text box do form estão preenchidos
                if (Controls.OfType<TextBox>().All(txt => !string.IsNullOrWhiteSpace(txt.Text)))
                {
                    EnderecoModel endereco = new EnderecoModel();
                    endereco.NmRua = txt_endereco.Text;
                    endereco.NrRua = txt_numeroEndereco.Text;
                    endereco.NmBairro = txt_bairro.Text;
                    endereco.NmCidade = txt_cidade.Text;
                    endereco.NmEstado = txt_estado.Text;
                    endereco.DsCep = txt_cep.Text;
                    endereco = await endereco.addEndereco(endereco);
                    EmpresaModel empresa = new EmpresaModel();
                    DateTime data = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
                    empresa.DtCadastro = data;
                    empresa.CdEndereco = endereco.CdEndereco;
                    empresa.NmRazaoSocial = txt_razaoSocial.Text;
                    empresa.DsPorte = cmb_porteEmpresa.Text;
                    empresa.CdCnpj = txt_cnpj.Text;
                    empresa.DsEmail = txt_email.Text;
                    empresa.DsTelefone = txt_telefone.Text;
                    empresa.QtdFuncionarios = txt_qtdFuncionarios.Text;
                    empresa.DsCelular = txt_celular.Text;
                    empresa.DsEmailSistema = txt_emailAcesso.Text;
                    empresa.DsSenha = txt_senha.Text;

                    DateTime dataAbertura;
                    //Se for válido a data de abertura, ele amazena na dataAbertura através do "out dataAbertura"
                    if (DateTime.TryParseExact(txt_dataAbertura.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataAbertura))
                    {
                        empresa.DtAbetura = dataAbertura;
                        empresa = await empresa.addEmpresa(empresa);
                        if (empresa != null) { MessageBox.Show("Empresa cadastrada com sucesso!!"); }
                    }
                    else MessageBox.Show("DATA INCORRETA");
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
                txt_endereco.Enabled = true;
                txt_cidade.Enabled = true;
                txt_bairro.Enabled = true;
                txt_estado.Enabled = true;
            }
        }
    }
}
