namespace TwooneWinform.Forms
{
    partial class LayoutForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblForm = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnQLPhim = new System.Windows.Forms.Button();
            this.btnQLNguoiDung = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 77);
            this.panel1.TabIndex = 1;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm.Location = new System.Drawing.Point(517, 9);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(181, 49);
            this.lblForm.TabIndex = 0;
            this.lblForm.Text = "Trang chủ";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Location = new System.Drawing.Point(172, 77);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(946, 516);
            this.pnlContainer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANG CHỦ";
            // 
            // flpMenu
            // 
            this.flpMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flpMenu.Controls.Add(this.btnQLPhim);
            this.flpMenu.Controls.Add(this.btnQLNguoiDung);
            this.flpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenu.Location = new System.Drawing.Point(0, 77);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(172, 516);
            this.flpMenu.TabIndex = 3;
            // 
            // btnQLPhim
            // 
            this.btnQLPhim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLPhim.BackColor = System.Drawing.Color.Black;
            this.btnQLPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQLPhim.FlatAppearance.BorderSize = 0;
            this.btnQLPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhim.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPhim.ForeColor = System.Drawing.Color.White;
            this.btnQLPhim.Location = new System.Drawing.Point(0, 0);
            this.btnQLPhim.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLPhim.Name = "btnQLPhim";
            this.btnQLPhim.Size = new System.Drawing.Size(172, 68);
            this.btnQLPhim.TabIndex = 1;
            this.btnQLPhim.Text = "Quản lý Phim";
            this.btnQLPhim.UseVisualStyleBackColor = false;
            this.btnQLPhim.Click += new System.EventHandler(this.btnQLPhim_Click);
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQLNguoiDung.BackColor = System.Drawing.Color.Black;
            this.btnQLNguoiDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQLNguoiDung.FlatAppearance.BorderSize = 0;
            this.btnQLNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNguoiDung.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNguoiDung.ForeColor = System.Drawing.Color.White;
            this.btnQLNguoiDung.Location = new System.Drawing.Point(0, 68);
            this.btnQLNguoiDung.Margin = new System.Windows.Forms.Padding(0);
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            this.btnQLNguoiDung.Size = new System.Drawing.Size(172, 68);
            this.btnQLNguoiDung.TabIndex = 2;
            this.btnQLNguoiDung.Text = "Quản lý Người dùng";
            this.btnQLNguoiDung.UseVisualStyleBackColor = false;
            // 
            // LayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 593);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Name = "LayoutForm";
            this.Text = "LayoutForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnQLPhim;
        private System.Windows.Forms.Button btnQLNguoiDung;
    }
}