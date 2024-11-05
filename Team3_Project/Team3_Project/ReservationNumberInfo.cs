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

// user enters in Reservation Number and retrieves customer info

namespace Team3_Project
{
    public partial class ReservationNumberInfo : Form
    {

        /////////////////////////////////////
        //       IBM DB2 Connection 
        /////////////////////////////////////

        iDB2Connection  conn;
        iDB2DataAdapter adapter;
        DataSet         dataset;


        public ReservationNumberInfo()
        {
            InitializeComponent();
        }
    }
}
