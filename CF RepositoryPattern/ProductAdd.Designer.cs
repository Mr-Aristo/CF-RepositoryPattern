
namespace CF_RepositoryPattern
{
    partial class ProductAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductIDBox = new System.Windows.Forms.TextBox();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.SuplierIDBox = new System.Windows.Forms.TextBox();
            this.UnitPriceBox = new System.Windows.Forms.TextBox();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductAddbtn = new System.Windows.Forms.Button();
            this.ProductDeletebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(88, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Suplier ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(37, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount :";
            // 
            // ProductIDBox
            // 
            this.ProductIDBox.Location = new System.Drawing.Point(137, 33);
            this.ProductIDBox.Name = "ProductIDBox";
            this.ProductIDBox.Size = new System.Drawing.Size(159, 20);
            this.ProductIDBox.TabIndex = 5;
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Location = new System.Drawing.Point(137, 64);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(159, 20);
            this.ProductNameBox.TabIndex = 6;
            // 
            // SuplierIDBox
            // 
            this.SuplierIDBox.Location = new System.Drawing.Point(137, 96);
            this.SuplierIDBox.Name = "SuplierIDBox";
            this.SuplierIDBox.Size = new System.Drawing.Size(159, 20);
            this.SuplierIDBox.TabIndex = 7;
            // 
            // UnitPriceBox
            // 
            this.UnitPriceBox.Location = new System.Drawing.Point(137, 131);
            this.UnitPriceBox.Name = "UnitPriceBox";
            this.UnitPriceBox.Size = new System.Drawing.Size(159, 20);
            this.UnitPriceBox.TabIndex = 8;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(137, 164);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(159, 20);
            this.AmountBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductAddbtn
            // 
            this.ProductAddbtn.Location = new System.Drawing.Point(74, 307);
            this.ProductAddbtn.Name = "ProductAddbtn";
            this.ProductAddbtn.Size = new System.Drawing.Size(159, 23);
            this.ProductAddbtn.TabIndex = 11;
            this.ProductAddbtn.Text = "Update Product";
            this.ProductAddbtn.UseVisualStyleBackColor = true;
            this.ProductAddbtn.Click += new System.EventHandler(this.ProductAddbtn_Click);
            // 
            // ProductDeletebtn
            // 
            this.ProductDeletebtn.Location = new System.Drawing.Point(74, 336);
            this.ProductDeletebtn.Name = "ProductDeletebtn";
            this.ProductDeletebtn.Size = new System.Drawing.Size(159, 23);
            this.ProductDeletebtn.TabIndex = 12;
            this.ProductDeletebtn.Text = "Delete Product";
            this.ProductDeletebtn.UseVisualStyleBackColor = true;
            this.ProductDeletebtn.Click += new System.EventHandler(this.ProductDeletebtn_Click);
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 462);
            this.Controls.Add(this.ProductDeletebtn);
            this.Controls.Add(this.ProductAddbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.UnitPriceBox);
            this.Controls.Add(this.SuplierIDBox);
            this.Controls.Add(this.ProductNameBox);
            this.Controls.Add(this.ProductIDBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductAdd";
            this.Text = "ProductAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProductAddbtn;
        private System.Windows.Forms.Button ProductDeletebtn;
        public System.Windows.Forms.TextBox ProductIDBox;
        public System.Windows.Forms.TextBox ProductNameBox;
        public System.Windows.Forms.TextBox SuplierIDBox;
        public System.Windows.Forms.TextBox UnitPriceBox;
        public System.Windows.Forms.TextBox AmountBox;
    }
}