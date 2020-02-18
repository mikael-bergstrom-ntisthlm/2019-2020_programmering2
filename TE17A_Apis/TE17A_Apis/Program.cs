using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;

namespace TE17A_Apis
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/muk");
            request.AddHeader("Content-Type", "application/json");

            request.AddJsonBody(new Pokemon());
            

            IRestResponse response = client.Get(request);

            Pokemon p = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            Console.WriteLine(p.name + " [" + p.base_experience + "]");

            Console.ReadLine();
        }
    }
}
