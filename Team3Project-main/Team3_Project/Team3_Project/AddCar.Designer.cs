namespace Team3_Project
{
    partial class AddCar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a Car";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(264, 99);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(363, 251);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(88, 151);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 4;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(88, 177);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(88, 203);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 6;
            // 
            // addCarButton
            // 
            this.addCarButton.BackColor = System.Drawing.Color.Black;
            this.addCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarButton.Location = new System.Drawing.Point(88, 99);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(105, 38);
            this.addCarButton.TabIndex = 11;
            this.addCarButton.Text = "Add a Car";
            this.addCarButton.UseVisualStyleBackColor = false;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Make:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Model:";
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}