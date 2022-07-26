namespace TwooneWinform.UserControls
{
    partial class QuanLyNguoiDungUserControl1
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
            System.Windows.Forms.Label maNguoiDungLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label taiKhoanLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label hinhAnhNguoiDungLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.twooneDataSet = new TwooneWinform.TwooneDataSet();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungTableAdapter = new TwooneWinform.TwooneDataSetTableAdapters.NguoiDungTableAdapter();
            this.tableAdapterManager = new TwooneWinform.TwooneDataSetTableAdapters.TableAdapterManager();
            this.maNguoiDungTextBox = new System.Windows.Forms.TextBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.taiKhoanTextBox = new System.Windows.Forms.TextBox();
            this.matKhauTextBox = new System.Windows.Forms.TextBox();
            this.hinhAnhNguoiDungTextBox = new System.Windows.Forms.TextBox();
            maNguoiDungLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            taiKhoanLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            hinhAnhNguoiDungLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twooneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(maNguoiDungLabel);
            this.groupBox1.Controls.Add(this.maNguoiDungTextBox);
            this.groupBox1.Controls.Add(hoTenLabel);
            this.groupBox1.Controls.Add(this.hoTenTextBox);
            this.groupBox1.Controls.Add(gioiTinhLabel);
            this.groupBox1.Controls.Add(this.gioiTinhTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.sDTTextBox);
            this.groupBox1.Controls.Add(ngaySinhLabel);
            this.groupBox1.Controls.Add(this.ngaySinhDateTimePicker);
            this.groupBox1.Controls.Add(taiKhoanLabel);
            this.groupBox1.Controls.Add(this.taiKhoanTextBox);
            this.groupBox1.Controls.Add(matKhauLabel);
            this.groupBox1.Controls.Add(this.matKhauTextBox);
            this.groupBox1.Controls.Add(hinhAnhNguoiDungLabel);
            this.groupBox1.Controls.Add(this.hinhAnhNguoiDungTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // twooneDataSet
            // 
            this.twooneDataSet.DataSetName = "TwooneDataSet";
            this.twooneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.twooneDataSet;
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NguoiDungTableAdapter = this.nguoiDungTableAdapter;
            this.tableAdapterManager.PhieuDangKyTableAdapter = null;
            this.tableAdapterManager.PhimTableAdapter = null;
            this.tableAdapterManager.TheLoaiCuaPhimTableAdapter = null;
            this.tableAdapterManager.TheLoaiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TwooneWinform.TwooneDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maNguoiDungLabel
            // 
            maNguoiDungLabel.AutoSize = true;
            maNguoiDungLabel.Location = new System.Drawing.Point(55, 40);
            maNguoiDungLabel.Name = "maNguoiDungLabel";
            maNguoiDungLabel.Size = new System.Drawing.Size(103, 16);
            maNguoiDungLabel.TabIndex = 0;
            maNguoiDungLabel.Text = "Ma Nguoi Dung:";
            // 
            // maNguoiDungTextBox
            // 
            this.maNguoiDungTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "MaNguoiDung", true));
            this.maNguoiDungTextBox.Location = new System.Drawing.Point(198, 37);
            this.maNguoiDungTextBox.Name = "maNguoiDungTextBox";
            this.maNguoiDungTextBox.Size = new System.Drawing.Size(200, 22);
            this.maNguoiDungTextBox.TabIndex = 1;
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(55, 68);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(55, 16);
            hoTenLabel.TabIndex = 2;
            hoTenLabel.Text = "Ho Ten:";
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "HoTen", true));
            this.hoTenTextBox.Location = new System.Drawing.Point(198, 65);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(200, 22);
            this.hoTenTextBox.TabIndex = 3;
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(55, 96);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(63, 16);
            gioiTinhLabel.TabIndex = 4;
            gioiTinhLabel.Text = "Gioi Tinh:";
            // 
            // gioiTinhTextBox
            // 
            this.gioiTinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "GioiTinh", true));
            this.gioiTinhTextBox.Location = new System.Drawing.Point(198, 93);
            this.gioiTinhTextBox.Name = "gioiTinhTextBox";
            this.gioiTinhTextBox.Size = new System.Drawing.Size(200, 22);
            this.gioiTinhTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(55, 124);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(198, 121);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(55, 152);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(38, 16);
            sDTLabel.TabIndex = 8;
            sDTLabel.Text = "SDT:";
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(198, 149);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(200, 22);
            this.sDTTextBox.TabIndex = 9;
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(55, 181);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(72, 16);
            ngaySinhLabel.TabIndex = 10;
            ngaySinhLabel.Text = "Ngay Sinh:";
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nguoiDungBindingSource, "NgaySinh", true));
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(198, 177);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.ngaySinhDateTimePicker.TabIndex = 11;
            // 
            // taiKhoanLabel
            // 
            taiKhoanLabel.AutoSize = true;
            taiKhoanLabel.Location = new System.Drawing.Point(55, 208);
            taiKhoanLabel.Name = "taiKhoanLabel";
            taiKhoanLabel.Size = new System.Drawing.Size(71, 16);
            taiKhoanLabel.TabIndex = 12;
            taiKhoanLabel.Text = "Tai Khoan:";
            // 
            // taiKhoanTextBox
            // 
            this.taiKhoanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "TaiKhoan", true));
            this.taiKhoanTextBox.Location = new System.Drawing.Point(198, 205);
            this.taiKhoanTextBox.Name = "taiKhoanTextBox";
            this.taiKhoanTextBox.Size = new System.Drawing.Size(200, 22);
            this.taiKhoanTextBox.TabIndex = 13;
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(55, 236);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(65, 16);
            matKhauLabel.TabIndex = 14;
            matKhauLabel.Text = "Mat Khau:";
            // 
            // matKhauTextBox
            // 
            this.matKhauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "MatKhau", true));
            this.matKhauTextBox.Location = new System.Drawing.Point(198, 233);
            this.matKhauTextBox.Name = "matKhauTextBox";
            this.matKhauTextBox.Size = new System.Drawing.Size(200, 22);
            this.matKhauTextBox.TabIndex = 15;
            // 
            // hinhAnhNguoiDungLabel
            // 
            hinhAnhNguoiDungLabel.AutoSize = true;
            hinhAnhNguoiDungLabel.Location = new System.Drawing.Point(55, 264);
            hinhAnhNguoiDungLabel.Name = "hinhAnhNguoiDungLabel";
            hinhAnhNguoiDungLabel.Size = new System.Drawing.Size(137, 16);
            hinhAnhNguoiDungLabel.TabIndex = 16;
            hinhAnhNguoiDungLabel.Text = "Hinh Anh Nguoi Dung:";
            // 
            // hinhAnhNguoiDungTextBox
            // 
            this.hinhAnhNguoiDungTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nguoiDungBindingSource, "HinhAnhNguoiDung", true));
            this.hinhAnhNguoiDungTextBox.Location = new System.Drawing.Point(198, 261);
            this.hinhAnhNguoiDungTextBox.Name = "hinhAnhNguoiDungTextBox";
            this.hinhAnhNguoiDungTextBox.Size = new System.Drawing.Size(200, 22);
            this.hinhAnhNguoiDungTextBox.TabIndex = 17;
            // 
            // QuanLyNguoiDungUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyNguoiDungUserControl1";
            this.Size = new System.Drawing.Size(803, 603);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twooneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private TwooneDataSet twooneDataSet;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private TwooneDataSetTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private TwooneDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maNguoiDungTextBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.TextBox gioiTinhTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.DateTimePicker ngaySinhDateTimePicker;
        private System.Windows.Forms.TextBox taiKhoanTextBox;
        private System.Windows.Forms.TextBox matKhauTextBox;
        private System.Windows.Forms.TextBox hinhAnhNguoiDungTextBox;
    }
}
