using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwooneWinform.UserControls
{
    public partial class QuanLyPhimUserControl : UserControl
    {
        public QuanLyPhimUserControl()
        {
            InitializeComponent();
        }

        private void phimBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phimBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.twooneDataSet);

        }
    }
}
