using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var ef = new WFC2109I2Entities())
            {
                bindingSource1.DataSource = ef.Students.ToList();
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

                txtId.DataBindings.Add("Text", bindingSource1, "Id", true,
                    DataSourceUpdateMode.OnPropertyChanged);

                txtFirstName.DataBindings.Add("Text", bindingSource1, "FirstName", true, 
                    DataSourceUpdateMode.OnPropertyChanged);

                txtLastName.DataBindings.Add("Text", bindingSource1, "LastName", true,
                    DataSourceUpdateMode.OnPropertyChanged);

                checkBox1.DataBindings.Add("checked", bindingSource1, "Gender", true,
                   DataSourceUpdateMode.OnPropertyChanged);

                dateTimePicker1.DataBindings.Add("value", bindingSource1, "Dob", true,
                   DataSourceUpdateMode.OnPropertyChanged);
                //dataGridView1.DataSource = ef.Students.ToList();
                //dataGridView1.DataSource = ef.Students
                //    .Select(stu => new
                //    {
                //        stu.Id, stu.FirstName, stu.LastName
                //    }).ToList();
            }
            //WFC2109I2Entities t = new WFC2109I2Entities();
            //dataGridView1.DataSource = t.Students.ToList();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var ef = new WFC2109I2Entities())
            {
                var findId = Convert.ToInt32(txtId.Text);

                var obj = await ef.Students.FirstOrDefaultAsync(stu => stu.Id == findId);

                if(obj != null)
                {
                    obj.FirstName = txtFirstName.Text;
                    obj.LastName = txtLastName.Text;
                    obj.Gender = checkBox1.Checked;
                    obj.Dob = dateTimePicker1.Value;
                }
                
                await ef.SaveChangesAsync();
                bindingSource1.DataSource = await ef.Students.ToListAsync();
                MessageBox.Show("Đc của ló", "infor");
            }
        }

        private async void Add_Click(object sender, EventArgs e)
        {
            using(var ef = new WFC2109I2Entities())
            {
                var stu = new Student();
                stu.FirstName = txtFirstName.Text;
                stu.LastName = txtLastName.Text;
                stu.Gender = checkBox1.Checked;
                stu.Dob = dateTimePicker1.Value;
                ef.Students.Add(stu);
                await ef.SaveChangesAsync();

                bindingSource1.DataSource = await ef.Students.ToListAsync();
                MessageBox.Show("ok nhá", "infor");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            using (var ef = new WFC2109I2Entities())
            {
                var findId = Convert.ToInt32(txtId.Text);

                foreach (var stu in ef.Students)
                {
                    if (stu.Id == findId)
                    {
                        ef.Students.Remove(stu);
                    }
                }

                await ef.SaveChangesAsync();

                bindingSource1.DataSource = await ef.Students.ToListAsync();
                MessageBox.Show("Đã cút", "infor");
            }
        }
    }
}
