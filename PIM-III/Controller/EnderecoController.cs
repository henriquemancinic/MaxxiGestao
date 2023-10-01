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
    public class EnderecoController
    {
        HttpClient http = new HttpClient();

        public async Task<EnderecoModel> getEndereco(int id)
        {
            var result = await http.GetAsync($"https://folhamaxxi-api.azurewebsites.net//api/Endereco/{id}");
            var json = await result.Content.ReadAsStringAsync();

            EnderecoModel endereco = JsonConvert.DeserializeObject<EnderecoModel>(json);

            if (result.IsSuccessStatusCode)
            {
                return endereco;
            }
            return null;
        }

        public async Task<EnderecoModel> addEndereco(EnderecoModel endereco)
        {
            //setando ele zerado para a api autoincrementar ele 
            endereco.CdEndereco = 0;
            var x = JsonConvert.SerializeObject(endereco);
            var content = new StringContent(x, UnicodeEncoding.UTF8, "application/json");
            var result = await http.PostAsync($"https://folhamaxxi-api.azurewebsites.net//api/Endereco/Cadastrar",content);
            var json = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                endereco = JsonConvert.DeserializeObject<EnderecoModel>(json);
                return endereco;
            }

            MessageBox.Show("OCORREU UM ERRO AO PERSISTIR NA API, ENTRE EM CONTATO COM O SUPORTE");
            return null;
        }
    }
}
