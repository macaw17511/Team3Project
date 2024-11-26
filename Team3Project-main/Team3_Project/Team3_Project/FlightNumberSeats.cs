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
            string seatNumber = txtSeatNumber.Text;

            if (string.IsNullOrEmpty(seatNumber))
            {
                MessageBox.Show("Please enter a seat number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn = new iDB2Connection("Data Source=10.250.0.30");
                conn.Open();

                string cmdText = "SELECT CustomerName FROM SeatCustomers WHERE SeatNumber = @SeatNumber";

                iDB2Command cmd = new iDB2Command(cmdText, conn);

                cmd.DeriveParameters();

                cmd.Parameters["@SeatNumber"].Value = seatNumber;

                using (iDB2DataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        lstSeatInfo.Items.Clear();
                        lstSeatInfo.Items.Add($"Customer info for Seat: {seatNumber}");

                        while (reader.Read())
                        {
                            lstSeatInfo.Items.Add(reader["CustomerName"].ToString());
                        }

                        MessageBox.Show($"Customer details for Seat {seatNumber} found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No customers found for Seat {seatNumber}.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
            txtSeatNumber.Clear();
        }
    }
}
    


