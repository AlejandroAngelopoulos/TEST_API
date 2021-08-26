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
using Newtonsoft.Json;

namespace TestHttpClient
{
    public partial class frmCreate : Form
    {
        public frmCreate()
        {
            InitializeComponent();
        }

        private void PostData()
        {

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://10.56.0.41:10093/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var product = new Products();

            product.Name = Convert.ToString(txtName.Text);
            product.Category = Convert.ToString(txtCategory.Text);
            product.Price = Convert.ToDecimal(txtPrice.Text);

            var postTask = client.PostAsJsonAsync<Products>("api/Products/product", product);
            postTask.Wait();

            var result = postTask.Result;
            if (result.IsSuccessStatusCode)
            {
                MessageBox.Show("Product created successfuly!", "Info");
                this.Close();
            }
            else
                MessageBox.Show("Product creation failed", "Error");





        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PostData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
