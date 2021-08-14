namespace BeitragReader
{
    partial class ManageCompaniesForm
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
            this.CompanyForm = new System.Windows.Forms.GroupBox();
            this.removebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addLogobutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addnewbutton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.instagramLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.facebookLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.websiteLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.CompanyForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CompanyForm
            // 
            this.CompanyForm.Controls.Add(this.removebutton);
            this.CompanyForm.Controls.Add(this.label1);
            this.CompanyForm.Controls.Add(this.IDlabel);
            this.CompanyForm.Controls.Add(this.clearbutton);
            this.CompanyForm.Controls.Add(this.listBox1);
            this.CompanyForm.Controls.Add(this.addLogobutton);
            this.CompanyForm.Controls.Add(this.button1);
            this.CompanyForm.Controls.Add(this.addnewbutton);
            this.CompanyForm.Controls.Add(this.textBox5);
            this.CompanyForm.Controls.Add(this.instagramLabel);
            this.CompanyForm.Controls.Add(this.textBox4);
            this.CompanyForm.Controls.Add(this.facebookLabel);
            this.CompanyForm.Controls.Add(this.textBox3);
            this.CompanyForm.Controls.Add(this.textBox2);
            this.CompanyForm.Controls.Add(this.websiteLabel);
            this.CompanyForm.Controls.Add(this.emailLabel);
            this.CompanyForm.Controls.Add(this.nameLabel);
            this.CompanyForm.Controls.Add(this.textBox1);
            this.CompanyForm.Controls.Add(this.pictureBox);
            this.CompanyForm.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyForm.Location = new System.Drawing.Point(12, 12);
            this.CompanyForm.Name = "CompanyForm";
            this.CompanyForm.Size = new System.Drawing.Size(794, 418);
            this.CompanyForm.TabIndex = 1;
            this.CompanyForm.TabStop = false;
            this.CompanyForm.Text = "Company";
            // 
            // removebutton
            // 
            this.removebutton.Location = new System.Drawing.Point(229, 329);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(99, 49);
            this.removebutton.TabIndex = 19;
            this.removebutton.Text = "Remove";
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(16, 23);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(0, 16);
            this.IDlabel.TabIndex = 17;
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(640, 44);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(138, 191);
            this.clearbutton.TabIndex = 16;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(359, 276);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 114);
            this.listBox1.TabIndex = 15;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // addLogobutton
            // 
            this.addLogobutton.Location = new System.Drawing.Point(19, 253);
            this.addLogobutton.Name = "addLogobutton";
            this.addLogobutton.Size = new System.Drawing.Size(229, 23);
            this.addLogobutton.TabIndex = 14;
            this.addLogobutton.Text = "Add Logo";
            this.addLogobutton.UseVisualStyleBackColor = true;
            this.addLogobutton.Click += new System.EventHandler(this.addLogobutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addnewbutton
            // 
            this.addnewbutton.Location = new System.Drawing.Point(19, 329);
            this.addnewbutton.Name = "addnewbutton";
            this.addnewbutton.Size = new System.Drawing.Size(99, 49);
            this.addnewbutton.TabIndex = 11;
            this.addnewbutton.Text = "Add New";
            this.addnewbutton.UseVisualStyleBackColor = true;
            this.addnewbutton.Click += new System.EventHandler(this.addnewbutton_Click);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(359, 213);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(271, 23);
            this.textBox5.TabIndex = 10;
            // 
            // instagramLabel
            // 
            this.instagramLabel.AutoSize = true;
            this.instagramLabel.Location = new System.Drawing.Point(288, 216);
            this.instagramLabel.Name = "instagramLabel";
            this.instagramLabel.Size = new System.Drawing.Size(67, 16);
            this.instagramLabel.TabIndex = 9;
            this.instagramLabel.Text = "Instagram:";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(359, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 23);
            this.textBox4.TabIndex = 8;
            // 
            // facebookLabel
            // 
            this.facebookLabel.AutoSize = true;
            this.facebookLabel.Location = new System.Drawing.Point(289, 172);
            this.facebookLabel.Name = "facebookLabel";
            this.facebookLabel.Size = new System.Drawing.Size(64, 16);
            this.facebookLabel.TabIndex = 7;
            this.facebookLabel.Text = "Facebook:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(359, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(359, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 23);
            this.textBox2.TabIndex = 5;
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(281, 131);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(72, 16);
            this.websiteLabel.TabIndex = 4;
            this.websiteLabel.Text = "Homepage:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(264, 88);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(87, 16);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email Address:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(254, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 16);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Company Name:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(359, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 23);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(19, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(229, 196);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // ManageCompaniesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(823, 443);
            this.Controls.Add(this.CompanyForm);
            this.Name = "ManageCompaniesForm";
            this.Text = "ManageCompaniesForm";
            this.CompanyForm.ResumeLayout(false);
            this.CompanyForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CompanyForm;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addLogobutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addnewbutton;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label instagramLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label facebookLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label websiteLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removebutton;
    }
}