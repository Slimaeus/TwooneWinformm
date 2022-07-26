using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwooneWinform
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void phimBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phimBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.twooneDataSet);

        }

        private void phimBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.phimBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.twooneDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'twooneDataSet.NgonNgu' table. You can move, or remove it, as needed.
            this.ngonNguTableAdapter.Fill(this.twooneDataSet.NgonNgu);
            // TODO: This line of code loads data into the 'twooneDataSet.DatNuoc' table. You can move, or remove it, as needed.
            this.datNuocTableAdapter.Fill(this.twooneDataSet.DatNuoc);
            // TODO: This line of code loads data into the 'twooneDataSet.Phim' table. You can move, or remove it, as needed.
            this.phimTableAdapter.Fill(this.twooneDataSet.Phim);

        }
    }
}
