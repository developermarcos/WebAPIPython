using RestSharp;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClienteCSharp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ModelClienteAPI clienteAPI = new ModelClienteAPI();


            string insercao = await clienteAPI.InserirUserAsync(5, "Marcos param", "26");
            Console.WriteLine(insercao);
            

            string edicao = await clienteAPI.EditarUserAsync(5, "Marcos param Editado", "27");
            Console.WriteLine(edicao);


            string selecao = await clienteAPI.SelecionarPorIDAsync(5);
            Console.WriteLine(selecao);

            string exclusao = await clienteAPI.DeleteUserAsync(5);
            Console.WriteLine(exclusao);

            string valido = await clienteAPI.ValidaCpfAsync(1);
            Console.WriteLine(valido);

            string invalido = await clienteAPI.ValidaCpfAsync(123);
            Console.WriteLine(invalido);



            Console.ReadKey();
        }
        public static async Task testeAsync(int id)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://127.0.0.1:5000/user/5"),
                Content = new StringContent("{\"nome\":\"novo nome\",\"idade\":25}")
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
                Console.WriteLine(body);
            }
        }
    }
}
