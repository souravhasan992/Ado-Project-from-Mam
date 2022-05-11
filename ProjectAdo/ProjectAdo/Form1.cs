using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAdo
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapt = null;
        public static int EmployeeID = 0;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=DESKTOP-LA0JKO2\\SQLEXPRESS;Initial Catalog=AdoProject;Integrated Security=True");
            AddButtonColumn();
            LoadEmp();
            ResetEmployee();
        }
        int designationid = 0;
        public DataTable GetDesignations()
        {
            DataSet dsData = new DataSet();
            {
                con.Open();
                string query = "SELECT [DesignationID],[DesignationName] FROM [Designation]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dsData);
                con.Close();
                return dsData.Tables[0];
            }
        }
        private void ResetDesignation()
        {
            btnInsertDesig.Show();
            btnUpdateDesig.Hide();
            txtDesig.Text = "";
            dataGridView1.DataSource = GetDesignations();
            designationid = 0;
            string q = "SELECT e.[EmployeeID],e.[EmployeeName],d.[DesignationName] FROM [Employee] e JOIN [Designation] d ON e.DesignationID = d.DesignationID";
            //SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Employee");
            //CrystalReport1 cr1 = new CrystalReport1();
            //cr1.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = cr1;
            //conn.Close();
            //crystalReportViewer1.Refresh();
        }
        private void btnInsertDesig_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = null;
            con.Open();
            string insertQ = "INSERT INTO [Designation]([DesignationName]) VALUES('" + txtDesig.Text.Trim() + "')";
            cmd = new SqlCommand(insertQ, con);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("INSERT Perform Succesfully.");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
            con.Close();

            ResetDesignation();
       }
        private void btnUpdateDesig_Click(object sender, EventArgs e)
        {
            string selectQ = "SELECT [DesignationID],[DesignationName] FROM [Designation] WHERE [DesignationID] = " + designationid;
            SqlCommand cmd = new SqlCommand(selectQ, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    designationid = Convert.ToInt32(reader["DesignationID"]);
                }
                reader.Close();
                string updateQ = "UPDATE [Designation] SET [DesignationName] = '" + txtDesig.Text.Trim() + "' WHERE [DesignationID] = " + designationid;
                cmd = new SqlCommand(updateQ, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("UPDATE Perform Succesfully.");
                }
                else
                {
                    MessageBox.Show("Operation failed.");
                }
            }
            else
            {
                MessageBox.Show("No data found.");
            }
            con.Close();
            ResetDesignation();
        }
        private void btnResetDesig_Click(object sender, EventArgs e)
        {
          ResetDesignation();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) // edit button
            {
                btnInsertDesig.Hide();
                btnUpdateDesig.Show();
                string DesignationID = dataGridView1.Rows[e.RowIndex].Cells["DesignationID"].Value.ToString();
                string DesignationName = dataGridView1.Rows[e.RowIndex].Cells["DesignationName"].Value.ToString();
                Int32.TryParse(DesignationID, out designationid);
                txtDesig.Text = DesignationName;
            }

            if (e.ColumnIndex == 1) // delete button
            {
                string DesignationID = dataGridView1.Rows[e.RowIndex].Cells["DesignationID"].Value.ToString();
                string DesignationName = dataGridView1.Rows[e.RowIndex].Cells["DesignationName"].Value.ToString();
                Int32.TryParse(DesignationID, out designationid);

                // example of connected architechture
                if (MessageBox.Show("Are you sure to delete '" + DesignationName + "'", "Delete confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string selectQ = "SELECT [DesignationID],[DesignationName] FROM [Designation] WHERE [DesignationID] = " + designationid;
                    SqlCommand cmd = new SqlCommand(selectQ, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            designationid = Convert.ToInt32(reader["DesignationID"]);
                        }
                        reader.Close();

                        string deleteQ = "DELETE FROM [Designation] WHERE [DesignationID] = " + designationid;
                        cmd = new SqlCommand(deleteQ, con);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("DELETE Perform Succesfully.");
                        }
                        else
                        {
                            MessageBox.Show("Operation failed.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data found.");
                    }
                 con.Close();
                 ResetDesignation();
               }
           }
        }
        private void ResetEmployee()
        {
            EmployeeID = 0;
            btnAdd.Text = "Add";
            newFilePath = "";
            pictureBox1.Image = null;
            using (var img = new Bitmap(Application.StartupPath + "\\images\\default_img.png"))
            {
                pictureBox1.Image = new Bitmap(img);
                lblFile.Text = "\\images\\default_img.png";
            }
            textBox1.Text = "";
            pickDoB.Text = "";
            radioFemale.Checked = true;
            cmbDesig.Text = "";
        }
      private void btnReset_Click(object sender, EventArgs e)
        {
            ResetEmployee();
        }
        private void FillCmbDesignation()
        {
            var designations = GetDesignations();
            cmbDesig.DataSource = designations;
            cmbDesig.DisplayMember = "DesignationName";
            cmbDesig.ValueMember = "DesignationID";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetDesignation();
            ResetEmployee();
            FillCmbDesignation();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectFile();
        }
        private void SelectFile()
        {
            open.Filter = "JPG (*.JPG)|*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (var img = new Bitmap(open.FileName))
                {
                    pictureBox1.Image = new Bitmap(img);
                }
                // image file path
                newFilePath = open.FileName;
                isNewFile = true;
            }
        }
        string newFilePath = string.Empty;
        string oldFilePath = string.Empty;
        bool isNewFile = true;
        OpenFileDialog open = new OpenFileDialog();
        private string AddFile()
        {
            string strFilePath = string.Empty;
            if (isNewFile)
            {
                strFilePath = "\\images\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                //pictureBox1.Image.Save(Application.StartupPath + strFilePath);
                File.Copy(newFilePath, Application.StartupPath + strFilePath);
            }

            return strFilePath;
        }
        private void AddButtonColumn()
        {
            DataGridViewButtonColumn btnReport = new DataGridViewButtonColumn();
            btnReport.HeaderText = "#";
            btnReport.Text = "Report";
            btnReport.Name = "btnReport";
            btnReport.UseColumnTextForButtonValue = true;
            dataGridView3.Columns.Add(btnReport);

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "#";
            btnEdit.Text = "Edit";
            btnEdit.Name = "btnEdit";
            btnEdit.UseColumnTextForButtonValue = true;
            dataGridView3.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "#";
            btnDelete.Text = "Delete";
            btnDelete.Name = "btnDelete";
            btnDelete.UseColumnTextForButtonValue = true;
            dataGridView3.Columns.Add(btnDelete);
        }
        private string UpdateFile()
        {
            string strFilePath = string.Empty;
            if (isNewFile)
            {
                strFilePath = "\\images\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
                //pictureBox1.Image.Save(Application.StartupPath + strFilePath);
                File.Copy(newFilePath, Application.StartupPath + strFilePath);

                //remove old file
                RemoveFile(Application.StartupPath + oldFilePath);
            }
            else
            {
                strFilePath = oldFilePath;
            }

            return strFilePath;
        }

        private void RemoveFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                if (!filePath.Contains("default"))
                {
                    File.Delete(filePath);
                }
                pictureBox1.Image = null;
            }
        }
        private void LoadEmp()
        {
            con.Open();
            DataTable dt = new DataTable();     
            string query = @"SELECT e.[EmployeeID],e.[EmployeeName],e.[JoinDate],e.[Gender],e.[FilePath],d.[DesignationName] FROM [Employee] e JOIN [Designation] d ON e.DesignationID = d.DesignationID";
            adapt = new SqlDataAdapter(query, con);
            adapt.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
        }
        private void AddNew()
        {
            // save image
            string strFilePath = AddFile();
            string query = @"INSERT INTO [dbo].[Employee]
                ([EmployeeName]
               ,[JoinDate]
               ,[Gender]
               ,[FilePath]
               ,[DesignationID])
                VALUES
               (@EmployeeName
               ,@JoinDate
               ,@Gender
               ,@FilePath
               ,@DesignationID)";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@EmployeeName", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@JoinDate", pickDoB.Value);
            cmd.Parameters.AddWithValue("@Gender", radioFemale.Checked == true ? "Female" : "Male");
            cmd.Parameters.AddWithValue("@FilePath", strFilePath);
            cmd.Parameters.AddWithValue("@DesignationID", cmbDesig.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data added successfully.");
        }
        private void Updates()
        {
            // save image
            string strFilePath = UpdateFile();

            cmd = new SqlCommand(@"UPDATE [Employee]
               SET [EmployeeName] = @EmployeeName
                  ,[JoinDate] = @JoinDate
                  ,[Gender] = @Gender
                  ,[FilePath] = @FilePath
                  ,[DesignationID] = @DesignationID
             WHERE [EmployeeID] = @EmployeeID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.Parameters.AddWithValue("@EmployeeName", textBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@JoinDate", pickDoB.Value);
            cmd.Parameters.AddWithValue("@Gender", radioFemale.Checked == true ? "Female" : "Male");
            cmd.Parameters.AddWithValue("@FilePath", strFilePath);
            cmd.Parameters.AddWithValue("@DesignationID", cmbDesig.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data updated successfully.");
        }
        private void Edit()
        {
            con.Open();
            DataTable dt = new DataTable();
            string query = @"SELECT [EmployeeID]
                  ,[EmployeeName]
                  ,[JoinDate]
                  ,[Gender]
                  ,[FilePath]
                  ,[DesignationID]
              FROM [Employee] WHERE [EmployeeID] = " + EmployeeID;
            adapt = new SqlDataAdapter(query, con);
            adapt.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                btnAdd.Text = "Update";

                EmployeeID = Convert.ToInt32(dt.Rows[0]["EmployeeID"].ToString());
                textBox1.Text = dt.Rows[0]["EmployeeName"].ToString();
                pickDoB.Value = Convert.ToDateTime(dt.Rows[0]["JoinDate"].ToString());
                radioFemale.Checked = dt.Rows[0]["Gender"].ToString() == "Female" ? true : false;
                radioMale.Checked = dt.Rows[0]["Gender"].ToString() == "Female" ? false : true;
                // set image
                if (dt.Rows[0]["FilePath"].ToString() != null)
                {
                    if (File.Exists(Application.StartupPath + dt.Rows[0]["FilePath"].ToString()))
                    {
                        using (var img = new Bitmap(Application.StartupPath + dt.Rows[0]["FilePath"].ToString()))
                        {
                            pictureBox1.Image = new Bitmap(img);
                            lblFile.Text = dt.Rows[0]["FilePath"].ToString();
                            isNewFile = false;
                            oldFilePath = dt.Rows[0]["FilePath"].ToString();
                        }
                    }
                    else
                    {
                        using (var img = new Bitmap(Application.StartupPath + "\\images\\default_img.png"))
                        {
                            pictureBox1.Image = new Bitmap(img);
                            lblFile.Text = "\\images\\default_img.png";
                        }
                    }
                }
                else
                {
                    using (var img = new Bitmap(Application.StartupPath + "\\images\\default_img.png"))
                    {
                        pictureBox1.Image = new Bitmap(img);
                        lblFile.Text = "\\images\\default_img.png";
                    }
                }
                cmbDesig.SelectedValue = dt.Rows[0]["DesignationID"].ToString();
            }
        }
        private void Delete()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove?", "Confirm Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                con.Open();
                DataTable dt = new DataTable();
                string query = @"SELECT [EmployeeID]
                      ,[EmployeeName]
                      ,[JoinDate]
                      ,[Gender]
                      ,[FilePath]
                      ,[DesignationID]
                  FROM [Employee] WHERE [EmployeeID] = " + EmployeeID;
                adapt = new SqlDataAdapter(query, con);
                adapt.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["FilePath"] != null)
                    {
                        // remove old file
                        RemoveFile(Application.StartupPath + dt.Rows[0]["FilePath"].ToString());
                    }

                    string q = @"DELETE FROM [Employee]
                    WHERE EmployeeID = @EmployeeID";
                    cmd = new SqlCommand(q, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ResetEmployee();
                    LoadEmp();
                    MessageBox.Show("Data removed successfully.");

                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (EmployeeID > 0)
            {
               Updates();
            }
            else
            {
                AddNew();
            }
            ResetEmployee();
            LoadEmp();
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && dataGridView3.Rows.Count > e.RowIndex + 1)
            {
                var v = dataGridView3.Rows[e.RowIndex].Cells["EmployeeID"].Value;
                EmployeeID = dataGridView3.Rows[e.RowIndex].Cells["EmployeeID"].Value == null ? 0 : Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                if ("Report" == dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                }
                if ("Edit" == dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
                {
                    Edit();
                }
                if ("Delete" == dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
                {
                    Delete();
                }
            }
        }
    }
}
