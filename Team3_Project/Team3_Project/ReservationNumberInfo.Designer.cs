namespace Team3_Project
{
    partial class ReservationNumberInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelthatsnameisnotused = new System.Windows.Forms.Label();
            this.ResInputTxt = new System.Windows.Forms.TextBox();
            this.ErrorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation Number Customer Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 62);
            this.dataGridView1.TabIndex = 3;
            // 
            // labelthatsnameisnotused
            // 
            this.labelthatsnameisnotused.AutoSize = true;
            this.labelthatsnameisnotused.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelthatsnameisnotused.Location = new System.Drawing.Point(304, 352);
            this.labelthatsnameisnotused.Name = "labelthatsnameisnotused";
            this.labelthatsnameisnotused.Size = new System.Drawing.Size(195, 13);
            this.labelthatsnameisnotused.TabIndex = 4;
            this.labelthatsnameisnotused.Text = "Please Enter Your Reservation Number,";
            // 
            // ResInputTxt
            // 
            this.ResInputTxt.Location = new System.Drawing.Point(356, 368);
            this.ResInputTxt.Name = "ResInputTxt";
            this.ResInputTxt.Size = new System.Drawing.Size(100, 20);
            this.ResInputTxt.TabIndex = 5;
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.BackColor = System.Drawing.Color.Black;
            this.ErrorLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ErrorLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ErrorLbl.Location = new System.Drawing.Point(0, 0);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.ErrorLbl.TabIndex = 6;
            // 
            // ReservationNumberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.ResInputTxt);
            this.Controls.Add(this.labelthatsnameisnotused);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ReservationNumberInfo";
            this.Text = "ReservationNumberInfo";
            this.Load += new System.EventHandler(this.ReservationNumberInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelthatsnameisnotused;
        private System.Windows.Forms.TextBox ResInputTxt;
        private System.Windows.Forms.Label ErrorLbl;
    }
}
