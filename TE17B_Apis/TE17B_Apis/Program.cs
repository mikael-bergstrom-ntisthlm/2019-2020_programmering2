using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace TE17B_Apis
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            RestRequest request = new RestRequest("pokemon/rhyhorn");

            IRestResponse response = client.Get(request);

            Pokemon raichu = JsonConvert.DeserializeObject<Pokemon>(response.Content);


            Console.WriteLine(raichu.name + " [" + raichu.base_experience + "]");

            Console.ReadLine();
        }
    }
}
