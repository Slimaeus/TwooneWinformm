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
    public partial class QuanLyNguoiDungUserControl1 : UserControl
    {
        public QuanLyNguoiDungUserControl1()
        {
            InitializeComponent();
        }

        private void nguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.twooneDataSet);

        }
    }
}
