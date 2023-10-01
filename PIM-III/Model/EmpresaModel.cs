using Newtonsoft.Json;
using PIM_III.Controlller;
using System;
using System.Text.Json.Serialization;

namespace PIM_III.Model
{
    public class EmpresaModel : EmpresaController
    {
        [JsonProperty("cd_empresa")]
        public int CdEmpresa { get; set; }

        [JsonProperty("cd_endereco")]
        public int CdEndereco { get; set; }

        [JsonProperty("cd_cnpj")]
        public string CdCnpj { get; set; }

        [JsonProperty("dt_cadastro")]
        public DateTime? DtCadastro { get; set; }

        [JsonProperty("ds_email")]
        public string DsEmail { get; set; }
        [JsonProperty("nr_qtd_funcionarios")]
        public string QtdFuncionarios { get; set; }

        [JsonProperty("ds_telefone")]
        public string DsTelefone { get; set; }

        [JsonProperty("ds_celular")]
        public string DsCelular { get; set; }

        [JsonProperty("dt_abertura")]
        public DateTime DtAbetura { get; set; }

        [JsonProperty("nm_razao_social")]
        public string NmRazaoSocial { get; set; }

        [JsonProperty("ds_porte")]
        public string DsPorte { get; set; }

        [JsonProperty("ds_email_sistema")]
        public string DsEmailSistema { get; set; }

        [JsonProperty("ds_senha")]
        public string DsSenha { get; set; }
    }
}
