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
    public partial class MoldTypeForm : Form
    {
        public MoldTypeForm()
        {
            InitializeComponent();
        }
        BaseRepository<MoldType> moldType = new BaseRepository<MoldType>();
        MoldType type = new MoldType();
        private void MoldTypeForm_Load(object sender, EventArgs e)
        {
            if (moldType.SelectAll().Count>0)
            {
                dataGridView1.DataSource = moldType.SelectAll();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            type.Description = txt_description.Text;
            moldType.Insert(type);
            dataGridView1.DataSource = moldType.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            type.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            moldType.Delete(type.ID);
            dataGridView1.DataSource = moldType.SelectAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_description.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var guncelleme = moldType.SelectedById(id);
            guncelleme.Description = txt_description.Text;
            dataGridView1.DataSource = moldType.SelectAll();
        }
    }
}
