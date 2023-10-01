using Newtonsoft.Json;
using PIM_III.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PIM_III.Controlller
{
    public class RelatorioXempresaController
    {
        public async Task<List<RelatorioXempresaModel>> getRelatorio(int id)
        {
            HttpClient http = new HttpClient();
            var result = await http.GetAsync($"https://folhamaxxi-api.azurewebsites.net//api/RelatorioXempresa/{id}");
            var json  = await result.Content.ReadAsStringAsync();

            List<RelatorioXempresaModel> relatorio = JsonConvert.DeserializeObject<List<RelatorioXempresaModel>>(json);

            if (result.IsSuccessStatusCode)
            {
                return relatorio;
            }
            else { return null; }
        }
    }
}
