using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.WebDataHandler
{
    internal class WebController
    {
        private static readonly HttpClient HttpClient;

        static WebController()
        {
            HttpClient = new HttpClient();
        }

        public static async void RetrieveWebData( string URI)
        {
            try
            {
                HttpResponseMessage response = HttpClient.GetAsync(URI).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in processing web request: {ex.Message}");
            }
        }
    }
}
