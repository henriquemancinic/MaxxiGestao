using Newtonsoft.Json;
using PIM_III.Controlller;
using System.Text.Json.Serialization;

namespace PIM_III.Model
{
    public class EnderecoModel : EnderecoController
    {
        [JsonProperty("cd_endereco")]
        public int CdEndereco { get; set; }

        [JsonProperty("ds_cep")]
        public string DsCep { get; set; }

        [JsonProperty("nm_rua")]
        public string NmRua { get; set; }

        [JsonProperty("nr_numero_rua")]
        public string NrRua { get; set; }

        [JsonProperty("nm_bairro")]
        public string NmBairro { get; set; }

        [JsonProperty("nm_cidade")]
        public string NmCidade { get; set; }

        [JsonProperty("nm_estado")]
        public string NmEstado { get; set; }
    }
}
