using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeitragReader.CompanyModels
{
    public partial class CompanyUserForm : UserControl
    {
        public CompanyUserForm()
        {
            InitializeComponent();
            WireUpCompanyList();
        }

        private void WireUpCompanyList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Beitrag.companies;
            listBox1.DisplayMember = "CompanyName";
        }

    }
}
