using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClienteCSharp
{
    [Serializable]
    public class Cliente
    {
        public Cliente(string nome, string idade)
        {
            this.nome=nome;
            this.idade=idade;
        }

        public int ID { get; set; }
        public string nome { get; set; }
        public string idade { get; set; }
    }
    public class ModelClienteAPI
    {
        public async Task<String> SelecionarPorIDAsync(int id)
        {
            string objetoCliente = "";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("http://127.0.0.1:5000/user/"+id),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                objetoCliente = body;
            }

            return objetoCliente;
        }

        public async Task<String> DeleteUserAsync(int id)
        {
            string retorno = "";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("http://127.0.0.1:5000/user/"+id),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                retorno = body;
            }
            return retorno;
        }

        public async Task<String> InserirUserAsync(int id, string nome, string idade)
        {
            Cliente cliente = new Cliente(nome, idade);
            var objetoJson = Conversor.SerializarObjeto(cliente);

            string retorno = "";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://127.0.0.1:5000/user/"+id),
                Content = new StringContent(objetoJson)
                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                retorno = body;
            }
            return retorno;
        }

        public async Task<String> EditarUserAsync(int id, string nome, string idade)
        {
            Cliente cliente = new Cliente(nome, idade);
            var objetoJson = Conversor.SerializarObjeto(cliente);

            string retorno = "";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri("http://127.0.0.1:5000/user/"+id),
                Content = new StringContent(objetoJson)
                {
                    Headers =
                    {
                        ContentType = new MediaTypeHeaderValue("application/json")
                    }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                retorno = body;
            }
            return retorno;
        }

        public async Task<String> ValidaCpfAsync(int cpf)
        {
            string retorno = "";
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://localhost:5000/validacpf/"+cpf),
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                retorno = body;
            }
            return retorno;
        }
    }
}
