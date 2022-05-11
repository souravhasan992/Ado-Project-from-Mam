using ProjectAdo.reports;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Report2WithSqlConn();
        }
        private void Report2WithSqlConn()
        {
           string query = @"SELECT TOP (1000) em.[EmployeeID]
                  ,em.[EmployeeName]
                  ,em.[JoinDate]
                  ,em.[Gender]
                  ,em.[FilePath]
                  ,dg.[DesignationName] DesignationID
              FROM [AdoProject].[dbo].[Employee] em
              left join Designation dg on em.DesignationID=dg.DesignationID WHERE em.[EmployeeID] = " + Form1.EmployeeID;
            string connectionString = "server=DESKTOP-LA0JKO2\\SQLEXPRESS;Initial Catalog=AdoProject;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Employee");
            for (var i = 0; i < ds.Tables["Employee"].Rows.Count; i++)
            {
                if (ds.Tables["Employee"].Rows[i]["FilePath"] != null)
                {
                    if (!string.IsNullOrEmpty(ds.Tables["Employee"].Rows[i]["FilePath"].ToString()))
                    {
                        string strFilePath = Application.StartupPath + ds.Tables["Employee"].Rows[i]["FilePath"].ToString();
                        if (File.Exists(strFilePath))
                        {
                            ds.Tables["Employee"].Rows[i]["FilePath"] = strFilePath;
                        }
                    }
                }
            }

            CrystalReport1 cr2 = new CrystalReport1();
            cr2.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr2;
            con.Close();
            crystalReportViewer1.Refresh();
        }
    }
}
