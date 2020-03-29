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
    public partial class WorkCenterForm : Form
    {
        public WorkCenterForm()
        {
            InitializeComponent();
        }
        BaseRepository<WorkCenter> workCenter = new BaseRepository<WorkCenter>();
        WorkCenter work = new WorkCenter();
        private void WorkCenterForm_Load(object sender, EventArgs e)
        {
            if (workCenter.SelectAll().Count>0)
            {
                dataGridView1.DataSource = workCenter.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            work.Code = txt_code.Text;
            work.Description = txt_description.Text;
            work.SupplierName = txt_name.Text;
            work.IsOutsource =Convert.ToInt32( txt_Source.Text);
            workCenter.Insert(work);
           dataGridView1.DataSource= workCenter.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            work.ID =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            workCenter.Delete(work.ID);
            dataGridView1.DataSource = workCenter.SelectAll();
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var guncelleme = workCenter.SelectedById(id);
            guncelleme.Code = txt_code.Text;
            guncelleme.Description = txt_description.Text;
            guncelleme.IsOutsource = Convert.ToInt32(txt_Source.Text);
            guncelleme.SupplierName = txt_name.Text;
            workCenter.Update(guncelleme);
            dataGridView1.DataSource = workCenter.SelectAll();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_description.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Source.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
