using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text;
using Nancy.Json;
using System.IO;
using System.Net.Http;

namespace FileAPI_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            Download(downloadTxt.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void Download(string filename)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(@"http://localhost:44342/api/dokumentumok/" + filename);

            using (var stream = await response.Content.ReadAsStreamAsync())
            {
                var fileInfo = new FileInfo(filename);
                using (var fileStream = fileInfo.OpenWrite())
                {
                    await stream.CopyToAsync(fileStream);
                }
            }
        }
    }
}
