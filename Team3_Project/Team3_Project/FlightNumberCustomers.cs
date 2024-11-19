using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// user enters a flight number and it lists all of the customers on that flight

namespace Team3_Project
{
    public partial class FlightNumberCustomers : Form
    {

        /////////////////////////////////////
        //       IBM DB2 Connection 
        /////////////////////////////////////

        iDB2Connection  conn;
        iDB2DataAdapter adapter;
        DataSet         dataset;


        public FlightNumberCustomers()
        {
            InitializeComponent();
        }
        public FlightNumberCustomers()
{
    InitializeComponent();
}
private void btnShowInfo_Click(object sender, EventArgs e)
{
    string flightNumber = txtFlightNumber.Text;

    if (!string.IsNullOrEmpty(flightNumber))
    {
        lstCustInfo.Items.Add($"Customer info for Flight: {flightNumber}");

        txtFlightNumber.Clear();
    }
    else
    {

        MessageBox.Show("Please enter a flight number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
    }
}
