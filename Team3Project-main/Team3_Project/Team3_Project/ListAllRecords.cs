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

// list all records in the RESHIST table

namespace Team3_Project
{
    public partial class ListAllRecords : Form
    {

        /////////////////////////////////////
        //       IBM DB2 Connection 
        /////////////////////////////////////

        iDB2Connection  conn;
        iDB2DataAdapter adapter;
        DataTable       dataTable;


        public ListAllRecords()
        {
            InitializeComponent();
        }

        private void ListAllRecords_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////
            // Get Data with SQl and into Table
            /////////////////////////////////////

            conn    = new iDB2Connection("Data Source=10.250.0.30");
            adapter = new iDB2DataAdapter("SELECT * FROM FLIGHT2024.RESHIST", conn);

            dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            dataGridView1.GridColor = Color.Black;

            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            conn.Close();
        }
    }
}
