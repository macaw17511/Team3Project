using IBM.Data.DB2.iSeries;
using System;
using System.Data;
using System.Windows.Forms;

namespace Team3_Project
{
    public partial class FlightNumberCustomers : Form
    {
        /////////////////////////////////////
        //       IBM DB2 Connection 
        /////////////////////////////////////
        iDB2Connection conn;

        public FlightNumberCustomers()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            string flightNumber = txtFlightNumber.Text;

            if (string.IsNullOrEmpty(flightNumber))
            {
                MessageBox.Show("Please enter a flight number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conn = new iDB2Connection("Data Source=10.250.0.30");
                conn.Open();

                string cmdText = "SELECT CustomerName FROM FlightCustomers WHERE FlightNumber = @FlightNumber";

                iDB2Command cmd = new iDB2Command(cmdText, conn);

                cmd.DeriveParameters();

                cmd.Parameters["@FlightNumber"].Value = flightNumber;

                using (iDB2DataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        lstCustInfo.Items.Clear();
                        lstCustInfo.Items.Add($"Customer info for Flight: {flightNumber}");

                        while (reader.Read())
                        {
                            lstCustInfo.Items.Add(reader["CustomerName"].ToString());
                        }

                        MessageBox.Show($"Customer details for Flight {flightNumber} found.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No customers found for Flight {flightNumber}.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtFlightNumber.Clear();
        }
    }
}
