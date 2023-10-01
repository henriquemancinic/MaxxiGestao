using Newtonsoft.Json;
using PIM_III.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PIM_III.Controlller
{
    public class ColaboradorController
    {
        public async Task<List<ColaboradorModel>> getColaboradores()
        {
            HttpClient http = new HttpClient();
            var result = await http.GetAsync($"https://folhamaxxi-api.azurewebsites.net//api/Colaborador");
            var json  = await result.Content.ReadAsStringAsync();

            List<ColaboradorModel> colaboradores = JsonConvert.DeserializeObject<List<ColaboradorModel>>(json);

            if (result.IsSuccessStatusCode)
            {
                return colaboradores;
            }
            else { return null; }
        }
    }
}
