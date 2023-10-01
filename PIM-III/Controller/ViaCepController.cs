using Newtonsoft.Json;
using PIM_III.Model;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM_III.Controlller
{
    public class ViaCepController
    {
        HttpClient http = new HttpClient();

        public async Task<ViaCepModel> buscaCep(string cep)
        {
            ViaCepModel retornoViaCep = new ViaCepModel();

            var result = await http.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            var json = await result.Content.ReadAsStringAsync();
            if (result.IsSuccessStatusCode)
            {
                retornoViaCep = JsonConvert.DeserializeObject<ViaCepModel>(json);
                return retornoViaCep;
            }

            MessageBox.Show("OCORREU UM ERRO NA BUSCA DO CEP, INSIRA MANUALMENTE OU TENTE NOVAMENTE");
            return null;
        }
    }
}
