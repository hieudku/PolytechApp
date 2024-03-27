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
            SuspendLayout();
            // 
            // okBtn
            // 
            okBtn.Location = new Point(160, 658);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(336, 41);
            okBtn.TabIndex = 0;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 60);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 134);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 2;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 210);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 3;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 292);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 4;
            label4.Text = "Region";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 374);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 5;
            label5.Text = "PostCode";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 471);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 6;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 563);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 7;
            label7.Text = "Twitter";
            // 
            // txtName
            // 
            txtName.Location = new Point(160, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(336, 31);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(160, 128);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(336, 31);
            txtAddress.TabIndex = 9;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(160, 204);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(336, 31);
            txtCity.TabIndex = 10;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(160, 286);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(336, 31);
            txtRegion.TabIndex = 11;
            // 
            // txtPostcode
            // 
            txtPostcode.Location = new Point(160, 368);
            txtPostcode.Name = "txtPostcode";
            txtPostcode.Size = new Size(336, 31);
            txtPostcode.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(160, 465);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(336, 31);
            txtPhone.TabIndex = 13;
            // 
            // txtTwitter
            // 
            txtTwitter.Location = new Point(160, 557);
            txtTwitter.Name = "txtTwitter";
            txtTwitter.Size = new Size(336, 31);
            txtTwitter.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 850);
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
    }
}