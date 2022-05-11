
namespace ProjectAdo
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Designation = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnResetDesig = new System.Windows.Forms.Button();
            this.btnUpdateDesig = new System.Windows.Forms.Button();
            this.btnInsertDesig = new System.Windows.Forms.Button();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDesig = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pickDoB = new System.Windows.Forms.DateTimePicker();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Designation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Designation);
            this.tabControl1.Controls.Add(this.Employee);
            this.tabControl1.Location = new System.Drawing.Point(3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 443);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Designation
            // 
            this.Designation.Controls.Add(this.dataGridView1);
            this.Designation.Controls.Add(this.btnResetDesig);
            this.Designation.Controls.Add(this.btnUpdateDesig);
            this.Designation.Controls.Add(this.btnInsertDesig);
            this.Designation.Controls.Add(this.txtDesig);
            this.Designation.Controls.Add(this.label1);
            this.Designation.Location = new System.Drawing.Point(4, 22);
            this.Designation.Name = "Designation";
            this.Designation.Padding = new System.Windows.Forms.Padding(3);
            this.Designation.Size = new System.Drawing.Size(786, 417);
            this.Designation.TabIndex = 1;
            this.Designation.Text = "Designation";
            this.Designation.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Update,
            this.Remove});
            this.dataGridView1.Location = new System.Drawing.Point(73, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Update.Text = "Edt";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Text = "Delete";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // btnResetDesig
            // 
            this.btnResetDesig.Location = new System.Drawing.Point(417, 91);
            this.btnResetDesig.Name = "btnResetDesig";
            this.btnResetDesig.Size = new System.Drawing.Size(75, 23);
            this.btnResetDesig.TabIndex = 9;
            this.btnResetDesig.Text = "Reset";
            this.btnResetDesig.UseVisualStyleBackColor = true;
            this.btnResetDesig.Click += new System.EventHandler(this.btnResetDesig_Click);
            // 
            // btnUpdateDesig
            // 
            this.btnUpdateDesig.Location = new System.Drawing.Point(318, 91);
            this.btnUpdateDesig.Name = "btnUpdateDesig";
            this.btnUpdateDesig.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateDesig.TabIndex = 8;
            this.btnUpdateDesig.Text = "Update";
            this.btnUpdateDesig.UseVisualStyleBackColor = true;
            this.btnUpdateDesig.Click += new System.EventHandler(this.btnUpdateDesig_Click);
            // 
            // btnInsertDesig
            // 
            this.btnInsertDesig.Location = new System.Drawing.Point(219, 91);
            this.btnInsertDesig.Name = "btnInsertDesig";
            this.btnInsertDesig.Size = new System.Drawing.Size(75, 23);
            this.btnInsertDesig.TabIndex = 7;
            this.btnInsertDesig.Text = "Insert";
            this.btnInsertDesig.UseVisualStyleBackColor = true;
            this.btnInsertDesig.Click += new System.EventHandler(this.btnInsertDesig_Click);
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(205, 37);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(318, 20);
            this.txtDesig.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Designation:";
            // 
            // Employee
            // 
            this.Employee.Controls.Add(this.label3);
            this.Employee.Controls.Add(this.cmbDesig);
            this.Employee.Controls.Add(this.dataGridView3);
            this.Employee.Controls.Add(this.btnAdd);
            this.Employee.Controls.Add(this.btnReset);
            this.Employee.Controls.Add(this.lblFile);
            this.Employee.Controls.Add(this.btnBrowse);
            this.Employee.Controls.Add(this.pictureBox1);
            this.Employee.Controls.Add(this.pickDoB);
            this.Employee.Controls.Add(this.radioMale);
            this.Employee.Controls.Add(this.radioFemale);
            this.Employee.Controls.Add(this.textBox1);
            this.Employee.Controls.Add(this.label11);
            this.Employee.Controls.Add(this.label21);
            this.Employee.Controls.Add(this.label22);
            this.Employee.Location = new System.Drawing.Point(4, 22);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(786, 417);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Designation:";
            // 
            // cmbDesig
            // 
            this.cmbDesig.FormattingEnabled = true;
            this.cmbDesig.Location = new System.Drawing.Point(98, 128);
            this.cmbDesig.Name = "cmbDesig";
            this.cmbDesig.Size = new System.Drawing.Size(208, 21);
            this.cmbDesig.TabIndex = 36;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(350, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(430, 414);
            this.dataGridView3.TabIndex = 35;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(120, 377);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(104, 343);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(20, 13);
            this.lblFile.TabIndex = 32;
            this.lblFile.Text = "file";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(22, 333);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 31;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(68, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 144);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pickDoB
            // 
            this.pickDoB.Location = new System.Drawing.Point(98, 46);
            this.pickDoB.Name = "pickDoB";
            this.pickDoB.Size = new System.Drawing.Size(208, 20);
            this.pickDoB.TabIndex = 21;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(252, 95);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 20;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(99, 93);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 19;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Gender:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Date of Birth:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "Employee Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Designation.ResumeLayout(false);
            this.Designation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Employee.ResumeLayout(false);
            this.Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Designation;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker pickDoB;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnResetDesig;
        private System.Windows.Forms.Button btnUpdateDesig;
        private System.Windows.Forms.Button btnInsertDesig;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.ComboBox cmbDesig;
        private System.Windows.Forms.Label label3;
    }
}

