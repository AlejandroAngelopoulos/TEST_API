namespace TestHttpClient
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grvProducts = new System.Windows.Forms.DataGridView();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grvProducts
            // 
            this.grvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProducts.Location = new System.Drawing.Point(13, 13);
            this.grvProducts.Name = "grvProducts";
            this.grvProducts.Size = new System.Drawing.Size(537, 233);
            this.grvProducts.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(13, 253);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(113, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get Products";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(162, 255);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 20);
            this.txtID.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(139, 258);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "ID:";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 283);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.grvProducts);
            this.Name = "frmProducts";
            this.Text = "Products Form";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvProducts;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}

