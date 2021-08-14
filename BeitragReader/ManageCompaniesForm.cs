using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeitragReader
{
    public partial class ManageCompaniesForm : Form
    {
        public int SelectedIndex { get; set; }

        public ManageCompaniesForm()
        {
            InitializeComponent();           
            WireUpCompanyList();
            Clear();
        }

        private void WireUpCompanyList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Beitrag.companies;
            listBox1.DisplayMember = "CompanyName";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Refresh();
            SelectedIndex = Beitrag.companies.FindIndex(item => item.CompanyName == listBox1.GetItemText(listBox1.SelectedItem));

            if (SelectedIndex >= 0)
            {
                textBox1.Text = Beitrag.companies[SelectedIndex].CompanyName;
                textBox2.Text = Beitrag.companies[SelectedIndex].CompanyEmail;
                textBox3.Text = Beitrag.companies[SelectedIndex].CompanyWebsite;
                textBox4.Text = Beitrag.companies[SelectedIndex].CompanyFacebook;
                textBox5.Text = Beitrag.companies[SelectedIndex].CompanyInsta;
                label1.Text = $"ID: {Beitrag.companies[SelectedIndex].ID.ToString()}";
                Beitrag.LogoPath = Beitrag.companies[SelectedIndex].CompanyLogo;
                loadImage();
            }
        }

        private void addnewbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                CompanyModels.CompanyModel m = new CompanyModels.CompanyModel();
                m.CompanyName = textBox1.Text;
                m.CompanyEmail = textBox2.Text;
                m.CompanyWebsite = textBox3.Text;
                m.CompanyFacebook = textBox4.Text;
                m.CompanyInsta = textBox5.Text;
                m.CompanyLogo = Beitrag.LogoPath;

                if (!Beitrag.companies.Exists(x => x.CompanyName == m.CompanyName))
                {
                    try { SqliteDataAccess.IfExitsCompany(m); MessageBox.Show("Company already exits!"); } catch { SqliteDataAccess.SaveCompany(m); MessageBox.Show("Company created!");}
                }
                else
                {
                    MessageBox.Show("Company already in list!");
                }
                Clear();
            }
            else
            {
                MessageBox.Show("Please add Company Name");
            }
        }

        private void addLogobutton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            CompanyModels.CompanyModelCode mc = new CompanyModels.CompanyModelCode();
            mc.OpenFileAddPath();
            pictureBox.Image = Image.FromFile(Beitrag.LogoPath);

        }

        private void ClearTextBoxes()
        {
            foreach (Control c in CompanyForm.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            listBox1.SelectedItem = null;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            listBox1.SelectedItem = null;
            Beitrag.LogoPath = "";
            pictureBox.Image = null;
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeleteCompany(Beitrag.companies[SelectedIndex].ID);
            if(Beitrag.companies.Exists(x => x.ID == Beitrag.companies[SelectedIndex].ID))
            {
                MessageBox.Show("Item removed!");
            }
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyModels.CompanyModel m = new CompanyModels.CompanyModel();
            m.CompanyName = textBox1.Text;
            m.CompanyEmail = textBox2.Text;
            m.CompanyWebsite = textBox3.Text;
            m.CompanyFacebook = textBox4.Text;
            m.CompanyInsta = textBox5.Text;
            m.CompanyLogo = Beitrag.LogoPath;

            SqliteDataAccess.UpdateCompany(Beitrag.companies[SelectedIndex].ID, m);
            Clear();
            MessageBox.Show("Data edited!");
        }

        private void loadImage()
        {
            try
            {
                pictureBox.Image = Image.FromFile(Beitrag.companies[SelectedIndex].CompanyLogo);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch
            {
                pictureBox.Image = null;
            }
        }

        private void Clear()
        {
            listBox1.SelectedItem = null;
            label1.Text = "";
            pictureBox.Image = null;
            ClearTextBoxes();
            Beitrag.LogoPath = "";
            Beitrag.LoadCompanyList();
            WireUpCompanyList();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
