using Newtonsoft.Json;
using PIM_III.Controlller;
using System;
using System.Text.Json.Serialization;

namespace PIM_III.Model
{
    public class RelatorioXempresaModel : RelatorioXempresaController
    {
        [JsonProperty("cd_empresa")]
        public int cd_empresa { get; set; }
        [JsonProperty("nm_nome")]
        public string nm_nome { get; set; }
        [JsonProperty("vl_salario_bruto")]
        public decimal vl_salario_bruto { get; set; }
        [JsonProperty("vl_salario_liquido")]
        public decimal vl_salario_liquido { get; set; }
        [JsonProperty("ds_cargo")]
        public string ds_cargo { get; set; }
        [JsonProperty("nr_mes_referencia")]
        public int nr_mes_referencia { get; set; }
        [JsonProperty("nr_ano_referencia")]
        public int nr_ano_referencia { get; set; }
    }
}
