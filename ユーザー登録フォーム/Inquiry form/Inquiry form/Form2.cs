using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Inquiry_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        private DataSet Loginbtn_Click(object sender, EventArgs e)
        {
            DataSet dsResult = new DataSet();

            SqlConnection sqlCon = null;
            SqlTransaction sqlTran = null;
            SqlCommand sqlCommand = null;
            SqlDataAdapter dataAdapter = null;
            DataSet dsData = new DataSet();

            sqlCon = new SqlConnection();

            sqlCon.ConnectionString = "Server=Datebase1.mdf; Database=Table; User ID=ABC;Password=a12;";
            sqlCon.Open();

            sqlTran = sqlCon.BeginTransaction();
            sqlCommand = new SqlCommand(sql, sqlCon, sqlTran);
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dsData, tableName);

            sqlTran.Commit();
            dataAdapter.Dispose();
            sqlCommand.Dispose();
            sqlCon.Close();

            return dsData;
            //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\hirum\Desktop\Animals.mdb")
            //OleDbCommand SQLCm = Cn.CreateCommand;
            //OleDbDataAdapter Adapter = new OleDbDataAdapter(SQLCm);
            //DataTable Table = new DataTable();

            //SQLCm.CommandText = "SELECT 説明 FROM T_目マスタ";
            //Adapter.Fill(Table);

            //// ▼値の表示
            //dataGridView1.DataSource = Table;

            //// ▼後処理
            //Table.Dispose();
            //Adapter.Dispose();
            //SQLCm.Dispose();
            //Cn.Dispose();

            //DataTable dataTable = new DataTable();

            //string sql = "SELECT * FROM Table WHERE [USER_NAME] = " + "'" + usernametxt.Text + "'" + " AND [PASSWORD] = " + "'" + passwordtxt.Text + "'";

            //using (SqlConnection conn = new SqlConnection(constr))
            //{
            //    using (SqlCommand cmd = new SqlCommand(sql, conn))
            //    {
            //        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            //        {
            //            adapter.Fill(dataTable);
            //            int rowcount = dataTable.Rows.Count;

            //            if (rowcount == 1)
            //            {
            //                MessageBox.Show("ログイン成功", "認証結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }
            //            else
            //            {
            //                MessageBox.Show("ログイン失敗", "認証結果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //        }
            //    }
            //}
        }
    }
}
