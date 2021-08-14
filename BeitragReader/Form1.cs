using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeitragReader
{
    public partial class Beitrag : Form
    {
        public static string Path = "";

        public static string LogoPath = "";

        public static List<CompanyModels.CompanyModel> companies = new List<CompanyModels.CompanyModel>();
        public Beitrag()
        {
            LoadCompanyList();
            InitializeComponent();
           
            createXMLFile2.Visible = false;
            addForm1.Visible = false;
            searchForm2.Visible = false;

        }
        public void openButton_Click(object sender, EventArgs e)
        {
            Form1Code.Form1CodeFiles FilePath = new Form1Code.Form1CodeFiles();
            FilePath.OpenFileAddPath();
            searchForm2.Visible = true;  
        }

        public void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadCompanyList();
            addForm1.WireUpCompanyList();
            searchForm2.Visible = false;
            createXMLFile2.Visible = false;
            addForm1.Visible = true;
        }

        public void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addForm1.Visible = false;
            createXMLFile2.Visible = false;
            searchForm2.Visible = true;
        }

        public void homeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addForm1.Visible = false;
            searchForm2.Visible = false;
            createXMLFile2.Visible = false;
        }

        public void createXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm1.Visible = false;
            searchForm2.Visible = false;
            createXMLFile2.Visible = true;
        }

        private void manageCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm1.Visible = false;
            searchForm2.Visible = false;
            createXMLFile2.Visible = false;
            LoadCompanyList();
            ManageCompaniesForm f2 = new ManageCompaniesForm();
            f2.ShowDialog();
            
        }

        public static void LoadCompanyList()
        {
            companies = SqliteDataAccess.LoadCompanies();
        }
    }
}
