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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grvProducts
            // 
            this.grvProducts.AllowUserToAddRows = false;
            this.grvProducts.AllowUserToDeleteRows = false;
            this.grvProducts.AllowUserToResizeColumns = false;
            this.grvProducts.AllowUserToResizeRows = false;
            this.grvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvProducts.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProducts.Location = new System.Drawing.Point(13, 13);
            this.grvProducts.MultiSelect = false;
            this.grvProducts.Name = "grvProducts";
            this.grvProducts.ReadOnly = true;
            this.grvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvProducts.Size = new System.Drawing.Size(537, 233);
            this.grvProducts.TabIndex = 0;
            this.grvProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grvProducts_DataBindingComplete);
            this.grvProducts.SelectionChanged += new System.EventHandler(this.grvProducts_SelectionChanged);
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
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(264, 253);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(84, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New Product";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(455, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(354, 253);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(562, 283);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.grvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Form";
            ((System.ComponentModel.ISupportInitialize)(this.grvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvProducts;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

