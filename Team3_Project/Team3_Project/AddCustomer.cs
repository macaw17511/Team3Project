using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// form to add a customer

// Dylan Bradley

namespace Team3_Project
{
    public partial class AddCustomer : Form
    {

        /////////////////////////////////////
        //       IBM DB2 Connection 
        /////////////////////////////////////

        iDB2Connection  conn;
        iDB2DataAdapter adapter;
        DataSet         dataset;


        public AddCustomer()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////
            //          Input Variables
            ///////////////////////////////////////

            double CustomerNumber = Convert.ToDouble(textCustNo.Text);
            string FirstName      = textFirstName.Text;
            string LastName       = textLastName.Text;
            string Address        = textAddress.Text;
            string City           = textCity.Text;
            string State          = textState.Text;
            double ZipCode        = Convert.ToDouble(textZip.Text);
            double PhoneNumber    = Convert.ToDouble(textPhone.Text);
            string Email          = textEmail.Text;
            double DateOfBirth    = Convert.ToDouble(textDOB.Text);
            string Gender         = textGender.Text;
            string Password       = textPassword.Text;
            string CreditCardNo   = textCreditCard.Text;
            double PaymentTotal   = Convert.ToDouble(textPayments.Text);
            string PassHash       = "1234"; 



            ///////////////////////////////////////
            //           SQL Statement
            ///////////////////////////////////////

            string cmdText = "INSERT INTO FLIGHT2024.CUSTOMER VALUES(@CUSTNO, @FNAME, @LNAME, " +
                               "@ADDRESS, @CITY, @STATE, @ZIP, @PHONE, @EMAIL, @DOB, @GENDER, " +
                               "@PASSWORD, @CCNO, @PAYMENT, @PASSHASH)";


            try
            {

                conn = new iDB2Connection("Data Source=10.250.0.30");
                conn.Open();

                iDB2Command cmd = new iDB2Command(cmdText, conn);
                cmd.DeriveParameters();     

                cmd.Parameters["@CUSTNO"].Value   = CustomerNumber;
                cmd.Parameters["@FNAME"].Value    = FirstName;
                cmd.Parameters["@LNAME"].Value    = LastName;
                cmd.Parameters["@ADDRESS"].Value  = Address;
                cmd.Parameters["@CITY"].Value     = City;
                cmd.Parameters["@STATE"].Value    = State;
                cmd.Parameters["@ZIP"].Value      = ZipCode;
                cmd.Parameters["@PHONE"].Value    = PhoneNumber;
                cmd.Parameters["@EMAIL"].Value    = Email;
                cmd.Parameters["@DOB"].Value      = DateOfBirth;
                cmd.Parameters["@GENDER"].Value   = Gender;
                cmd.Parameters["@PASSWORD"].Value = Password;
                cmd.Parameters["@CCNO"].Value     = CreditCardNo;
                cmd.Parameters["@PAYMENT"].Value  = PaymentTotal;
                cmd.Parameters["@PASSHASH"].Value = PassHash;

                cmd.ExecuteNonQuery();

                conn.Close();

                labelError.Text = "SUCCESSFULLY ADDED TO DATABASE";
            }
            catch(Exception ex)
            {
                labelError.Text = ex.Message;
            }

            
            
            
        }
    }
}
