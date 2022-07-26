namespace TwooneWinform.UserControls
{
    partial class QuanLyPhimUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maPhimLabel;
            System.Windows.Forms.Label tenPhimLabel;
            System.Windows.Forms.Label ngaySanXuatLabel;
            System.Windows.Forms.Label noiDungPhimLabel;
            System.Windows.Forms.Label noiDungPhimTomTatLabel;
            System.Windows.Forms.Label diemIMDBLabel;
            System.Windows.Forms.Label luotXemLabel;
            System.Windows.Forms.Label thoiLuongLabel;
            System.Windows.Forms.Label hinhBannerLabel;
            System.Windows.Forms.Label linkPhimLabel;
            System.Windows.Forms.Label linkPhimVipLabel;
            System.Windows.Forms.Label trailerPhimLabel;
            System.Windows.Forms.Label maNuocLabel;
            System.Windows.Forms.Label maNgonNguLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyPhimUserControl));
            this.gpbThongTinPhim = new System.Windows.Forms.GroupBox();
            this.maPhimTextBox = new System.Windows.Forms.TextBox();
            this.phimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.twooneDataSet = new TwooneWinform.TwooneDataSet();
            this.tenPhimTextBox = new System.Windows.Forms.TextBox();
            this.ngaySanXuatDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noiDungPhimTextBox = new System.Windows.Forms.TextBox();
            this.noiDungPhimTomTatTextBox = new System.Windows.Forms.TextBox();
            this.diemIMDBTextBox = new System.Windows.Forms.TextBox();
            this.luotXemTextBox = new System.Windows.Forms.TextBox();
            this.thoiLuongTextBox = new System.Windows.Forms.TextBox();
            this.hinhBannerTextBox = new System.Windows.Forms.TextBox();
            this.linkPhimTextBox = new System.Windows.Forms.TextBox();
            this.linkPhimVipTextBox = new System.Windows.Forms.TextBox();
            this.trailerPhimTextBox = new System.Windows.Forms.TextBox();
            this.maNuocTextBox = new System.Windows.Forms.TextBox();
            this.maNgonNguTextBox = new System.Windows.Forms.TextBox();
            this.gpbBangPhim = new System.Windows.Forms.GroupBox();
            this.phimTableAdapter = new TwooneWinform.TwooneDataSetTableAdapters.PhimTableAdapter();
            this.tableAdapterManager = new TwooneWinform.TwooneDataSetTableAdapters.TableAdapterManager();
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
            this.phimBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            maPhimLabel = new System.Windows.Forms.Label();
            tenPhimLabel = new System.Windows.Forms.Label();
            ngaySanXuatLabel = new System.Windows.Forms.Label();
            noiDungPhimLabel = new System.Windows.Forms.Label();
            noiDungPhimTomTatLabel = new System.Windows.Forms.Label();
            diemIMDBLabel = new System.Windows.Forms.Label();
            luotXemLabel = new System.Windows.Forms.Label();
            thoiLuongLabel = new System.Windows.Forms.Label();
            hinhBannerLabel = new System.Windows.Forms.Label();
            linkPhimLabel = new System.Windows.Forms.Label();
            linkPhimVipLabel = new System.Windows.Forms.Label();
            trailerPhimLabel = new System.Windows.Forms.Label();
            maNuocLabel = new System.Windows.Forms.Label();
            maNgonNguLabel = new System.Windows.Forms.Label();
            this.gpbThongTinPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twooneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingNavigator)).BeginInit();
            this.phimBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // maPhimLabel
            // 
            maPhimLabel.AutoSize = true;
            maPhimLabel.Location = new System.Drawing.Point(23, 35);
            maPhimLabel.Name = "maPhimLabel";
            maPhimLabel.Size = new System.Drawing.Size(62, 16);
            maPhimLabel.TabIndex = 0;
            maPhimLabel.Text = "Ma Phim:";
            // 
            // tenPhimLabel
            // 
            tenPhimLabel.AutoSize = true;
            tenPhimLabel.Location = new System.Drawing.Point(23, 63);
            tenPhimLabel.Name = "tenPhimLabel";
            tenPhimLabel.Size = new System.Drawing.Size(67, 16);
            tenPhimLabel.TabIndex = 2;
            tenPhimLabel.Text = "Ten Phim:";
            // 
            // ngaySanXuatLabel
            // 
            ngaySanXuatLabel.AutoSize = true;
            ngaySanXuatLabel.Location = new System.Drawing.Point(23, 92);
            ngaySanXuatLabel.Name = "ngaySanXuatLabel";
            ngaySanXuatLabel.Size = new System.Drawing.Size(99, 16);
            ngaySanXuatLabel.TabIndex = 4;
            ngaySanXuatLabel.Text = "Ngay San Xuat:";
            // 
            // noiDungPhimLabel
            // 
            noiDungPhimLabel.AutoSize = true;
            noiDungPhimLabel.Location = new System.Drawing.Point(23, 119);
            noiDungPhimLabel.Name = "noiDungPhimLabel";
            noiDungPhimLabel.Size = new System.Drawing.Size(99, 16);
            noiDungPhimLabel.TabIndex = 6;
            noiDungPhimLabel.Text = "Noi Dung Phim:";
            // 
            // noiDungPhimTomTatLabel
            // 
            noiDungPhimTomTatLabel.AutoSize = true;
            noiDungPhimTomTatLabel.Location = new System.Drawing.Point(23, 147);
            noiDungPhimTomTatLabel.Name = "noiDungPhimTomTatLabel";
            noiDungPhimTomTatLabel.Size = new System.Drawing.Size(153, 16);
            noiDungPhimTomTatLabel.TabIndex = 8;
            noiDungPhimTomTatLabel.Text = "Noi Dung Phim Tom Tat:";
            // 
            // diemIMDBLabel
            // 
            diemIMDBLabel.AutoSize = true;
            diemIMDBLabel.Location = new System.Drawing.Point(23, 175);
            diemIMDBLabel.Name = "diemIMDBLabel";
            diemIMDBLabel.Size = new System.Drawing.Size(78, 16);
            diemIMDBLabel.TabIndex = 10;
            diemIMDBLabel.Text = "Diem IMDB:";
            // 
            // luotXemLabel
            // 
            luotXemLabel.AutoSize = true;
            luotXemLabel.Location = new System.Drawing.Point(23, 203);
            luotXemLabel.Name = "luotXemLabel";
            luotXemLabel.Size = new System.Drawing.Size(65, 16);
            luotXemLabel.TabIndex = 12;
            luotXemLabel.Text = "Luot Xem:";
            // 
            // thoiLuongLabel
            // 
            thoiLuongLabel.AutoSize = true;
            thoiLuongLabel.Location = new System.Drawing.Point(407, 35);
            thoiLuongLabel.Name = "thoiLuongLabel";
            thoiLuongLabel.Size = new System.Drawing.Size(77, 16);
            thoiLuongLabel.TabIndex = 14;
            thoiLuongLabel.Text = "Thoi Luong:";
            // 
            // hinhBannerLabel
            // 
            hinhBannerLabel.AutoSize = true;
            hinhBannerLabel.Location = new System.Drawing.Point(407, 63);
            hinhBannerLabel.Name = "hinhBannerLabel";
            hinhBannerLabel.Size = new System.Drawing.Size(83, 16);
            hinhBannerLabel.TabIndex = 16;
            hinhBannerLabel.Text = "Hinh Banner:";
            // 
            // linkPhimLabel
            // 
            linkPhimLabel.AutoSize = true;
            linkPhimLabel.Location = new System.Drawing.Point(407, 91);
            linkPhimLabel.Name = "linkPhimLabel";
            linkPhimLabel.Size = new System.Drawing.Size(67, 16);
            linkPhimLabel.TabIndex = 18;
            linkPhimLabel.Text = "Link Phim:";
            // 
            // linkPhimVipLabel
            // 
            linkPhimVipLabel.AutoSize = true;
            linkPhimVipLabel.Location = new System.Drawing.Point(407, 119);
            linkPhimVipLabel.Name = "linkPhimVipLabel";
            linkPhimVipLabel.Size = new System.Drawing.Size(90, 16);
            linkPhimVipLabel.TabIndex = 20;
            linkPhimVipLabel.Text = "Link Phim Vip:";
            // 
            // trailerPhimLabel
            // 
            trailerPhimLabel.AutoSize = true;
            trailerPhimLabel.Location = new System.Drawing.Point(407, 147);
            trailerPhimLabel.Name = "trailerPhimLabel";
            trailerPhimLabel.Size = new System.Drawing.Size(82, 16);
            trailerPhimLabel.TabIndex = 22;
            trailerPhimLabel.Text = "Trailer Phim:";
            // 
            // maNuocLabel
            // 
            maNuocLabel.AutoSize = true;
            maNuocLabel.Location = new System.Drawing.Point(407, 175);
            maNuocLabel.Name = "maNuocLabel";
            maNuocLabel.Size = new System.Drawing.Size(64, 16);
            maNuocLabel.TabIndex = 24;
            maNuocLabel.Text = "Ma Nuoc:";
            // 
            // maNgonNguLabel
            // 
            maNgonNguLabel.AutoSize = true;
            maNgonNguLabel.Location = new System.Drawing.Point(407, 203);
            maNgonNguLabel.Name = "maNgonNguLabel";
            maNgonNguLabel.Size = new System.Drawing.Size(93, 16);
            maNgonNguLabel.TabIndex = 26;
            maNgonNguLabel.Text = "Ma Ngon Ngu:";
            // 
            // gpbThongTinPhim
            // 
            this.gpbThongTinPhim.Controls.Add(maPhimLabel);
            this.gpbThongTinPhim.Controls.Add(this.maPhimTextBox);
            this.gpbThongTinPhim.Controls.Add(tenPhimLabel);
            this.gpbThongTinPhim.Controls.Add(this.tenPhimTextBox);
            this.gpbThongTinPhim.Controls.Add(ngaySanXuatLabel);
            this.gpbThongTinPhim.Controls.Add(this.ngaySanXuatDateTimePicker);
            this.gpbThongTinPhim.Controls.Add(noiDungPhimLabel);
            this.gpbThongTinPhim.Controls.Add(this.noiDungPhimTextBox);
            this.gpbThongTinPhim.Controls.Add(noiDungPhimTomTatLabel);
            this.gpbThongTinPhim.Controls.Add(this.noiDungPhimTomTatTextBox);
            this.gpbThongTinPhim.Controls.Add(diemIMDBLabel);
            this.gpbThongTinPhim.Controls.Add(this.diemIMDBTextBox);
            this.gpbThongTinPhim.Controls.Add(luotXemLabel);
            this.gpbThongTinPhim.Controls.Add(this.luotXemTextBox);
            this.gpbThongTinPhim.Controls.Add(thoiLuongLabel);
            this.gpbThongTinPhim.Controls.Add(this.thoiLuongTextBox);
            this.gpbThongTinPhim.Controls.Add(hinhBannerLabel);
            this.gpbThongTinPhim.Controls.Add(this.hinhBannerTextBox);
            this.gpbThongTinPhim.Controls.Add(linkPhimLabel);
            this.gpbThongTinPhim.Controls.Add(this.linkPhimTextBox);
            this.gpbThongTinPhim.Controls.Add(linkPhimVipLabel);
            this.gpbThongTinPhim.Controls.Add(this.linkPhimVipTextBox);
            this.gpbThongTinPhim.Controls.Add(trailerPhimLabel);
            this.gpbThongTinPhim.Controls.Add(this.trailerPhimTextBox);
            this.gpbThongTinPhim.Controls.Add(maNuocLabel);
            this.gpbThongTinPhim.Controls.Add(this.maNuocTextBox);
            this.gpbThongTinPhim.Controls.Add(maNgonNguLabel);
            this.gpbThongTinPhim.Controls.Add(this.maNgonNguTextBox);
            this.gpbThongTinPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbThongTinPhim.Location = new System.Drawing.Point(0, 27);
            this.gpbThongTinPhim.Name = "gpbThongTinPhim";
            this.gpbThongTinPhim.Size = new System.Drawing.Size(803, 260);
            this.gpbThongTinPhim.TabIndex = 0;
            this.gpbThongTinPhim.TabStop = false;
            this.gpbThongTinPhim.Text = "Thông tin";
            // 
            // maPhimTextBox
            // 
            this.maPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "MaPhim", true));
            this.maPhimTextBox.Location = new System.Drawing.Point(182, 32);
            this.maPhimTextBox.Name = "maPhimTextBox";
            this.maPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.maPhimTextBox.TabIndex = 1;
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
            // tenPhimTextBox
            // 
            this.tenPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "TenPhim", true));
            this.tenPhimTextBox.Location = new System.Drawing.Point(182, 60);
            this.tenPhimTextBox.Name = "tenPhimTextBox";
            this.tenPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.tenPhimTextBox.TabIndex = 3;
            // 
            // ngaySanXuatDateTimePicker
            // 
            this.ngaySanXuatDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phimBindingSource, "NgaySanXuat", true));
            this.ngaySanXuatDateTimePicker.Location = new System.Drawing.Point(182, 88);
            this.ngaySanXuatDateTimePicker.Name = "ngaySanXuatDateTimePicker";
            this.ngaySanXuatDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySanXuatDateTimePicker.TabIndex = 5;
            // 
            // noiDungPhimTextBox
            // 
            this.noiDungPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "NoiDungPhim", true));
            this.noiDungPhimTextBox.Location = new System.Drawing.Point(182, 116);
            this.noiDungPhimTextBox.Name = "noiDungPhimTextBox";
            this.noiDungPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.noiDungPhimTextBox.TabIndex = 7;
            // 
            // noiDungPhimTomTatTextBox
            // 
            this.noiDungPhimTomTatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "NoiDungPhimTomTat", true));
            this.noiDungPhimTomTatTextBox.Location = new System.Drawing.Point(182, 144);
            this.noiDungPhimTomTatTextBox.Name = "noiDungPhimTomTatTextBox";
            this.noiDungPhimTomTatTextBox.Size = new System.Drawing.Size(200, 22);
            this.noiDungPhimTomTatTextBox.TabIndex = 9;
            // 
            // diemIMDBTextBox
            // 
            this.diemIMDBTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "DiemIMDB", true));
            this.diemIMDBTextBox.Location = new System.Drawing.Point(182, 172);
            this.diemIMDBTextBox.Name = "diemIMDBTextBox";
            this.diemIMDBTextBox.Size = new System.Drawing.Size(200, 22);
            this.diemIMDBTextBox.TabIndex = 11;
            // 
            // luotXemTextBox
            // 
            this.luotXemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "LuotXem", true));
            this.luotXemTextBox.Location = new System.Drawing.Point(182, 200);
            this.luotXemTextBox.Name = "luotXemTextBox";
            this.luotXemTextBox.Size = new System.Drawing.Size(200, 22);
            this.luotXemTextBox.TabIndex = 13;
            // 
            // thoiLuongTextBox
            // 
            this.thoiLuongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "ThoiLuong", true));
            this.thoiLuongTextBox.Location = new System.Drawing.Point(566, 32);
            this.thoiLuongTextBox.Name = "thoiLuongTextBox";
            this.thoiLuongTextBox.Size = new System.Drawing.Size(200, 22);
            this.thoiLuongTextBox.TabIndex = 15;
            // 
            // hinhBannerTextBox
            // 
            this.hinhBannerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "HinhBanner", true));
            this.hinhBannerTextBox.Location = new System.Drawing.Point(566, 60);
            this.hinhBannerTextBox.Name = "hinhBannerTextBox";
            this.hinhBannerTextBox.Size = new System.Drawing.Size(200, 22);
            this.hinhBannerTextBox.TabIndex = 17;
            // 
            // linkPhimTextBox
            // 
            this.linkPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "LinkPhim", true));
            this.linkPhimTextBox.Location = new System.Drawing.Point(566, 88);
            this.linkPhimTextBox.Name = "linkPhimTextBox";
            this.linkPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.linkPhimTextBox.TabIndex = 19;
            // 
            // linkPhimVipTextBox
            // 
            this.linkPhimVipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "LinkPhimVip", true));
            this.linkPhimVipTextBox.Location = new System.Drawing.Point(566, 116);
            this.linkPhimVipTextBox.Name = "linkPhimVipTextBox";
            this.linkPhimVipTextBox.Size = new System.Drawing.Size(200, 22);
            this.linkPhimVipTextBox.TabIndex = 21;
            // 
            // trailerPhimTextBox
            // 
            this.trailerPhimTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "TrailerPhim", true));
            this.trailerPhimTextBox.Location = new System.Drawing.Point(566, 144);
            this.trailerPhimTextBox.Name = "trailerPhimTextBox";
            this.trailerPhimTextBox.Size = new System.Drawing.Size(200, 22);
            this.trailerPhimTextBox.TabIndex = 23;
            // 
            // maNuocTextBox
            // 
            this.maNuocTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "MaNuoc", true));
            this.maNuocTextBox.Location = new System.Drawing.Point(566, 172);
            this.maNuocTextBox.Name = "maNuocTextBox";
            this.maNuocTextBox.Size = new System.Drawing.Size(200, 22);
            this.maNuocTextBox.TabIndex = 25;
            // 
            // maNgonNguTextBox
            // 
            this.maNgonNguTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phimBindingSource, "MaNgonNgu", true));
            this.maNgonNguTextBox.Location = new System.Drawing.Point(566, 200);
            this.maNgonNguTextBox.Name = "maNgonNguTextBox";
            this.maNgonNguTextBox.Size = new System.Drawing.Size(200, 22);
            this.maNgonNguTextBox.TabIndex = 27;
            // 
            // gpbBangPhim
            // 
            this.gpbBangPhim.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbBangPhim.Location = new System.Drawing.Point(0, 287);
            this.gpbBangPhim.Name = "gpbBangPhim";
            this.gpbBangPhim.Size = new System.Drawing.Size(803, 340);
            this.gpbBangPhim.TabIndex = 1;
            this.gpbBangPhim.TabStop = false;
            this.gpbBangPhim.Text = "Bảng dữ liệu";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // phimBindingNavigatorSaveItem
            // 
            this.phimBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phimBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phimBindingNavigatorSaveItem.Image")));
            this.phimBindingNavigatorSaveItem.Name = "phimBindingNavigatorSaveItem";
            this.phimBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.phimBindingNavigatorSaveItem.Text = "Save Data";
            this.phimBindingNavigatorSaveItem.Click += new System.EventHandler(this.phimBindingNavigatorSaveItem_Click);
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
            this.phimBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phimBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phimBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phimBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phimBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phimBindingNavigator.Name = "phimBindingNavigator";
            this.phimBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phimBindingNavigator.Size = new System.Drawing.Size(803, 27);
            this.phimBindingNavigator.TabIndex = 2;
            this.phimBindingNavigator.Text = "bindingNavigator1";
            // 
            // QuanLyPhimUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbBangPhim);
            this.Controls.Add(this.gpbThongTinPhim);
            this.Controls.Add(this.phimBindingNavigator);
            this.Name = "QuanLyPhimUserControl";
            this.Size = new System.Drawing.Size(803, 603);
            this.gpbThongTinPhim.ResumeLayout(false);
            this.gpbThongTinPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twooneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimBindingNavigator)).EndInit();
            this.phimBindingNavigator.ResumeLayout(false);
            this.phimBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbThongTinPhim;
        private System.Windows.Forms.GroupBox gpbBangPhim;
        private TwooneDataSet twooneDataSet;
        private System.Windows.Forms.BindingSource phimBindingSource;
        private TwooneDataSetTableAdapters.PhimTableAdapter phimTableAdapter;
        private TwooneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maPhimTextBox;
        private System.Windows.Forms.TextBox tenPhimTextBox;
        private System.Windows.Forms.DateTimePicker ngaySanXuatDateTimePicker;
        private System.Windows.Forms.TextBox noiDungPhimTextBox;
        private System.Windows.Forms.TextBox noiDungPhimTomTatTextBox;
        private System.Windows.Forms.TextBox diemIMDBTextBox;
        private System.Windows.Forms.TextBox luotXemTextBox;
        private System.Windows.Forms.TextBox thoiLuongTextBox;
        private System.Windows.Forms.TextBox hinhBannerTextBox;
        private System.Windows.Forms.TextBox linkPhimTextBox;
        private System.Windows.Forms.TextBox linkPhimVipTextBox;
        private System.Windows.Forms.TextBox trailerPhimTextBox;
        private System.Windows.Forms.TextBox maNuocTextBox;
        private System.Windows.Forms.TextBox maNgonNguTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton phimBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator phimBindingNavigator;
    }
}
