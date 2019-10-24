using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using RestSharp;

using System.Security.Cryptography;


namespace TE17C_api
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient marvelClient = new RestClient("http://gateway.marvel.com/");

            string timeStamp = DateTime.Now.ToString();
            string privateKey = "";
            string publicKey = "";

            RestRequest request = new RestRequest("/v1/public/characters/1009610");

            request.AddParameter("ts", timeStamp);
            request.AddParameter("apikey", publicKey);
            request.AddParameter("hash", MD5Hash(timeStamp + privateKey + publicKey));

            IRestResponse response = marvelClient.Get(request);

            //Console.WriteLine(response.Content);


            MarvelResponse mResponse = JsonConvert.DeserializeObject<MarvelResponse>(response.Content);

            Console.WriteLine(mResponse.data.results[0].name);
            Console.WriteLine(mResponse.data.results[0].description);



            //RestClient client = new RestClient("https://pokeapi.co/api/v2/");

            //int h = 6;

            //RestRequest request = new RestRequest("pokemon/" + h);

            //IRestResponse response = client.Get(request);

            

            //Console.WriteLine(response.Content);

            //Pokemon p = JsonConvert.DeserializeObject<Pokemon>(response.Content);

            //Console.WriteLine(p.types[1].type.name);

            //Console.WriteLine(p.Types);

            //Console.WriteLine(p.name);

            Console.ReadLine();
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
