using Android.Webkit;
using ExamenP3TomasLopez.InterfacesTlopez;
using ExamenP3TomasLopez.ModelsTLopez;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExamenP3TomasLopez.Repositories
{
    
    public class PaisRepository : IpaisInterface
    {
        HttpClient client = new HttpClient();
        public async Task<Pais> pais(string nombre)
        {
            string urlLink = "https://restcountries.com/v3.1/name/" + nombre + "?fields=name,region,maps";
            client.BaseAddress = new Uri(urlLink);
            var cliente = new HttpClient();
            var PaisApi=new Pais();
            HttpResponseMessage respuestaApi= await client.GetAsync("");
            if (respuestaApi.IsSuccessStatusCode)
            {
                var ResponsePais= await respuestaApi.Content.ReadAsStringAsync();
                JsonNode nodo= JsonNode.Parse(ResponsePais);
                JsonNode result = nodo["result"];
                PaisApi = JsonConvert.DeserializeObject<Pais>(result);
            }

            
        }
    }
}
