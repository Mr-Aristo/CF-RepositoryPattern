
namespace CF_RepositoryPattern
{
    partial class OrderAdd
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
            this.OrderDeletebtn = new System.Windows.Forms.Button();
            this.OrderUpdatebtn = new System.Windows.Forms.Button();
            this.OrderAddbtn = new System.Windows.Forms.Button();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.ProductIDBox = new System.Windows.Forms.TextBox();
            this.OrderIDBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderDeletebtn
            // 
            this.OrderDeletebtn.Location = new System.Drawing.Point(75, 350);
            this.OrderDeletebtn.Name = "OrderDeletebtn";
            this.OrderDeletebtn.Size = new System.Drawing.Size(159, 23);
            this.OrderDeletebtn.TabIndex = 25;
            this.OrderDeletebtn.Text = "Delete Order";
            this.OrderDeletebtn.UseVisualStyleBackColor = true;
            this.OrderDeletebtn.Click += new System.EventHandler(this.OrderDeletebtn_Click);
            // 
            // OrderUpdatebtn
            // 
            this.OrderUpdatebtn.Location = new System.Drawing.Point(75, 321);
            this.OrderUpdatebtn.Name = "OrderUpdatebtn";
            this.OrderUpdatebtn.Size = new System.Drawing.Size(159, 23);
            this.OrderUpdatebtn.TabIndex = 24;
            this.OrderUpdatebtn.Text = "Update Order";
            this.OrderUpdatebtn.UseVisualStyleBackColor = true;
            this.OrderUpdatebtn.Click += new System.EventHandler(this.OrderUpdatebtn_Click);
            // 
            // OrderAddbtn
            // 
            this.OrderAddbtn.Location = new System.Drawing.Point(75, 292);
            this.OrderAddbtn.Name = "OrderAddbtn";
            this.OrderAddbtn.Size = new System.Drawing.Size(159, 23);
            this.OrderAddbtn.TabIndex = 23;
            this.OrderAddbtn.Text = "Add Order";
            this.OrderAddbtn.UseVisualStyleBackColor = true;
            this.OrderAddbtn.Click += new System.EventHandler(this.OrderAddbtn_Click);
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(124, 145);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(159, 20);
            this.CostBox.TabIndex = 21;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(124, 110);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(159, 20);
            this.DateBox.TabIndex = 20;
            // 
            // ProductIDBox
            // 
            this.ProductIDBox.Location = new System.Drawing.Point(124, 78);
            this.ProductIDBox.Name = "ProductIDBox";
            this.ProductIDBox.Size = new System.Drawing.Size(159, 20);
            this.ProductIDBox.TabIndex = 19;
            // 
            // OrderIDBox
            // 
            this.OrderIDBox.Location = new System.Drawing.Point(124, 47);
            this.OrderIDBox.Name = "OrderIDBox";
            this.OrderIDBox.Size = new System.Drawing.Size(159, 20);
            this.OrderIDBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(24, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total Cost :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Order Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Product ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order ID :";
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 462);
            this.Controls.Add(this.OrderDeletebtn);
            this.Controls.Add(this.OrderUpdatebtn);
            this.Controls.Add(this.OrderAddbtn);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.ProductIDBox);
            this.Controls.Add(this.OrderIDBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderAdd";
            this.Text = "OrderAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderDeletebtn;
        private System.Windows.Forms.Button OrderUpdatebtn;
        private System.Windows.Forms.Button OrderAddbtn;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox ProductIDBox;
        private System.Windows.Forms.TextBox OrderIDBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}