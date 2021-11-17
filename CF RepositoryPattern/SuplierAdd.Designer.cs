
namespace CF_RepositoryPattern
{
    partial class SuplierAdd
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
            this.SuplierDeletebtn = new System.Windows.Forms.Button();
            this.SuplierUpdatebtn = new System.Windows.Forms.Button();
            this.SuplierAddbtn = new System.Windows.Forms.Button();
            this.ContactNameBox = new System.Windows.Forms.TextBox();
            this.CompanyNameBox = new System.Windows.Forms.TextBox();
            this.SuplierIDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SuplierDeletebtn
            // 
            this.SuplierDeletebtn.Location = new System.Drawing.Point(62, 368);
            this.SuplierDeletebtn.Name = "SuplierDeletebtn";
            this.SuplierDeletebtn.Size = new System.Drawing.Size(159, 23);
            this.SuplierDeletebtn.TabIndex = 36;
            this.SuplierDeletebtn.Text = "Delete Suplier";
            this.SuplierDeletebtn.UseVisualStyleBackColor = true;
            this.SuplierDeletebtn.Click += new System.EventHandler(this.SuplierDeletebtn_Click);
            // 
            // SuplierUpdatebtn
            // 
            this.SuplierUpdatebtn.Location = new System.Drawing.Point(62, 339);
            this.SuplierUpdatebtn.Name = "SuplierUpdatebtn";
            this.SuplierUpdatebtn.Size = new System.Drawing.Size(159, 23);
            this.SuplierUpdatebtn.TabIndex = 35;
            this.SuplierUpdatebtn.Text = "Update Suplier";
            this.SuplierUpdatebtn.UseVisualStyleBackColor = true;
            this.SuplierUpdatebtn.Click += new System.EventHandler(this.SuplierUpdatebtn_Click);
            // 
            // SuplierAddbtn
            // 
            this.SuplierAddbtn.Location = new System.Drawing.Point(62, 310);
            this.SuplierAddbtn.Name = "SuplierAddbtn";
            this.SuplierAddbtn.Size = new System.Drawing.Size(159, 23);
            this.SuplierAddbtn.TabIndex = 34;
            this.SuplierAddbtn.Text = "Add Suplier";
            this.SuplierAddbtn.UseVisualStyleBackColor = true;
            this.SuplierAddbtn.Click += new System.EventHandler(this.SuplierAddbtn_Click);
            // 
            // ContactNameBox
            // 
            this.ContactNameBox.Location = new System.Drawing.Point(129, 128);
            this.ContactNameBox.Name = "ContactNameBox";
            this.ContactNameBox.Size = new System.Drawing.Size(159, 20);
            this.ContactNameBox.TabIndex = 32;
            // 
            // CompanyNameBox
            // 
            this.CompanyNameBox.Location = new System.Drawing.Point(129, 96);
            this.CompanyNameBox.Name = "CompanyNameBox";
            this.CompanyNameBox.Size = new System.Drawing.Size(159, 20);
            this.CompanyNameBox.TabIndex = 31;
            // 
            // SuplierIDBox
            // 
            this.SuplierIDBox.Location = new System.Drawing.Point(129, 65);
            this.SuplierIDBox.Name = "SuplierIDBox";
            this.SuplierIDBox.Size = new System.Drawing.Size(159, 20);
            this.SuplierIDBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Contact Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(-3, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Company Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Suplier ID :";
            // 
            // SuplierAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 462);
            this.Controls.Add(this.SuplierDeletebtn);
            this.Controls.Add(this.SuplierUpdatebtn);
            this.Controls.Add(this.SuplierAddbtn);
            this.Controls.Add(this.ContactNameBox);
            this.Controls.Add(this.CompanyNameBox);
            this.Controls.Add(this.SuplierIDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuplierAdd";
            this.Text = "SuplierAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SuplierDeletebtn;
        private System.Windows.Forms.Button SuplierUpdatebtn;
        private System.Windows.Forms.Button SuplierAddbtn;
        private System.Windows.Forms.TextBox ContactNameBox;
        private System.Windows.Forms.TextBox CompanyNameBox;
        private System.Windows.Forms.TextBox SuplierIDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}