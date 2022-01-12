using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace ChuckConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = GetJokes();
            Console.WriteLine(message);

        }
        public static string GetJokes()
        {
            string url = "https://api.icndb.com/jokes/random";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var WebResponse = request.GetResponse();
            var WebStream = WebResponse.GetResponseStream();

            using (var responseReader = new StreamReader(WebStream))
            {
                var response = responseReader.ReadToEnd();
                Joke joke = JsonConvert.DeserializeObject<Joke>(response);
                
                return joke.value.joke;
            }

        }
    }
}
