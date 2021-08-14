namespace BeitragReader
{
    partial class AddForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveButton = new System.Windows.Forms.Button();
            this.addRichTextBox = new System.Windows.Forms.RichTextBox();
            this.hashListBox = new System.Windows.Forms.ListBox();
            this.addHashButton = new System.Windows.Forms.Button();
            this.removeFromListButton = new System.Windows.Forms.Button();
            this.editListElementButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.readyListBox = new System.Windows.Forms.ListBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.addToReadyListBoxButton = new System.Windows.Forms.Button();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saveChangesbutton = new System.Windows.Forms.Button();
            this.clearreadyListBoxButton = new System.Windows.Forms.Button();
            this.hashTextBox = new System.Windows.Forms.RichTextBox();
            this.beitragIDlabel = new System.Windows.Forms.Label();
            this.beitragIDtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(566, 315);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(211, 91);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save To Xml";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addRichTextBox
            // 
            this.addRichTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.addRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addRichTextBox.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRichTextBox.Location = new System.Drawing.Point(16, 74);
            this.addRichTextBox.Name = "addRichTextBox";
            this.addRichTextBox.Size = new System.Drawing.Size(521, 235);
            this.addRichTextBox.TabIndex = 1;
            this.addRichTextBox.Text = "";
            // 
            // hashListBox
            // 
            this.hashListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.hashListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hashListBox.FormattingEnabled = true;
            this.hashListBox.ItemHeight = 16;
            this.hashListBox.Location = new System.Drawing.Point(565, 131);
            this.hashListBox.Name = "hashListBox";
            this.hashListBox.Size = new System.Drawing.Size(211, 144);
            this.hashListBox.TabIndex = 2;
            // 
            // addHashButton
            // 
            this.addHashButton.Location = new System.Drawing.Point(566, 102);
            this.addHashButton.Name = "addHashButton";
            this.addHashButton.Size = new System.Drawing.Size(68, 23);
            this.addHashButton.TabIndex = 4;
            this.addHashButton.Text = "Add To List";
            this.addHashButton.UseVisualStyleBackColor = true;
            this.addHashButton.Click += new System.EventHandler(this.addHashButton_Click);
            // 
            // removeFromListButton
            // 
            this.removeFromListButton.Location = new System.Drawing.Point(713, 102);
            this.removeFromListButton.Name = "removeFromListButton";
            this.removeFromListButton.Size = new System.Drawing.Size(64, 23);
            this.removeFromListButton.TabIndex = 5;
            this.removeFromListButton.Text = "Remove";
            this.removeFromListButton.UseVisualStyleBackColor = true;
            this.removeFromListButton.Click += new System.EventHandler(this.removeFromListButton_Click);
            // 
            // editListElementButton
            // 
            this.editListElementButton.Location = new System.Drawing.Point(639, 102);
            this.editListElementButton.Name = "editListElementButton";
            this.editListElementButton.Size = new System.Drawing.Size(68, 23);
            this.editListElementButton.TabIndex = 6;
            this.editListElementButton.Text = "Edit";
            this.editListElementButton.UseVisualStyleBackColor = true;
            this.editListElementButton.Click += new System.EventHandler(this.editListElementButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 17);
            this.comboBox1.MaxDropDownItems = 5;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 7;
            // 
            // readyListBox
            // 
            this.readyListBox.BackColor = System.Drawing.SystemColors.Menu;
            this.readyListBox.FormattingEnabled = true;
            this.readyListBox.ItemHeight = 16;
            this.readyListBox.Location = new System.Drawing.Point(159, 315);
            this.readyListBox.Name = "readyListBox";
            this.readyListBox.Size = new System.Drawing.Size(378, 68);
            this.readyListBox.TabIndex = 8;
            this.readyListBox.SelectedIndexChanged += new System.EventHandler(this.readyListBox_SelectedIndexChanged);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.companyLabel.Location = new System.Drawing.Point(170, 18);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(62, 16);
            this.companyLabel.TabIndex = 9;
            this.companyLabel.Text = "Company:";
            // 
            // addToReadyListBoxButton
            // 
            this.addToReadyListBoxButton.Location = new System.Drawing.Point(16, 315);
            this.addToReadyListBoxButton.Name = "addToReadyListBoxButton";
            this.addToReadyListBoxButton.Size = new System.Drawing.Size(100, 69);
            this.addToReadyListBoxButton.TabIndex = 10;
            this.addToReadyListBoxButton.Text = "Add To List";
            this.addToReadyListBoxButton.UseVisualStyleBackColor = true;
            this.addToReadyListBoxButton.Click += new System.EventHandler(this.addToReadyListBoxButton_Click);
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.commentLabel.Location = new System.Drawing.Point(170, 47);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(66, 16);
            this.commentLabel.TabIndex = 11;
            this.commentLabel.Text = "Comment:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.commentTextBox.Location = new System.Drawing.Point(238, 46);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(203, 23);
            this.commentTextBox.TabIndex = 12;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(62, 17);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(100, 49);
            this.newButton.TabIndex = 13;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveChangesbutton
            // 
            this.saveChangesbutton.Location = new System.Drawing.Point(159, 390);
            this.saveChangesbutton.Name = "saveChangesbutton";
            this.saveChangesbutton.Size = new System.Drawing.Size(110, 23);
            this.saveChangesbutton.TabIndex = 16;
            this.saveChangesbutton.Text = "Save Changes";
            this.saveChangesbutton.UseVisualStyleBackColor = true;
            this.saveChangesbutton.Click += new System.EventHandler(this.saveChangesbutton_Click);
            // 
            // clearreadyListBoxButton
            // 
            this.clearreadyListBoxButton.Location = new System.Drawing.Point(424, 390);
            this.clearreadyListBoxButton.Name = "clearreadyListBoxButton";
            this.clearreadyListBoxButton.Size = new System.Drawing.Size(110, 23);
            this.clearreadyListBoxButton.TabIndex = 17;
            this.clearreadyListBoxButton.Text = "Clear List";
            this.clearreadyListBoxButton.UseVisualStyleBackColor = true;
            this.clearreadyListBoxButton.Click += new System.EventHandler(this.clearreadyListBoxButton_Click);
            // 
            // hashTextBox
            // 
            this.hashTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.hashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hashTextBox.Location = new System.Drawing.Point(566, 74);
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.Size = new System.Drawing.Size(211, 24);
            this.hashTextBox.TabIndex = 18;
            this.hashTextBox.Text = "";
            // 
            // beitragIDlabel
            // 
            this.beitragIDlabel.AutoSize = true;
            this.beitragIDlabel.Location = new System.Drawing.Point(445, 20);
            this.beitragIDlabel.Name = "beitragIDlabel";
            this.beitragIDlabel.Size = new System.Drawing.Size(68, 16);
            this.beitragIDlabel.TabIndex = 19;
            this.beitragIDlabel.Text = "Beitrag ID:";
            // 
            // beitragIDtextBox
            // 
            this.beitragIDtextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.beitragIDtextBox.Location = new System.Drawing.Point(510, 17);
            this.beitragIDtextBox.Name = "beitragIDtextBox";
            this.beitragIDtextBox.ReadOnly = true;
            this.beitragIDtextBox.Size = new System.Drawing.Size(27, 23);
            this.beitragIDtextBox.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.beitragIDtextBox);
            this.groupBox1.Controls.Add(this.beitragIDlabel);
            this.groupBox1.Controls.Add(this.hashTextBox);
            this.groupBox1.Controls.Add(this.clearreadyListBoxButton);
            this.groupBox1.Controls.Add(this.saveChangesbutton);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.newButton);
            this.groupBox1.Controls.Add(this.commentTextBox);
            this.groupBox1.Controls.Add(this.commentLabel);
            this.groupBox1.Controls.Add(this.addToReadyListBoxButton);
            this.groupBox1.Controls.Add(this.companyLabel);
            this.groupBox1.Controls.Add(this.readyListBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.editListElementButton);
            this.groupBox1.Controls.Add(this.removeFromListButton);
            this.groupBox1.Controls.Add(this.addHashButton);
            this.groupBox1.Controls.Add(this.hashListBox);
            this.groupBox1.Controls.Add(this.addRichTextBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 420);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.groupBox1);
            this.Name = "AddForm";
            this.Size = new System.Drawing.Size(800, 424);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        public System.Windows.Forms.RichTextBox addRichTextBox;
        public System.Windows.Forms.ListBox hashListBox;
        private System.Windows.Forms.Button addHashButton;
        private System.Windows.Forms.Button removeFromListButton;
        private System.Windows.Forms.Button editListElementButton;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ListBox readyListBox;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Button addToReadyListBoxButton;
        private System.Windows.Forms.Label commentLabel;
        public System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saveChangesbutton;
        private System.Windows.Forms.Button clearreadyListBoxButton;
        public System.Windows.Forms.RichTextBox hashTextBox;
        private System.Windows.Forms.Label beitragIDlabel;
        public System.Windows.Forms.TextBox beitragIDtextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
