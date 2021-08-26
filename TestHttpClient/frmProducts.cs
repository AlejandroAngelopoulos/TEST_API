using Newtonsoft.Json;
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
    public partial class frmProducts : Form
    {   
      
         
        public frmProducts()
        {
            InitializeComponent();
        }

        private void GetData()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://10.56.0.41:8090/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/getallproducts").Result;

            if (response.IsSuccessStatusCode)
            {
                var stringdata = response.Content.ReadAsStringAsync().Result;
                var products = JsonConvert.DeserializeObject<List<Products>>(stringdata);
                grvProducts.DataSource = products;

            }
            else
            {
                MessageBox.Show("Error Code" + 
                response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            

        }
    }
}
