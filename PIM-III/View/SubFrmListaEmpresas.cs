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
    public partial class SubFrmListaEmpresas : Form
    {
        private FrmMenuPrincipal frmMenuPrincipal;

        public SubFrmListaEmpresas(FrmMenuPrincipal menuPrincipal)
        {
            InitializeComponent();
            frmMenuPrincipal = menuPrincipal;
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

        private async void SubFrmListaEmpresas_Load(object sender, EventArgs e)
        {
            List<EmpresaModel> empresas = await new EmpresaModel().getEmpresas();

            foreach (var data in empresas)
            {
                int rowIndex = dtg_empresas.Rows.Add();
                DataGridViewRow row = dtg_empresas.Rows[rowIndex];

                row.Cells["cd_cnpj"].Value = data.CdCnpj;
                row.Cells["ds_email"].Value = data.DsEmail;
                row.Cells["ds_telefone"].Value = data.DsTelefone;
                row.Cells["nm_razao_social"].Value = data.NmRazaoSocial;
                row.Cells["ds_email_sistema"].Value = data.DsEmailSistema;
                row.Cells["btn_verMais"].Value = "+";
            }
        }
        //Arrumar a lógica para que form fique minimize o da lista e abra no mesmo local e tamanho
        private async void dtg_empresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifico se clicou no botão de info e indice >= 0
            if (dtg_empresas.Columns[e.ColumnIndex].Name == "btn_verMais" && e.RowIndex >= 0)
            {
                string cnpj = dtg_empresas.Rows[e.RowIndex].Cells["cd_cnpj"].Value.ToString();
                
                List<EmpresaModel> empresas = await new EmpresaModel().getEmpresas();
                foreach (var empresa in empresas)
                {
                    if (cnpj == empresa.CdCnpj)
                    {
                        //instanciando o form info e enviando o objeto empresa como parametro para popular no form informações da empresa.
                        SubFrmInfoEmpresa subFormInfoEmpresa = new SubFrmInfoEmpresa(empresa);
                        //coloca o form info como elemento filho do formulario principal
                        frmMenuPrincipal.ChamarSubFrm(subFormInfoEmpresa);
                        this.btn_minimizar_Click(sender, e);
                    }
                }
            }
        }
    }
}
