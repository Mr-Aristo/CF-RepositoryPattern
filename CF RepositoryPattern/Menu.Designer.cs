
namespace CF_RepositoryPattern
{
    partial class Menu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Selectbtn = new System.Windows.Forms.Button();
            this.ListProductbtn = new System.Windows.Forms.Button();
            this.ListOrderbtn = new System.Windows.Forms.Button();
            this.ListSuplierbtn = new System.Windows.Forms.Button();
            this.OptProductbtn = new System.Windows.Forms.Button();
            this.OptOrderbtn = new System.Windows.Forms.Button();
            this.OptSuplierbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(637, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(634, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Check Monitors";
            // 
            // Selectbtn
            // 
            this.Selectbtn.Location = new System.Drawing.Point(637, 69);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(171, 25);
            this.Selectbtn.TabIndex = 3;
            this.Selectbtn.Text = "Select";
            this.Selectbtn.UseVisualStyleBackColor = true;
            this.Selectbtn.Click += new System.EventHandler(this.Selectbtn_Click);
            // 
            // ListProductbtn
            // 
            this.ListProductbtn.Location = new System.Drawing.Point(6, 13);
            this.ListProductbtn.Name = "ListProductbtn";
            this.ListProductbtn.Size = new System.Drawing.Size(171, 25);
            this.ListProductbtn.TabIndex = 4;
            this.ListProductbtn.Text = "List Products";
            this.ListProductbtn.UseVisualStyleBackColor = true;
            this.ListProductbtn.Click += new System.EventHandler(this.ListProductbtn_Click);
            // 
            // ListOrderbtn
            // 
            this.ListOrderbtn.Location = new System.Drawing.Point(6, 44);
            this.ListOrderbtn.Name = "ListOrderbtn";
            this.ListOrderbtn.Size = new System.Drawing.Size(171, 25);
            this.ListOrderbtn.TabIndex = 5;
            this.ListOrderbtn.Text = "List Orders";
            this.ListOrderbtn.UseVisualStyleBackColor = true;
            this.ListOrderbtn.Click += new System.EventHandler(this.ListOrderbtn_Click);
            // 
            // ListSuplierbtn
            // 
            this.ListSuplierbtn.Location = new System.Drawing.Point(6, 75);
            this.ListSuplierbtn.Name = "ListSuplierbtn";
            this.ListSuplierbtn.Size = new System.Drawing.Size(171, 25);
            this.ListSuplierbtn.TabIndex = 6;
            this.ListSuplierbtn.Text = "List Supliers";
            this.ListSuplierbtn.UseVisualStyleBackColor = true;
            this.ListSuplierbtn.Click += new System.EventHandler(this.ListSuplierbtn_Click);
            // 
            // OptProductbtn
            // 
            this.OptProductbtn.Location = new System.Drawing.Point(6, 19);
            this.OptProductbtn.Name = "OptProductbtn";
            this.OptProductbtn.Size = new System.Drawing.Size(171, 25);
            this.OptProductbtn.TabIndex = 7;
            this.OptProductbtn.Text = "Product ";
            this.OptProductbtn.UseVisualStyleBackColor = true;
            this.OptProductbtn.Click += new System.EventHandler(this.OptProductbtn_Click);
            // 
            // OptOrderbtn
            // 
            this.OptOrderbtn.Location = new System.Drawing.Point(6, 50);
            this.OptOrderbtn.Name = "OptOrderbtn";
            this.OptOrderbtn.Size = new System.Drawing.Size(171, 25);
            this.OptOrderbtn.TabIndex = 8;
            this.OptOrderbtn.Text = "Order";
            this.OptOrderbtn.UseVisualStyleBackColor = true;
            this.OptOrderbtn.Click += new System.EventHandler(this.OptOrderbtn_Click);
            // 
            // OptSuplierbtn
            // 
            this.OptSuplierbtn.Location = new System.Drawing.Point(6, 81);
            this.OptSuplierbtn.Name = "OptSuplierbtn";
            this.OptSuplierbtn.Size = new System.Drawing.Size(171, 25);
            this.OptSuplierbtn.TabIndex = 9;
            this.OptSuplierbtn.Text = "Suplier";
            this.OptSuplierbtn.UseVisualStyleBackColor = true;
            this.OptSuplierbtn.Click += new System.EventHandler(this.OptSuplierbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OptProductbtn);
            this.groupBox1.Controls.Add(this.OptSuplierbtn);
            this.groupBox1.Controls.Add(this.OptOrderbtn);
            this.groupBox1.Location = new System.Drawing.Point(637, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListSuplierbtn);
            this.groupBox2.Controls.Add(this.ListProductbtn);
            this.groupBox2.Controls.Add(this.ListOrderbtn);
            this.groupBox2.Location = new System.Drawing.Point(637, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 148);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Items";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Selectbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Selectbtn;
        private System.Windows.Forms.Button ListProductbtn;
        private System.Windows.Forms.Button ListOrderbtn;
        private System.Windows.Forms.Button ListSuplierbtn;
        private System.Windows.Forms.Button OptProductbtn;
        private System.Windows.Forms.Button OptOrderbtn;
        private System.Windows.Forms.Button OptSuplierbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

