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
using Newtonsoft.Json;

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
                client.Timeout = TimeSpan.FromSeconds(5);
                var response = await client.GetAsync(String.Format(@"https://localhost:44342/api/dokumentumok/{0}",filename));
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show(response.ToString());
                }
                string result = response.Content.ReadAsStringAsync().Result;
                var fileInfo = new FileInfo(filename);
                File.WriteAllBytes(fileInfo.FullName, Convert.FromBase64String(result));
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private async Task Upload(string path)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(5);
                var multiForm = new MultipartFormDataContent();

                FileStream fs = File.OpenRead(path);
                multiForm.Add(new StreamContent(fs), "file", Path.GetFileName(path));

                var uri = new Uri(@"https://localhost:44342/api/dokumentumok/feltoltes");
                var response = await client.PostAsync(uri, multiForm);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show(response.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    uploadTxt.Text = dialog.FileName;
                    Upload(dialog.FileName);
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private async Task ListFilesAsync()
        {
            try
            {
                var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(1);
                var response = await client.GetAsync(String.Format(@"https://localhost:44342/api/dokumentumok/"));
            
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show(response.ToString());
                    return;
                }
                var data = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<string>>(data);
                this.fileLb.DataSource = null;
                this.fileLb.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ListFilesAsync();
        }
    }
}
