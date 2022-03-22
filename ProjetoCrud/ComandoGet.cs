using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace ProjetoCrud
{
    public class ComandoGet
    {
        public static async Task Get()
        {
            var httpClient = new HttpClient();
            var resquet = new HttpRequestMessage();
            var response = await httpClient.GetAsync("https://donuz.co/api/#cliente");
            var data = await response.Content.ReadAsStringAsync();
        }
    }
}
