using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
// https://www.c-sharpcorner.com/UploadFile/deepak.sharma00/how-to-write-data-of-an-sql-server-table-to-an-xml-file-usin/
namespace DataTable2XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

            DataTable dt = new DataTable("MyData");
            using (SqlConnection con = new SqlConnection(cs))
            {
                string cmdText = "Select * from Orders";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 60;
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    dt.WriteXml("Data.xml");
                    //var rs = cmd.ExecuteReader();
                    //if (rs.HasRows)
                    //{
                    //    while (rs.Read())
                    //    {
                    //        int columnsCount = rs.FieldCount;
                    //        for (int i = 0; i < columnsCount; i++)
                    //        {
                    //            var data = rs[i].ToString();
                    //        }

                    //    }
                    //}
                }
            }
            MessageBox.Show("Done","XML Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
