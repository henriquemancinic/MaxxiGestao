using Newtonsoft.Json;
using PIM_III.Controlller;
using System.Text.Json.Serialization;

namespace PIM_III.Model
{
    public class ViaCepModel : ViaCepController
    {
        [JsonProperty("cep")]
        public string DsCep { get; set; }

        [JsonProperty("logradouro")]
        public string NmRua { get; set; }

        [JsonProperty("complemento")]
        public string DsComplemento { get; set; }

        [JsonProperty("bairro")]
        public string NmBairro { get; set; }

        [JsonProperty("localidade")]
        public string DsLocalidade { get; set; }

        [JsonProperty("uf")]
        public string SgEstado { get; set; }
    }
}
