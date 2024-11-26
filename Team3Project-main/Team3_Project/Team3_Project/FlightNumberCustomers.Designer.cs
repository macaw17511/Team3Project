namespace Team3_Project
{
    partial class FlightNumberCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstCustInfo = new System.Windows.Forms.ListBox();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flight Number Customers";
            // 
            // lstCustInfo
            // 
            this.lstCustInfo.BackColor = System.Drawing.SystemColors.Desktop;
            this.lstCustInfo.ForeColor = System.Drawing.Color.Lime;
            this.lstCustInfo.FormattingEnabled = true;
            this.lstCustInfo.Location = new System.Drawing.Point(412, 82);
            this.lstCustInfo.Name = "lstCustInfo";
            this.lstCustInfo.Size = new System.Drawing.Size(376, 342);
            this.lstCustInfo.TabIndex = 3;
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(32, 82);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(175, 20);
            this.txtFlightNumber.TabIndex = 4;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(258, 82);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(75, 23);
            this.btnShowInfo.TabIndex = 5;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            // 
            // FlightNumberCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.lstCustInfo);
            this.Controls.Add(this.label1);
            this.Name = "FlightNumberCustomers";
            this.Text = "FlightNumberCustomers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCustInfo;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Button btnShowCustNmbr;
        private System.Windows.Forms.Button btnShowInfo;
        // private System.Windows.Forms.Button btnSearchSeats;
    }
}
