using Newtonsoft.Json;
using PIM_III.Controlller;
using System.Text.Json.Serialization;

namespace PIM_III.Model
{
    public class ColaboradorModel : ColaboradorController
    {
        [JsonProperty("cd_colaborador")]
        public int CdColaborador { get; set; }

        [JsonProperty("cd_endereco")]
        public int CdEndereco { get; set; }

        [JsonProperty("cd_empresa")]
        public int CdEmpresa { get; set; }

        [JsonProperty("nm_nome")]
        public string NmNome { get; set; }

        [JsonProperty("cd_cpf")]
        public string CdCpf { get; set; }

        [JsonProperty("cd_rg")]
        public string CdRg { get; set; }

        [JsonProperty("ds_email")]
        public string DsEmail { get; set; }

        [JsonProperty("ds_telefone")]
        public string DsTelefone { get; set; }
    }
}
