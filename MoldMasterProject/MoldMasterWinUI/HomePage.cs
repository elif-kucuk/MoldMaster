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
    public partial class HomePage : Form
    {
        public HomePage(Employee logged)
        {
            InitializeComponent();
            label1.Text = "Welcome " + logged.EmployeeName + " " + logged.EmployeeSurname;
        }
        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width;
            this.Height = _childForm.Height;

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

    
        private void HomePage_Load(object sender, EventArgs e)
        {
            ChildForm(new WorkCenterForm());
        }

       

        private void WorkCenter_Click_1(object sender, EventArgs e)
        {
            ChildForm(new WorkCenterForm());

        }

        private void MoldType_Click(object sender, EventArgs e)
        {
            ChildForm(new MoldTypeForm());
        }

        private void moldTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new MoldTransferForm());
        }
    }

      
    
}
