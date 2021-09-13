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

        private int SelectedId { get; set; }

        public frmProducts()
        {
            InitializeComponent();
        }

        private void GetData(int id)
        {


            using (HttpClient client = new HttpClient())
            {


                HttpResponseMessage response;
                client.BaseAddress = new Uri("http://10.56.0.41:10093/:10093/");

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                if (id == 0)
                {

                    response = client.GetAsync("api/Products/").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var stringdata = response.Content.ReadAsStringAsync().Result;
                        var products = JsonConvert.DeserializeObject<List<Products>>(stringdata);
                        grvProducts.DataSource = products;
                    }
                    else
                    {
                        MessageBox.Show("Error Code" +
                        response.StatusCode + " : Message - " + response.ReasonPhrase, "Error");
                    }

                }
                else
                {
                    response = client.GetAsync("api/Products/" + id).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var stringdata = response.Content.ReadAsStringAsync().Result;
                        var products = new List<Products>();
                        products.Add(JsonConvert.DeserializeObject<Products>(stringdata));

                        grvProducts.DataSource = products;
                    }
                    else
                    {
                        MessageBox.Show("Error Code" +
                        response.StatusCode + " : Message - " + response.ReasonPhrase, "Error");
                    }
                }


            }





        }

        private void DeleteData(int id)
        {

            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response;
                client.BaseAddress = new Uri("http://10.56.0.41:10093");
                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                if (id > 0)
                {

                    response = client.DeleteAsync("api/Products/" + id).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Product successfully deleted!", "Info");
                    }
                    else
                        MessageBox.Show("Error Code" +
                        response.StatusCode + " : Message - " + response.ReasonPhrase, "Error");
                }

            }

        }


        private void btnGet_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtID.Text, out id) || string.IsNullOrEmpty(txtID.Text))
            {
                GetData(id);
            }
            else
                MessageBox.Show("Invalid Product ID", "Error");


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmCreate frm = new frmCreate();
            frm.ShowDialog();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.grvProducts.DataSource != null)
            {

                List<Products> products = this.grvProducts.DataSource as List<Products>;
                foreach (Products product in products)
                {
                    if (product.Id == SelectedId)
                    {
                        frmCreate frm = new frmCreate();
                        frm.SelectedProduct = product;
                        frm.ShowDialog();
                        break;
                    }
                }
                GetData(0);

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.grvProducts.DataSource != null)
            {

                List<Products> products = this.grvProducts.DataSource as List<Products>;
                foreach (Products product in products)
                {
                    if (product.Id == SelectedId)
                    {
                        DeleteData(SelectedId);
                        break;
                    }

                }

                GetData(0);


            }
        }

        private void grvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.grvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void grvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (this.grvProducts.SelectedRows != null && this.grvProducts.SelectedRows.Count > 0)
            {
                SelectedId = (int)(this.grvProducts.SelectedRows[0].Cells[0].Value);
            }

        }




    }
}
