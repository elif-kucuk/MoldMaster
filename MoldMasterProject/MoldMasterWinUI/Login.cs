using MoldMasterBLL;
using MoldMasterDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoldMasterWinUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BaseRepository<Employee> employee = new BaseRepository<Employee>();
        Employee worker = new Employee();
        private void Login_Load(object sender, EventArgs e)
        {
            if (employee.SelectAll().Count>0)
            {
                dataGridView1.DataSource = employee.SelectAll();
            }

            cmb_title.DataSource = employee.SelectAll();
            cmb_title.DisplayMember = "Department";
            cmb_title.ValueMember = "ID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            worker.EmployeeName = txt_Ad.Text;
            worker.EmployeeSurname = txt_Soyad.Text;
            worker.Password = txt_password.Text;
            HomePage homePage = new HomePage(worker);
            homePage.Show();
            this.Hide();

        
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            worker.EmployeeName = txt_Ad.Text;
            worker.EmployeeSurname = txt_Soyad.Text;
            worker.Department = cmb_title.Text;
            worker.Password = txt_password.Text;
            employee.Insert(worker);
            dataGridView1.DataSource = employee.SelectAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Soyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }
    }
}
