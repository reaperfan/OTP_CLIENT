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
using RestSharp;

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
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync(String.Format(@"https://localhost:44342/api/dokumentumok/{0}",filename));

                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    var fileInfo = new FileInfo(filename);
                    using (var fileStream = fileInfo.OpenWrite())
                    {
                        await stream.CopyToAsync(fileStream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private async Task<object> UploadAsync(string path)
        {
            var client = new WebClient();
            var uri = new Uri(@"https://localhost:44342/api/dokumentumok/feltoltes");
            using (var fileStream = File.Open(path, FileMode.Open))
            {


                var client = new RestClient(server);
                var request = new RestRequest(Method.POST);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    await fileStream.CopyToAsync(memoryStream);
                    request.AddFile("file", memoryStream.ToArray(), fileName);
                    request.AlwaysMultipartFormData = true;
                    var response = await client.ExecuteTaskAsync(request);
                    return response;
                }
            }


        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    UploadAsync(dialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private async Task<IRestResponse> UploadAsync(string fileName, string server)
        {
          
        }
    }
}
