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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_cadastrarEmpresa_Click(object sender, EventArgs e)
        {
            SubFrmCadastroEmpresa subFormCadastroEmpresa = new SubFrmCadastroEmpresa();
            ChamarSubFrm(subFormCadastroEmpresa);
        }

        private void btn_listarEmpresas_Click(object sender, EventArgs e)
        {
            SubFrmListaEmpresas subFormListaEmpresas = new SubFrmListaEmpresas(this);
            ChamarSubFrm(subFormListaEmpresas);
        }

        private void btn_relatorioEmpresa_Click(object sender, EventArgs e)
        {
            SubFrmRelatorioEmpresa subRelatorioEmpresa = new SubFrmRelatorioEmpresa();
            ChamarSubFrm(subRelatorioEmpresa);
        }

        public void ChamarSubFrm(Form subForm)
        {
            subForm.TopLevel = false;
            subForm.Visible = true;
            Controls.Add(subForm);
            subForm.Location = new Point(
                    ClientSize.Width - subForm.Width,
                    ClientSize.Height - subForm.Height + 40
                );
        }

        private void btn_redefinirSenha_Click(object sender, EventArgs e)
        {
            SubFrmRecuperarSenhas subRecuperarSenhas = new SubFrmRecuperarSenhas();
            ChamarSubFrm(subRecuperarSenhas);
        }
    }
}