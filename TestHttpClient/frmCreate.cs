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

        public Products SelectedProduct { get; set; }

        private void PostData()
        {

            using (HttpClient client = new HttpClient())
            {
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
        }

        private void UpdateData()
        {
            using (HttpClient client = new HttpClient())
            {


                client.BaseAddress = new Uri("http://10.56.0.41:10093/");

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var product = new Products();

                product.Id = SelectedProduct.Id;
                product.Name = Convert.ToString(txtName.Text);
                product.Category = Convert.ToString(txtCategory.Text);
                product.Price = Convert.ToDecimal(txtPrice.Text);

                var postTask = client.PutAsJsonAsync<Products>("api/Products/product", product);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Product updated successfuly!", "Info");
                    this.Close();
                }
                else
                    MessageBox.Show("Product Update failed", "Error");

            }




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedProduct == null)
                PostData();
            else
                UpdateData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            if (SelectedProduct != null)
            {
                txtName.Text = SelectedProduct.Name;
                txtCategory.Text = SelectedProduct.Category;
                txtPrice.Text = Convert.ToString(SelectedProduct.Price);
            }
        }
    }
}
