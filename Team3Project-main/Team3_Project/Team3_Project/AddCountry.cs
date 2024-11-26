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

// form to add a country

// Dylan Bradley

namespace Team3_Project
{
    public partial class AddCountry : Form
    {

        /////////////////////////////////////
        //       IBM DB2 Connection 
        /////////////////////////////////////

        iDB2Connection  conn;
        iDB2DataAdapter adapter;
        DataSet         dataset;


        public AddCountry()
        {
            InitializeComponent();
        }

        
        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            ///////////////////////////////////////
            //          Input Variables
            ///////////////////////////////////////
            
            string Country      = textCountry.Text;
            string Abbreviation = textAbbreviation.Text;

            string cmdText = "INSERT INTO FLIGHT2024.COUNTRY VALUES(@COUNTRY, @ABBR)";

            try
            {
                conn = new iDB2Connection("Data Source=10.250.0.30");
                conn.Open();

                iDB2Command cmd = new iDB2Command(cmdText, conn);
                cmd.DeriveParameters();

                cmd.Parameters["@COUNTRY"].Value = Country;
                cmd.Parameters["@ABBR"].Value    = Abbreviation;
                cmd.ExecuteNonQuery();

                conn.Close();

                labelError.Text = "SUCCESSFULLY ADDED TO DATABASE";
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
            }
        }
    }
}
