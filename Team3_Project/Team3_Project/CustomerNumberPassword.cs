using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// user enters a Customer Number and returns the customer's password

namespace Team3_Project
{
    public partial class CustomerNumberPassword : Form
    {

        /////////////////////////////////////
        //       IBM DB2 Connection 
        /////////////////////////////////////

        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataTable dataTable;

        public CustomerNumberPassword()
        {
            InitializeComponent();
        }

        private void CustomerNumberPassword_Load(object sender, EventArgs e)
        {
        }

        private void searchIDBtn_Click(object sender, EventArgs e)
        {
            string UseID = IDInputTxt.Text;

            //Make sure Id Input is within Perameters.
            if (UseID != "")
            {
                try
                {
                    int UseIDNum = Int32.Parse(UseID);
                    if (UseIDNum > 0 && UseIDNum < 500) //replace later
                    {
                        ErrorLbl.Text = "Wow! It works!";
                        // The idea of having the connection call here is so the User can try to check multiple IDs.
                        

                        // SELECT [Columns] FROM [Table] WHERE [Columns]=[Desired Num]
                        conn = new iDB2Connection("Data Source=10.250.0.30");
                        adapter = new iDB2DataAdapter("SELECT CPWORD FROM FLIGHT2024.CUSTOMER WHERE CUSTNO=" + UseID, conn);
                        dataTable = new DataTable();
                        dataGridView1.DataSource = dataTable;

                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        dataGridView1.GridColor = Color.Black;
                        conn.Close();
                    }
                    else
                    {
                        ErrorLbl.Text = "Please Enter Your CustomerID Number";
                    }
                }
                catch
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
