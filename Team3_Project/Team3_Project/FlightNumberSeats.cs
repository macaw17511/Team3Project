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

// user enters Flight Number and returns customer's seat

namespace Team3_Project
{
    public partial class FlightNumberSeats : Form
    {

        /////////////////////////////////////
        //       IBM DB2 Connection 
        /////////////////////////////////////

        iDB2Connection  conn;
        iDB2DataAdapter adapter;
        DataSet         dataset;


        public FlightNumberSeats()
        {
            InitializeComponent();
        }
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            string flightNumber = txtFlightNumber.Text;

            if (!string.IsNullOrEmpty(flightNumber))
            {
                lstSeatInfo.Items.Add($"Customer info for Flight: {flightNumber}");

                txtFlightNumber.Clear();
            }
            else
            {

                MessageBox.Show("Please enter a flight number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
