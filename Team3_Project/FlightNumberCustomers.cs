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
        /////////////////////////////////////
        //       DAONTE DALLAS
        /////////////////////////////////////
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
    }
}
