using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

// form to add a boat

namespace Team3_Project
{
    public partial class AddBoat : Form
    {
        /////////////////////////////////////
        //       IBM DB2 Connection 
        /////////////////////////////////////
        
        iDB2Connection  conn;
        iDB2DataAdapter adapter;
        DataSet         dataset;


        public AddBoat()
        {
            InitializeComponent();
        }

        private void addBoatButton_Click(object sender, EventArgs e)
        {
            string year = txtYear.Text;
            string make = txtMake.Text;
            string model = txtModel.Text;

            if (!string.IsNullOrWhiteSpace(year) &&
                !string.IsNullOrWhiteSpace(make) &&
                !string.IsNullOrWhiteSpace(model))
            {
                listBox2.Items.Add($"{year} {make} {model}");

                txtYear.Clear();
                txtMake.Clear();
                txtModel.Clear();
            }
            else
            {
                MessageBox.Show("Please enter Year, Make, and Model.", "Missing info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
