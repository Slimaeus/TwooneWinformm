using System.Windows.Forms;

namespace TwooneWinform
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maNgonNguLabel;
            System.Windows.Forms.Label maNuocLabel;
            System.Windows.Forms.Label trailerPhimLabel;
            System.Windows.Forms.Label linkPhimVipLabel;
            System.Windows.Forms.Label linkPhimLabel;
            System.Windows.Forms.Label hinhBannerLabel;
            System.Windows.Forms.Label thoiLuongLabel;
            System.Windows.Forms.Label luotXemLabel;
            System.Windows.Forms.Label diemIMDBLabel;
            System.Windows.Forms.Label noiDungPhimTomTatLabel;
            System.Windows.Forms.Label noiDungPhimLabel;
            System.Windows.Forms.Label ngaySanXuatLabel;
            System.Windows.Forms.Label tenPhimLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.Label maPhimLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpQLPhim = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phimDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.twooneDataSet = new TwooneWinform.TwooneDataSet();
            this.ngonNguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datNuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpQLNguoiDung = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.phimTableAdapter = new TwooneWinform.TwooneDataSetTableAdapters.PhimTableAdapter();
            this.tableAdapterManager = new TwooneWinform.TwooneDataSetTableAdapters.TableAdapterManager();
            this.datNuocTableAdapter = new TwooneWinform.TwooneDataSetTableAdapters.DatNuocTableAdapter();
            this.ngonNguTableAdapter = new TwooneWinform.TwooneDataSetTableAdapters.NgonNguTableAdapter();
            this.trailerPhimTextBox = new System.Windows.Forms.TextBox();
            this.linkPhimVipTextBox = new System.Windows.Forms.TextBox();
            this.linkPhimTextBox = new System.Windows.Forms.TextBox();
            this.hinhBannerTextBox = new System.Windows.Forms.TextBox();
            this.thoiLuongTextBox = new System.Windows.Forms.TextBox();
            this.luotXemTextBox = new System.Windows.Forms.TextBox();
            this.diemIMDBTextBox = new System.Windows.Forms.TextBox();
            this.noiDungPhimTomTatTextBox = new System.Windows.Forms.TextBox();
            this.noiDungPhimTextBox = new System.Windows.Forms.TextBox();
            this.ngaySanXuatDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tenPhimTextBox = new System.Windows.Forms.TextBox();
            this.maPhimTextBox = new System.Windows.Forms.TextBox();
            this.phimBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.phimBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.datNuocComboBox = new System.Windows.Forms.ComboBox();
            this.ngonNguComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            maNgonNguLabel = new System.Windows.Forms.Label();
            maNuocLabel = new System.Windows.Forms.Label();
            trailerPhimLabel = new System.Windows.Forms.Label();
            linkPhimVipLabel = new System.Windows.Forms.Label();
            linkPhimLabel = new System.Windows.Forms.Label();
            hinhBannerLabel = new System.Windows.Forms.Label();
            thoiLuongLabel = new System.Windows.Forms.Label();
            luotXemLabel = new System.Windows.Forms.Label();
            diemIMDBLabel = new System.Windows.Forms.Label();
            noiDungPhimTomTatLabel = new System.Windows.Forms.Label();
            noiDungPhimLabel = new System.Windows.Forms.Label();
            ngaySanXuatLabel = new System.Windows.Forms.Label();
            tenPhimLabel = new System.Windows.Forms.Label();
            maPhimLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpQLPhim.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phimDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twooneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngonNguBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datNuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingNavigator)).BeginInit();
            this.phimBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpQLPhim);
            this.tabControl1.Controls.Add(this.tpQLNguoiDung);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 632);
            this.tabControl1.TabIndex = 0;
            // 
            // tpQLPhim
            // 
            this.tpQLPhim.AutoScroll = true;
            this.tpQLPhim.Controls.Add(this.groupBox2);
            this.tpQLPhim.Controls.Add(this.groupBox1);
            this.tpQLPhim.Location = new System.Drawing.Point(4, 25);
            this.tpQLPhim.Name = "tpQLPhim";
            this.tpQLPhim.Padding = new System.Windows.Forms.Padding(3);
            this.tpQLPhim.Size = new System.Drawing.Size(803, 603);
            this.tpQLPhim.TabIndex = 0;
            this.tpQLPhim.Text = "Quản lý Phim";
            this.tpQLPhim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phimDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng dữ liệu";
            // 
            // phimDataGridView
            // 
            this.phimDataGridView.AutoGenerateColumns = false;
            this.phimDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phimDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.phimDataGridView.DataSource = this.phimBindingSource;
            this.phimDataGridView.Location = new System.Drawing.Point(3, 18);
            this.phimDataGridView.Name = "phimDataGridView";
            this.phimDataGridView.RowHeadersWidth = 51;
            this.phimDataGridView.RowTemplate.Height = 24;
            this.phimDataGridView.Size = new System.Drawing.Size(759, 301);
            this.phimDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaPhim";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Phim";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenPhim";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Phim";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NgaySanXuat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày sản xuất";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoiDungPhim";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nội dung";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NoiDungPhimTomTat";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nội dung tóm tắt";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DiemIMDB";
            this.dataGridViewTextBoxColumn6.HeaderText = "Điểm IDMb";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "LuotXem";
            this.dataGridViewTextBoxColumn7.HeaderText = "Lượt xem";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ThoiLuong";
            this.dataGridViewTextBoxColumn8.HeaderText = "Thời lượng";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "HinhBanner";
            this.dataGridViewTextBoxColumn9.HeaderText = "Hình Banner";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LinkPhim";
            this.dataGridViewTextBoxColumn10.HeaderText = "Link Phim";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LinkPhimVip";
            this.dataGridViewTextBoxColumn11.HeaderText = "Link Phim Vip";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TrailerPhim";
            this.dataGridViewTextBoxColumn12.HeaderText = "Trailer Phim";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // phimBindingSource
            // 
            this.phimBindingSource.DataMember = "Phim";
            this.phimBindingSource.DataSource = this.twooneDataSet;
            // 
            // twooneDataSet
            // 
            this.twooneDataSet.DataSetName = "TwooneDataSet";
            this.twooneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ngonNguBindingSource
            // 
            this.ngonNguBindingSource.DataMember = "NgonNgu";
            this.ngonNguBindingSource.DataSource = this.twooneDataSet;
            // 
            // datNuocBindingSource
            // 
            this.datNuocBindingSource.DataMember = "DatNuoc";
            this.datNuocBindingSource.DataSource = this.twooneDataSet;
            // 
            // tpQLNguoiDung
            // 
            this.tpQLNguoiDung.AutoScroll = true;
            this.tpQLNguoiDung.Location = new System.Drawing.Point(4, 25);
            this.tpQLNguoiDung.Name = "tpQLNguoiDung";
            this.tpQLNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tpQLNguoiDung.Size = new System.Drawing.Size(803, 603);
            this.tpQLNguoiDung.TabIndex = 1;
            this.tpQLNguoiDung.Text = "Quản lý Người dùng";
            this.tpQLNguoiDung.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 603);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // phimTableAdapter
            // 
            this.phimTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DanhGiaPhimTableAdapter = null;
            this.tableAdapterManager.DaoDienCuaPhimTableAdapter = null;
            this.tableAdapterManager.DaoDienTableAdapter = null;
            this.tableAdapterManager.DatNuocTableAdapter = null;
            this.tableAdapterManager.DienVienDongPhimTableAdapter = null;
            this.tableAdapterManager.DienVienTableAdapter = null;
            this.tableAdapterManager.GoiDichVuTableAdapter = null;
            this.tableAdapterManager.HashTagCuaPhimTableAdapter = null;
            this.tableAdapterManager.HashTagTableAdapter = null;
            this.tableAdapterManager.NgonNguTableAdapter = null;
            this.tableAdapterManager.NguoiDungTableAdapter = null;
            this.tableAdapterManager.PhieuDangKyTableAdapter = null;
            this.tableAdapterManager.PhimTableAdapter = this.phimTableAdapter;
            this.tableAdapterManager.TheLoaiCuaPhimTableAdapter = null;
            this.tableAdapterManager.TheLoaiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TwooneWinform.TwooneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // datNuocTableAdapter
            // 
            this.datNuocTableAdapter.ClearBeforeFill = true;
            // 
            // ngonNguTableAdapter
            // 
            this.ngonNguTableAdapter.ClearBeforeFill = true;
            // 
            // maNgonNguLabel
            // 
            maNgonNguLabel.AutoSize = true;
            maNgonNguLabel.Location = new System.Drawing.Point(403, 228);
            maNgonNguLabel.Name = "maNgonNguLabel";
            maNgonNguLabel.Size = new System.Drawing.Size(68, 16);
            maNgonNguLabel.TabIndex = 26;
            maNgonNguLabel.Text = "Ngôn ngữ:";
            // 
            // maNuocLabel
            // 
            maNuocLabel.AutoSize = true;
            maNuocLabel.Location = new System.Drawing.Point(6, 225);
            maNuocLabel.Name = "maNuocLabel";
            maNuocLabel.Size = new System.Drawing.Size(64, 16);
            maNuocLabel.TabIndex = 24;
            maNuocLabel.Text = "Quốc gia:";
            // 
            // trailerPhimTextBox
            // 
            this.trailerPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "TrailerPhim", true));
            this.trailerPhimTextBox.Location = new System.Drawing.Point(562, 193);
            this.trailerPhimTextBox.Name = "trailerPhimTextBox";
            this.trailerPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.trailerPhimTextBox.TabIndex = 23;
            // 
            // trailerPhimLabel
            // 
            trailerPhimLabel.AutoSize = true;
            trailerPhimLabel.Location = new System.Drawing.Point(403, 196);
            trailerPhimLabel.Name = "trailerPhimLabel";
            trailerPhimLabel.Size = new System.Drawing.Size(82, 16);
            trailerPhimLabel.TabIndex = 22;
            trailerPhimLabel.Text = "Trailer Phim:";
            // 
            // linkPhimVipTextBox
            // 
            this.linkPhimVipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "LinkPhimVip", true));
            this.linkPhimVipTextBox.Location = new System.Drawing.Point(562, 165);
            this.linkPhimVipTextBox.Name = "linkPhimVipTextBox";
            this.linkPhimVipTextBox.Size = new System.Drawing.Size(200, 22);
            this.linkPhimVipTextBox.TabIndex = 21;
            // 
            // linkPhimVipLabel
            // 
            linkPhimVipLabel.AutoSize = true;
            linkPhimVipLabel.Location = new System.Drawing.Point(403, 168);
            linkPhimVipLabel.Name = "linkPhimVipLabel";
            linkPhimVipLabel.Size = new System.Drawing.Size(90, 16);
            linkPhimVipLabel.TabIndex = 20;
            linkPhimVipLabel.Text = "Link Phim Vip:";
            // 
            // linkPhimTextBox
            // 
            this.linkPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "LinkPhim", true));
            this.linkPhimTextBox.Location = new System.Drawing.Point(562, 137);
            this.linkPhimTextBox.Name = "linkPhimTextBox";
            this.linkPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.linkPhimTextBox.TabIndex = 19;
            // 
            // linkPhimLabel
            // 
            linkPhimLabel.AutoSize = true;
            linkPhimLabel.Location = new System.Drawing.Point(403, 140);
            linkPhimLabel.Name = "linkPhimLabel";
            linkPhimLabel.Size = new System.Drawing.Size(67, 16);
            linkPhimLabel.TabIndex = 18;
            linkPhimLabel.Text = "Link Phim:";
            // 
            // hinhBannerTextBox
            // 
            this.hinhBannerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "HinhBanner", true));
            this.hinhBannerTextBox.Location = new System.Drawing.Point(562, 109);
            this.hinhBannerTextBox.Name = "hinhBannerTextBox";
            this.hinhBannerTextBox.Size = new System.Drawing.Size(200, 22);
            this.hinhBannerTextBox.TabIndex = 17;
            // 
            // hinhBannerLabel
            // 
            hinhBannerLabel.AutoSize = true;
            hinhBannerLabel.Location = new System.Drawing.Point(403, 112);
            hinhBannerLabel.Name = "hinhBannerLabel";
            hinhBannerLabel.Size = new System.Drawing.Size(83, 16);
            hinhBannerLabel.TabIndex = 16;
            hinhBannerLabel.Text = "Hình Banner:";
            // 
            // thoiLuongTextBox
            // 
            this.thoiLuongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "ThoiLuong", true));
            this.thoiLuongTextBox.Location = new System.Drawing.Point(562, 81);
            this.thoiLuongTextBox.Name = "thoiLuongTextBox";
            this.thoiLuongTextBox.Size = new System.Drawing.Size(200, 22);
            this.thoiLuongTextBox.TabIndex = 15;
            // 
            // thoiLuongLabel
            // 
            thoiLuongLabel.AutoSize = true;
            thoiLuongLabel.Location = new System.Drawing.Point(403, 84);
            thoiLuongLabel.Name = "thoiLuongLabel";
            thoiLuongLabel.Size = new System.Drawing.Size(73, 16);
            thoiLuongLabel.TabIndex = 14;
            thoiLuongLabel.Text = "Thời lượng:";
            // 
            // luotXemTextBox
            // 
            this.luotXemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "LuotXem", true));
            this.luotXemTextBox.Location = new System.Drawing.Point(562, 53);
            this.luotXemTextBox.Name = "luotXemTextBox";
            this.luotXemTextBox.Size = new System.Drawing.Size(200, 22);
            this.luotXemTextBox.TabIndex = 13;
            // 
            // luotXemLabel
            // 
            luotXemLabel.AutoSize = true;
            luotXemLabel.Location = new System.Drawing.Point(403, 56);
            luotXemLabel.Name = "luotXemLabel";
            luotXemLabel.Size = new System.Drawing.Size(63, 16);
            luotXemLabel.TabIndex = 12;
            luotXemLabel.Text = "Lượt xem:";
            // 
            // diemIMDBTextBox
            // 
            this.diemIMDBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "DiemIMDB", true));
            this.diemIMDBTextBox.Location = new System.Drawing.Point(165, 193);
            this.diemIMDBTextBox.Name = "diemIMDBTextBox";
            this.diemIMDBTextBox.Size = new System.Drawing.Size(200, 22);
            this.diemIMDBTextBox.TabIndex = 11;
            // 
            // diemIMDBLabel
            // 
            diemIMDBLabel.AutoSize = true;
            diemIMDBLabel.Location = new System.Drawing.Point(6, 196);
            diemIMDBLabel.Name = "diemIMDBLabel";
            diemIMDBLabel.Size = new System.Drawing.Size(77, 16);
            diemIMDBLabel.TabIndex = 10;
            diemIMDBLabel.Text = "Điểm IMDB:";
            // 
            // noiDungPhimTomTatTextBox
            // 
            this.noiDungPhimTomTatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "NoiDungPhimTomTat", true));
            this.noiDungPhimTomTatTextBox.Location = new System.Drawing.Point(165, 165);
            this.noiDungPhimTomTatTextBox.Name = "noiDungPhimTomTatTextBox";
            this.noiDungPhimTomTatTextBox.Size = new System.Drawing.Size(200, 22);
            this.noiDungPhimTomTatTextBox.TabIndex = 9;
            // 
            // noiDungPhimTomTatLabel
            // 
            noiDungPhimTomTatLabel.AutoSize = true;
            noiDungPhimTomTatLabel.Location = new System.Drawing.Point(6, 168);
            noiDungPhimTomTatLabel.Name = "noiDungPhimTomTatLabel";
            noiDungPhimTomTatLabel.Size = new System.Drawing.Size(106, 16);
            noiDungPhimTomTatLabel.TabIndex = 8;
            noiDungPhimTomTatLabel.Text = "Nội dung tóm tắt:";
            // 
            // noiDungPhimTextBox
            // 
            this.noiDungPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "NoiDungPhim", true));
            this.noiDungPhimTextBox.Location = new System.Drawing.Point(165, 137);
            this.noiDungPhimTextBox.Name = "noiDungPhimTextBox";
            this.noiDungPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.noiDungPhimTextBox.TabIndex = 7;
            // 
            // noiDungPhimLabel
            // 
            noiDungPhimLabel.AutoSize = true;
            noiDungPhimLabel.Location = new System.Drawing.Point(6, 140);
            noiDungPhimLabel.Name = "noiDungPhimLabel";
            noiDungPhimLabel.Size = new System.Drawing.Size(97, 16);
            noiDungPhimLabel.TabIndex = 6;
            noiDungPhimLabel.Text = "Nội dung Phim:";
            // 
            // ngaySanXuatDateTimePicker
            // 
            this.ngaySanXuatDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phimBindingSource, "NgaySanXuat", true));
            this.ngaySanXuatDateTimePicker.Location = new System.Drawing.Point(165, 109);
            this.ngaySanXuatDateTimePicker.Name = "ngaySanXuatDateTimePicker";
            this.ngaySanXuatDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySanXuatDateTimePicker.TabIndex = 5;
            // 
            // ngaySanXuatLabel
            // 
            ngaySanXuatLabel.AutoSize = true;
            ngaySanXuatLabel.Location = new System.Drawing.Point(6, 113);
            ngaySanXuatLabel.Name = "ngaySanXuatLabel";
            ngaySanXuatLabel.Size = new System.Drawing.Size(95, 16);
            ngaySanXuatLabel.TabIndex = 4;
            ngaySanXuatLabel.Text = "Ngày sản xuất:";
            // 
            // tenPhimTextBox
            // 
            this.tenPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "TenPhim", true));
            this.tenPhimTextBox.Location = new System.Drawing.Point(165, 81);
            this.tenPhimTextBox.Name = "tenPhimTextBox";
            this.tenPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.tenPhimTextBox.TabIndex = 3;
            // 
            // tenPhimLabel
            // 
            tenPhimLabel.AutoSize = true;
            tenPhimLabel.Location = new System.Drawing.Point(6, 84);
            tenPhimLabel.Name = "tenPhimLabel";
            tenPhimLabel.Size = new System.Drawing.Size(67, 16);
            tenPhimLabel.TabIndex = 2;
            tenPhimLabel.Text = "Tên Phim:";
            // 
            // maPhimTextBox
            // 
            this.maPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "MaPhim", true));
            this.maPhimTextBox.Location = new System.Drawing.Point(165, 53);
            this.maPhimTextBox.Name = "maPhimTextBox";
            this.maPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.maPhimTextBox.TabIndex = 1;
            // 
            // phimBindingNavigator
            // 
            this.phimBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phimBindingNavigator.BindingSource = this.phimBindingSource;
            this.phimBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phimBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phimBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.phimBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.phimBindingNavigatorSaveItem});
            this.phimBindingNavigator.Location = new System.Drawing.Point(3, 18);
            this.phimBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phimBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phimBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phimBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phimBindingNavigator.Name = "phimBindingNavigator";
            this.phimBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phimBindingNavigator.Size = new System.Drawing.Size(770, 27);
            this.phimBindingNavigator.TabIndex = 1;
            this.phimBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số Phim";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Thêm mới";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            // 
            // phimBindingNavigatorSaveItem
            // 
            this.phimBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phimBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phimBindingNavigatorSaveItem.Image")));
            this.phimBindingNavigatorSaveItem.Name = "phimBindingNavigatorSaveItem";
            this.phimBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.phimBindingNavigatorSaveItem.Text = "Lưu";
            this.phimBindingNavigatorSaveItem.Click += new System.EventHandler(this.phimBindingNavigatorSaveItem_Click_1);
            // 
            // maPhimLabel
            // 
            maPhimLabel.AutoSize = true;
            maPhimLabel.Location = new System.Drawing.Point(6, 56);
            maPhimLabel.Name = "maPhimLabel";
            maPhimLabel.Size = new System.Drawing.Size(62, 16);
            maPhimLabel.TabIndex = 0;
            maPhimLabel.Text = "Mã Phim:";
            // 
            // datNuocComboBox
            // 
            this.datNuocComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phimBindingSource, "MaNuoc", true));
            this.datNuocComboBox.DataSource = this.datNuocBindingSource;
            this.datNuocComboBox.DisplayMember = "TenNuoc";
            this.datNuocComboBox.FormattingEnabled = true;
            this.datNuocComboBox.Location = new System.Drawing.Point(165, 223);
            this.datNuocComboBox.Name = "datNuocComboBox";
            this.datNuocComboBox.Size = new System.Drawing.Size(200, 24);
            this.datNuocComboBox.TabIndex = 28;
            this.datNuocComboBox.ValueMember = "MaNuoc";
            // 
            // ngonNguComboBox
            // 
            this.ngonNguComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phimBindingSource, "MaNgonNgu", true));
            this.ngonNguComboBox.DataSource = this.ngonNguBindingSource;
            this.ngonNguComboBox.DisplayMember = "TenNgonNgu";
            this.ngonNguComboBox.FormattingEnabled = true;
            this.ngonNguComboBox.Location = new System.Drawing.Point(562, 225);
            this.ngonNguComboBox.Name = "ngonNguComboBox";
            this.ngonNguComboBox.Size = new System.Drawing.Size(200, 24);
            this.ngonNguComboBox.TabIndex = 29;
            this.ngonNguComboBox.ValueMember = "MaNgonNgu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ngonNguComboBox);
            this.groupBox1.Controls.Add(this.datNuocComboBox);
            this.groupBox1.Controls.Add(maPhimLabel);
            this.groupBox1.Controls.Add(this.phimBindingNavigator);
            this.groupBox1.Controls.Add(this.maPhimTextBox);
            this.groupBox1.Controls.Add(tenPhimLabel);
            this.groupBox1.Controls.Add(this.tenPhimTextBox);
            this.groupBox1.Controls.Add(ngaySanXuatLabel);
            this.groupBox1.Controls.Add(this.ngaySanXuatDateTimePicker);
            this.groupBox1.Controls.Add(noiDungPhimLabel);
            this.groupBox1.Controls.Add(this.noiDungPhimTextBox);
            this.groupBox1.Controls.Add(noiDungPhimTomTatLabel);
            this.groupBox1.Controls.Add(this.noiDungPhimTomTatTextBox);
            this.groupBox1.Controls.Add(diemIMDBLabel);
            this.groupBox1.Controls.Add(this.diemIMDBTextBox);
            this.groupBox1.Controls.Add(luotXemLabel);
            this.groupBox1.Controls.Add(this.luotXemTextBox);
            this.groupBox1.Controls.Add(thoiLuongLabel);
            this.groupBox1.Controls.Add(this.thoiLuongTextBox);
            this.groupBox1.Controls.Add(hinhBannerLabel);
            this.groupBox1.Controls.Add(this.hinhBannerTextBox);
            this.groupBox1.Controls.Add(linkPhimLabel);
            this.groupBox1.Controls.Add(this.linkPhimTextBox);
            this.groupBox1.Controls.Add(linkPhimVipLabel);
            this.groupBox1.Controls.Add(this.linkPhimVipTextBox);
            this.groupBox1.Controls.Add(trailerPhimLabel);
            this.groupBox1.Controls.Add(this.trailerPhimTextBox);
            this.groupBox1.Controls.Add(maNuocLabel);
            this.groupBox1.Controls.Add(maNgonNguLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 632);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Twoone";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpQLPhim.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phimDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twooneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngonNguBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datNuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingNavigator)).EndInit();
            this.phimBindingNavigator.ResumeLayout(false);
            this.phimBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpQLPhim;
        private TwooneDataSet twooneDataSet;
        private System.Windows.Forms.BindingSource phimBindingSource;
        private TwooneDataSetTableAdapters.PhimTableAdapter phimTableAdapter;
        private TwooneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView phimDataGridView;
        private TabPage tpQLNguoiDung;
        private BindingSource datNuocBindingSource;
        private TwooneDataSetTableAdapters.DatNuocTableAdapter datNuocTableAdapter;
        private TabPage tabPage1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private BindingSource ngonNguBindingSource;
        private TwooneDataSetTableAdapters.NgonNguTableAdapter ngonNguTableAdapter;
        private GroupBox groupBox1;
        private ComboBox ngonNguComboBox;
        private ComboBox datNuocComboBox;
        private BindingNavigator phimBindingNavigator;
        private ToolStripButton bindingNavigatorAddNewItem;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorDeleteItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton phimBindingNavigatorSaveItem;
        private TextBox maPhimTextBox;
        private TextBox tenPhimTextBox;
        private DateTimePicker ngaySanXuatDateTimePicker;
        private TextBox noiDungPhimTextBox;
        private TextBox noiDungPhimTomTatTextBox;
        private TextBox diemIMDBTextBox;
        private TextBox luotXemTextBox;
        private TextBox thoiLuongTextBox;
        private TextBox hinhBannerTextBox;
        private TextBox linkPhimTextBox;
        private TextBox linkPhimVipTextBox;
        private TextBox trailerPhimTextBox;
    }
}

