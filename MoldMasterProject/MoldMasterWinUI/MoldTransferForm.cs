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
    public partial class MoldTransferForm : Form
    {
        public MoldTransferForm()
        {
            InitializeComponent();
        }
        BaseRepository<MoldTransfer> moldTransfer = new BaseRepository<MoldTransfer>();
        MoldTransfer transfer = new MoldTransfer();
        private void button1_Click(object sender, EventArgs e)
        {
            transfer.DocNo = txt_docNo.Text;
            transfer.FromMachineID = Convert.ToInt32(txt_fromMachineId.Text);
            transfer.FromWorkCenterID = Convert.ToInt32(txt_fromWorkCenterId.Text);
            transfer.TransferTime = Convert.ToDateTime( txt_transferTime.Text);
            transfer.MoldID = Convert.ToInt32(txt_modID.Text);
            transfer.JobTypeID = Convert.ToInt32(txt_jobTypeID.Text);
            transfer.FromMachineID = Convert.ToInt32(txt_fromMachineId.Text);
            transfer.FromWorkCenterID = Convert.ToInt32(txt_fromWorkCenterId.Text);
            moldTransfer.Insert(transfer);
            dataGridView1.DataSource = moldTransfer.SelectAll();
         


        }

        private void MoldTransferForm_Load(object sender, EventArgs e)
        {
            if (moldTransfer.SelectAll().Count>0)
            {
                dataGridView1.DataSource = moldTransfer.SelectAll();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transfer.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            moldTransfer.Delete(transfer.ID);
            dataGridView1.DataSource = moldTransfer.SelectAll();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_docNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_transferTime.Text = dataGridView1.CurrentRow.Cells[2].ToString();
            txt_modID.Text = dataGridView1.CurrentRow.Cells[3].ToString();
            txt_jobTypeID.Text = dataGridView1.CurrentRow.Cells[4].ToString();
            txt_fromMachineId.Text = dataGridView1.CurrentRow.Cells[5].ToString();
            txt_fromWorkCenterId.Text = dataGridView1.CurrentRow.Cells[6].ToString();
            txt_toMachineId.Text = dataGridView1.CurrentRow.Cells[7].ToString();
            txt_toWorkCenterID.Text = dataGridView1.CurrentRow.Cells[8].ToString();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var guncelleme = moldTransfer.SelectedById(id);
            guncelleme.DocNo = txt_docNo.Text;
            guncelleme.TransferTime =Convert.ToDateTime( txt_transferTime.Text);
            guncelleme.MoldID = Convert.ToInt32(txt_modID.Text);
            guncelleme.JobTypeID = Convert.ToInt32(txt_jobTypeID.Text);
            guncelleme.FromMachineID = Convert.ToInt32(txt_fromMachineId.Text);
            guncelleme.FromWorkCenterID = Convert.ToInt32(txt_fromWorkCenterId.Text);
            guncelleme.ToMachineID = Convert.ToInt32(txt_toMachineId.Text);
            guncelleme.ToWorkCenterID = Convert.ToInt32(txt_toWorkCenterID.Text);


        }
    }
}
