using PIM_III.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PIM_III
{
    public partial class SubFrmRelatorioEmpresa : Form
    {
        public SubFrmRelatorioEmpresa()
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
        List<EmpresaModel> empresas = new List<EmpresaModel>();
        private void SubFrmCadastroEmpresa_LocationChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private async void cmb_empresas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtg_empresas.Rows.Clear();
            foreach (var data in empresas)
            {
                if(cmb_empresas.SelectedItem.ToString() == data.NmRazaoSocial)
                {
                    List<RelatorioXempresaModel> relatorios = await new RelatorioXempresaModel().getRelatorio(data.CdEmpresa);
                    foreach (var relatorio in relatorios)
                    {
                        int rowIndex = dtg_empresas.Rows.Add();
                        DataGridViewRow row = dtg_empresas.Rows[rowIndex];
                       
                        row.Cells["nm_funcionario"].Value = relatorio.nm_nome;
                        row.Cells["ds_cargo"].Value = relatorio.ds_cargo;
                        row.Cells["vl_bruto"].Value = relatorio.vl_salario_bruto;
                        row.Cells["vl_liquido"].Value = relatorio.vl_salario_liquido;
                        row.Cells["dt_vencimento"].Value = relatorio.nr_mes_referencia+"/"+relatorio.nr_ano_referencia;
                        row.Cells["btn_download"].Value = "+";
                    }
                }
            }
        }
        
        private async void SubFrmRelatorioEmpresa_Load(object sender, EventArgs e)
        {
            empresas = await new EmpresaModel().getEmpresas();
            foreach (var data in empresas)
            {
                cmb_empresas.Items.Add(data.NmRazaoSocial);
            }
        }

        private void dtg_empresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_empresas.Columns[e.ColumnIndex].Name == "btn_download" && e.RowIndex >= 0)
            {
                string nmFuncionario = dtg_empresas.Rows[e.RowIndex].Cells["nm_funcionario"].Value.ToString();
                string dsCargo = dtg_empresas.Rows[e.RowIndex].Cells["ds_cargo"].Value.ToString();
                string vlBruto = dtg_empresas.Rows[e.RowIndex].Cells["vl_bruto"].Value.ToString();
                string vlLiquido = dtg_empresas.Rows[e.RowIndex].Cells["vl_liquido"].Value.ToString();
                string dtVencimento = dtg_empresas.Rows[e.RowIndex].Cells["dt_vencimento"].Value.ToString();


                try
                {
                    //pegando a raiz da debug, onde fica o executável
                    string diretorioAtual = Environment.CurrentDirectory;
                    //Saindo da pasta debug e bin, para entrar na pasta docs
                    diretorioAtual = Path.Combine(diretorioAtual,"../../docs/");
                    diretorioAtual = Path.GetFullPath(diretorioAtual);

                    //se não existir, cria
                    if (!Directory.Exists(diretorioAtual))
                    {
                        Directory.CreateDirectory(diretorioAtual);
                    }

                    //Enviando o diretório + nome do arquivo para gravar
                    StreamWriter sw = new StreamWriter(diretorioAtual + nmFuncionario + "_" + dtVencimento.Replace("/", "-") + ".txt");
                    //Gravando folha no txt
                    sw.WriteLine("----------RESUMO FOLHA DE PAGAMENTO-----------");
                    sw.WriteLine("Empresa: " + cmb_empresas.Text);
                    sw.WriteLine("Nome: "+nmFuncionario+" - "+dsCargo);
                    sw.WriteLine("Salário Bruto: " + vlBruto);
                    sw.WriteLine("-Desconto: " + (Double.Parse(vlBruto) - Double.Parse(vlLiquido)));
                    sw.WriteLine("Salário Líquido: " + vlLiquido);
                    DateTime data = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
                    sw.WriteLine("--------GERADO EM " + data+ "---------");
                    sw.Close();
                    MessageBox.Show("O arquivo foi gerado com sucesso e se encontra na pasta 'docs' do sistema.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }
        }
    }
}
