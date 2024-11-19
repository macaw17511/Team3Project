namespace Team3_Project
{
    partial class FlightNumberSeats
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
            this.lstSeatInfo = new System.Windows.Forms.ListBox();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flight Number Seats";
            // 
            // lstSeatInfo
            // 
            this.lstSeatInfo.BackColor = System.Drawing.SystemColors.Desktop;
            this.lstSeatInfo.ForeColor = System.Drawing.Color.Lime;
            this.lstSeatInfo.FormattingEnabled = true;
            this.lstSeatInfo.Location = new System.Drawing.Point(400, 106);
            this.lstSeatInfo.Name = "lstSeatInfo";
            this.lstSeatInfo.Size = new System.Drawing.Size(376, 303);
            this.lstSeatInfo.TabIndex = 2;
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(42, 106);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(175, 20);
            this.txtFlightNumber.TabIndex = 5;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(264, 106);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(75, 23);
            this.btnShowInfo.TabIndex = 6;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            // 
            // FlightNumberSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.lstSeatInfo);
            this.Controls.Add(this.label1);
            this.Name = "FlightNumberSeats";
            this.Text = "FlightNumberSeats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSeatInfo;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Button btnShowInfo;
    }
}
