namespace Team3_Project
{
    partial class AddCountry
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAbbreviation = new System.Windows.Forms.TextBox();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IBM Plex Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IBM Plex Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(165, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Country Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IBM Plex Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(152, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Country Abbr.";
            // 
            // textAbbreviation
            // 
            this.textAbbreviation.BackColor = System.Drawing.SystemColors.MenuText;
            this.textAbbreviation.Font = new System.Drawing.Font("IBM Plex Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAbbreviation.ForeColor = System.Drawing.Color.Green;
            this.textAbbreviation.Location = new System.Drawing.Point(352, 209);
            this.textAbbreviation.Margin = new System.Windows.Forms.Padding(2);
            this.textAbbreviation.MaxLength = 2;
            this.textAbbreviation.Name = "textAbbreviation";
            this.textAbbreviation.Size = new System.Drawing.Size(198, 32);
            this.textAbbreviation.TabIndex = 22;
            this.textAbbreviation.Text = "cn";
            // 
            // textCountry
            // 
            this.textCountry.BackColor = System.Drawing.SystemColors.MenuText;
            this.textCountry.Font = new System.Drawing.Font("IBM Plex Mono", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCountry.ForeColor = System.Drawing.Color.Green;
            this.textCountry.Location = new System.Drawing.Point(352, 173);
            this.textCountry.Margin = new System.Windows.Forms.Padding(2);
            this.textCountry.MaxLength = 35;
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(198, 32);
            this.textCountry.TabIndex = 25;
            this.textCountry.Text = "country";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Black;
            this.buttonSubmit.Font = new System.Drawing.Font("IBM Plex Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSubmit.Location = new System.Drawing.Point(299, 317);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(121, 46);
            this.buttonSubmit.TabIndex = 31;
            this.buttonSubmit.Text = "SUBMIT";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("IBM Plex Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Green;
            this.labelError.Location = new System.Drawing.Point(11, 412);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 29);
            this.labelError.TabIndex = 32;
            // 
            // AddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textCountry);
            this.Controls.Add(this.textAbbreviation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCountry";
            this.Text = "AddCountry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAbbreviation;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelError;
    }
}
