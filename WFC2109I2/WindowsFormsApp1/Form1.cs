using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void BtnClick_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("em ăn cơm chưa","xin chào cr",MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("con me may");
            }
        }
    }
}
