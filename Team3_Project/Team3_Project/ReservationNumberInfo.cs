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
        DataTable dataTable;


        public ReservationNumberInfo()
        {
            InitializeComponent();
        }

        private void ReservationNumberInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserRes = ResInputTxt.Text;

            if (UserRes != "")
            {
                try
                {
                    int UserResNum = Int32.Parse(UserRes);
                    if (UserResNum > 0 && UserResNum < 500) //replace later
                    {
                        ErrorLbl.Text = "Wow! It works!";
                        // The idea of having the connection call here is so the User can try to check multiple IDs.
                        conn = new iDB2Connection("Data Source=10.250.0.30");
                        // SELECT [Columns] FROM [Table] WHERE [Columns]=[Desired Num]
                        adapter = new iDB2DataAdapter("SELECT CFNAME, CLNAME, CADDR, CCITY, CSTATE, CZIP, CPHONE, CEMAIL, CDOB, CGENDER FROM FLIGHT2024.CUSTOMER WHERE CUSTNO=" + UserRes, conn);
                        dataTable = new DataTable();
                        dataGridView1.DataSource = dataTable;

                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                        conn.Close();
                    }
                    else
                    {
                        ErrorLbl.Text = "Please Enter Your CustomerID Number";
                    }
                }
                catch (Exception)
                {
                    ErrorLbl.Text = "Please Enter a Number.";
                }
            }
            else
            {
                ErrorLbl.Text = "Please Enter a Number.";
            }
        }
    }
}
