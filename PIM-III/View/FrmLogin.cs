using PIM_III.Controlller;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btn_entrar_Click(object sender, EventArgs e)
        {
            List<EmpresaModel> empresas = await new EmpresaModel().getEmpresas(); 

            foreach (var user in empresas)
            {
                if (user.DsEmailSistema.Trim() == txt_login.Text.Trim())
                {
                    if (user.DsSenha.Trim() == txt_senha.Text.Trim())
                    {
                        FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                        frmMenu.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!");
                        break;
                    }
                }
                else if (user.Equals(empresas.Last())) MessageBox.Show("E-mail incorreto!!");
            }
        }
    }
}
