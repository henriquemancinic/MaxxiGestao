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
    public class EmpresaController
    {
        HttpClient http = new HttpClient();

        public async Task<List<EmpresaModel>> getEmpresas()
        {
            var result = await http.GetAsync($"https://folhamaxxi-api.azurewebsites.net//api/Empresa");
            var json  = await result.Content.ReadAsStringAsync();

            List<EmpresaModel> empresas = JsonConvert.DeserializeObject<List<EmpresaModel>>(json);

            if (result.IsSuccessStatusCode)
            {
                return empresas;
            }
            else { return null; }
        }

        public async Task<EmpresaModel> editEmpresa(EmpresaModel empresa)
        {
            var content = new StringContent(JsonConvert.SerializeObject(empresa), UnicodeEncoding.UTF8, "application/json");
            var result = await http.PostAsync($"https://folhamaxxi-api.azurewebsites.net//api/Empresa/Atualizar/{empresa.CdEmpresa}", content);
            var json = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                empresa = JsonConvert.DeserializeObject<EmpresaModel>(json);
                return empresa;
            }
            else
            {
                MessageBox.Show("OCORREU UM ERRO AO PERSISTIR NA API, ENTRE EM CONTATO COM O SUPORTE");
                return null;
            }
        }

        public async Task<EmpresaModel> getEmpresa(int id)
        {
            var result = await http.GetAsync($"https://folhamaxxi-api.azurewebsites.net//api/Empresa/{id}");
            var json = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<EmpresaModel>(json);
            }

            MessageBox.Show("OCORREU UM ERRO AO PERSISTIR NA API, ENTRE EM CONTATO COM O SUPORTE");
            return null;
        }

        public async Task<EmpresaModel> addEmpresa(EmpresaModel empresa)
        {
            var content = new StringContent(JsonConvert.SerializeObject(empresa), UnicodeEncoding.UTF8, "application/json");
            var result = await http.PostAsync($"https://folhamaxxi-api.azurewebsites.net//api/Empresa/Cadastrar",content);
            var json = await result.Content.ReadAsStringAsync();

            if (result.IsSuccessStatusCode)
            {
                empresa = JsonConvert.DeserializeObject<EmpresaModel>(json);
                return empresa;
            }

            MessageBox.Show("OCORREU UM ERRO AO PERSISTIR NA API, ENTRE EM CONTATO COM O SUPORTE");
            return null;
        }
    }
}
