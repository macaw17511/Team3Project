namespace Team3_Project
{
    partial class CustomerNumberPassword
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorksLT2016DataSet = new Team3_Project.AdventureWorksLT2016DataSet();
            this.customerTableAdapter = new Team3_Project.AdventureWorksLT2016DataSetTableAdapters.CustomerTableAdapter();
            this.searchIDBtn = new System.Windows.Forms.Button();
            this.IDInputTxt = new System.Windows.Forms.TextBox();
            this.customerIDtxt = new Team3_Project.AdventureWorksLT2016DataSetTableAdapters.CustomerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2016DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Number Password";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 44);
            this.dataGridView1.TabIndex = 2;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.adventureWorksLT2016DataSet;
            // 
            // adventureWorksLT2016DataSet
            // 
            this.adventureWorksLT2016DataSet.DataSetName = "AdventureWorksLT2016DataSet";
            this.adventureWorksLT2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // searchIDBtn
            // 
            this.searchIDBtn.Location = new System.Drawing.Point(367, 403);
            this.searchIDBtn.Name = "searchIDBtn";
            this.searchIDBtn.Size = new System.Drawing.Size(75, 23);
            this.searchIDBtn.TabIndex = 3;
            this.searchIDBtn.Text = "Search";
            this.searchIDBtn.UseVisualStyleBackColor = true;
            this.searchIDBtn.Click += new System.EventHandler(this.searchIDBtn_Click);
            // 
            // IDInputTxt
            // 
            this.IDInputTxt.Location = new System.Drawing.Point(354, 377);
            this.IDInputTxt.Name = "IDInputTxt";
            this.IDInputTxt.Size = new System.Drawing.Size(100, 20);
            this.IDInputTxt.TabIndex = 4;
            // 
            // customerIDtxt
            // 
            this.customerIDtxt.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(259, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input ID to Find Your Password. Must be between 1 and .";
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ErrorLbl.Location = new System.Drawing.Point(0, 0);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.ErrorLbl.TabIndex = 6;
            this.ErrorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerNumberPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDInputTxt);
            this.Controls.Add(this.searchIDBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerNumberPassword";
            this.Text = "CustomerNumberPassword";
            this.Load += new System.EventHandler(this.CustomerNumberPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2016DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdventureWorksLT2016DataSet adventureWorksLT2016DataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AdventureWorksLT2016DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button searchIDBtn;
        private System.Windows.Forms.TextBox IDInputTxt;
        private AdventureWorksLT2016DataSetTableAdapters.CustomerTableAdapter customerIDtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorLbl;
    }
}