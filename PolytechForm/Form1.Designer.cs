namespace PolytechForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            okBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtRegion = new TextBox();
            txtPostcode = new TextBox();
            txtPhone = new TextBox();
            txtTwitter = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // okBtn
            // 
            okBtn.Location = new Point(112, 424);
            okBtn.Margin = new Padding(2, 2, 2, 2);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(235, 25);
            okBtn.TabIndex = 0;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Name*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 80);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Address*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 126);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "City*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 175);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Region*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 224);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 5;
            label5.Text = "PostCode*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 283);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 6;
            label6.Text = "Phone*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 338);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 7;
            label7.Text = "Twitter*";
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 32);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 23);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(112, 77);
            txtAddress.Margin = new Padding(2, 2, 2, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(236, 23);
            txtAddress.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(112, 122);
            txtCity.Margin = new Padding(2, 2, 2, 2);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(236, 23);
            txtCity.TabIndex = 10;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(112, 172);
            txtRegion.Margin = new Padding(2, 2, 2, 2);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(236, 23);
            txtRegion.TabIndex = 11;
            // 
            // txtPostcode
            // 
            txtPostcode.Location = new Point(112, 221);
            txtPostcode.Margin = new Padding(2, 2, 2, 2);
            txtPostcode.Name = "txtPostcode";
            txtPostcode.Size = new Size(236, 23);
            txtPostcode.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(112, 279);
            txtPhone.Margin = new Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(236, 23);
            txtPhone.TabIndex = 13;
            // 
            // txtTwitter
            // 
            txtTwitter.Location = new Point(112, 334);
            txtTwitter.Margin = new Padding(2, 2, 2, 2);
            txtTwitter.Name = "txtTwitter";
            txtTwitter.Size = new Size(236, 23);
            txtTwitter.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(113, 466);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 15;
            label8.Text = "Fields with * are required";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 510);
            Controls.Add(label8);
            Controls.Add(txtTwitter);
            Controls.Add(txtPhone);
            Controls.Add(txtPostcode);
            Controls.Add(txtRegion);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(okBtn);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtRegion;
        private TextBox txtPostcode;
        private TextBox txtPhone;
        private TextBox txtTwitter;
        private Label label8;
    }
}