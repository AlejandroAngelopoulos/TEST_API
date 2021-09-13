using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestHttpClient
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response;
                client.BaseAddress = new Uri("http://192.168.43.155:10093/");
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/ValidateUser/" + txtUser.Text + "/" + txtPass.Text).Result;
                if (response.IsSuccessStatusCode)
                {
                    frmProducts frm = new frmProducts();
                    frm.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Error Code" +
                    response.StatusCode + " : Message - " + response.ReasonPhrase, "Error");
            }

        }
    }
}

