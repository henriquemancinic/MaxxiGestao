using PIM_III.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_III
{
    public partial class SubFrmRecuperarSenhas : Form
    {
        public SubFrmRecuperarSenhas()
        {
            InitializeComponent();
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        List<EmpresaModel> empresas = new List<EmpresaModel>();
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
        
        private async void SubFrmRecuperarSenhas_Load(object sender, EventArgs e)
        {
            empresas = await new EmpresaModel().getEmpresas();
            foreach (var empresa in empresas)
            {
                cmb_empresas.Items.Add(empresa.NmRazaoSocial);
            }
        }

        private async void btn_cadastrar_Click(object sender, EventArgs e)
        {
            foreach (var empresa in empresas)
            {
                if (empresa.DsEmailSistema == txt_emailAcesso.Text.Trim())
                {
                    empresa.DsSenha = txt_senha.Text.Trim();
                    var response = await empresa.editEmpresa(empresa);
                    if(response != null)
                        MessageBox.Show("Senha alterada com sucesso!!");
                    else MessageBox.Show("Ocorreu um erro ao alterar a senha!!");
                }
                else if (empresa.Equals(empresas.Last())) MessageBox.Show("Usuário não localizado!!");
            }
        }

        private void cmb_empresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var empresa in empresas)
            {
                if (cmb_empresas.Text == empresa.NmRazaoSocial)
                {
                    txt_emailAcesso.Text = empresa.DsEmailSistema;
                }
            }
            txt_senha.Enabled = true;
        }
    }
}
