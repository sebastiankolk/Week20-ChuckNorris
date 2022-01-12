using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetJokesBtn_Click(object sender, EventArgs e)
        {
            jokeBox.Text = GetJokes();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
