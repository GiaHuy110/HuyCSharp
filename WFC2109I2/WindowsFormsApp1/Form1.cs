using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ado.net
        SqlConnection con = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        private void Form_Load(object sender, EventArgs e)
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["giahuy"].ConnectionString;
            command.Connection = con;
            command.CommandText = "select * from Student; select Id, FirstName from Student";
            command.CommandType = CommandType.Text;
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            //bidingSource1.DataSource = ds.Tables[0];
            //dataGridView1.DataSource = bidingSource1;
            //bidingNavigator1.BidingSource = bidingSource1;
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        private void toolStripTextBox1_TextChan(object sender, EventArgs e)
        {
            // ds.Tables[0].DefaultView = select * from Sudent
            // RowFilter = where
            // 
            ds.Tables[0].DefaultView.RowFilter = $"FirstName like'%{toolStripTextBox1.Text}%'";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
