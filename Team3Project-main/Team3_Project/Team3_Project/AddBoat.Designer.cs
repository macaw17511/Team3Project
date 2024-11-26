namespace Team3_Project
{
    partial class AddBoat
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addBoatButton = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(276, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a Boat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(109, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Make:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(114, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Year:";
            // 
            // addBoatButton
            // 
            this.addBoatButton.BackColor = System.Drawing.Color.Black;
            this.addBoatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBoatButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addBoatButton.Location = new System.Drawing.Point(152, 100);
            this.addBoatButton.Name = "addBoatButton";
            this.addBoatButton.Size = new System.Drawing.Size(105, 38);
            this.addBoatButton.TabIndex = 19;
            this.addBoatButton.Text = "Add a Boat";
            this.addBoatButton.UseVisualStyleBackColor = false;
            this.addBoatButton.Click += new System.EventHandler(this.addBoatButton_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(152, 204);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 18;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(152, 178);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 17;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(152, 152);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 16;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(328, 100);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(363, 251);
            this.listBox2.TabIndex = 15;
            // 
            // AddBoat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addBoatButton);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Name = "AddBoat";
            this.Text = "AddBoat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBoatButton;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ListBox listBox2;
    }
}