using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwooneWinform.Forms
{
    public partial class LayoutForm : Form
    {
        public LayoutForm()
        {
            InitializeComponent();
        }
        private Form currentChildForm;
        private void OpenChildForm(Form child)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(child);
            pnlContainer.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void btnQLPhim_Click(object sender, EventArgs e)
        {
            btnQLPhim.BackColor = Color.White;
            btnQLPhim.ForeColor = Color.Black;
            OpenChildForm(new QuanLyPhimForm());
            lblForm.Text = btnQLPhim.Text;
            btnQLPhim.Enabled = false;
        }
    }
}
