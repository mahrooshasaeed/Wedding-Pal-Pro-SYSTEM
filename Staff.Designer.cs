namespace Wedding_Pal_Pro_SYSTEM
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.staffnametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.staffgender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.staffphonetb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staffpass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addstaffbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.resetstaffbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deletestaffbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editstaffbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.StaffDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 45);
            this.panel1.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(1030, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 35);
            this.label21.TabIndex = 12;
            this.label21.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 35);
            this.label8.TabIndex = 11;
            this.label8.Text = "STAFF";
            // 
            // staffnametb
            // 
            this.staffnametb.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffnametb.Location = new System.Drawing.Point(138, 90);
            this.staffnametb.Name = "staffnametb";
            this.staffnametb.Size = new System.Drawing.Size(143, 23);
            this.staffnametb.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(282, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phone No:";
            // 
            // staffgender
            // 
            this.staffgender.Font = new System.Drawing.Font("Lucida Fax", 9.75F);
            this.staffgender.FormattingEnabled = true;
            this.staffgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.staffgender.Location = new System.Drawing.Point(648, 92);
            this.staffgender.Name = "staffgender";
            this.staffgender.Size = new System.Drawing.Size(96, 24);
            this.staffgender.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // staffphonetb
            // 
            this.staffphonetb.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffphonetb.Location = new System.Drawing.Point(406, 92);
            this.staffphonetb.Name = "staffphonetb";
            this.staffphonetb.Size = new System.Drawing.Size(143, 23);
            this.staffphonetb.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(552, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(756, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password:";
            // 
            // staffpass
            // 
            this.staffpass.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffpass.Location = new System.Drawing.Point(874, 92);
            this.staffpass.Name = "staffpass";
            this.staffpass.Size = new System.Drawing.Size(134, 23);
            this.staffpass.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(437, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 32);
            this.label5.TabIndex = 39;
            this.label5.Text = "Booking List:";
            // 
            // addstaffbtn
            // 
            this.addstaffbtn.ActiveBorderThickness = 1;
            this.addstaffbtn.ActiveCornerRadius = 20;
            this.addstaffbtn.ActiveFillColor = System.Drawing.Color.Maroon;
            this.addstaffbtn.ActiveForecolor = System.Drawing.Color.White;
            this.addstaffbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addstaffbtn.BackColor = System.Drawing.SystemColors.Control;
            this.addstaffbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addstaffbtn.BackgroundImage")));
            this.addstaffbtn.ButtonText = "Add Staff";
            this.addstaffbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addstaffbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstaffbtn.ForeColor = System.Drawing.Color.Maroon;
            this.addstaffbtn.IdleBorderThickness = 1;
            this.addstaffbtn.IdleCornerRadius = 20;
            this.addstaffbtn.IdleFillColor = System.Drawing.Color.White;
            this.addstaffbtn.IdleForecolor = System.Drawing.Color.Maroon;
            this.addstaffbtn.IdleLineColor = System.Drawing.Color.Maroon;
            this.addstaffbtn.Location = new System.Drawing.Point(178, 142);
            this.addstaffbtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.addstaffbtn.Name = "addstaffbtn";
            this.addstaffbtn.Size = new System.Drawing.Size(176, 50);
            this.addstaffbtn.TabIndex = 41;
            this.addstaffbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addstaffbtn.Click += new System.EventHandler(this.addstaffbtn_Click);
            // 
            // resetstaffbtn
            // 
            this.resetstaffbtn.ActiveBorderThickness = 1;
            this.resetstaffbtn.ActiveCornerRadius = 20;
            this.resetstaffbtn.ActiveFillColor = System.Drawing.Color.Maroon;
            this.resetstaffbtn.ActiveForecolor = System.Drawing.Color.White;
            this.resetstaffbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetstaffbtn.BackColor = System.Drawing.SystemColors.Control;
            this.resetstaffbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetstaffbtn.BackgroundImage")));
            this.resetstaffbtn.ButtonText = "Reset";
            this.resetstaffbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetstaffbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetstaffbtn.ForeColor = System.Drawing.Color.Maroon;
            this.resetstaffbtn.IdleBorderThickness = 1;
            this.resetstaffbtn.IdleCornerRadius = 20;
            this.resetstaffbtn.IdleFillColor = System.Drawing.Color.White;
            this.resetstaffbtn.IdleForecolor = System.Drawing.Color.Maroon;
            this.resetstaffbtn.IdleLineColor = System.Drawing.Color.Maroon;
            this.resetstaffbtn.Location = new System.Drawing.Point(742, 142);
            this.resetstaffbtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.resetstaffbtn.Name = "resetstaffbtn";
            this.resetstaffbtn.Size = new System.Drawing.Size(176, 50);
            this.resetstaffbtn.TabIndex = 40;
            this.resetstaffbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deletestaffbtn
            // 
            this.deletestaffbtn.ActiveBorderThickness = 1;
            this.deletestaffbtn.ActiveCornerRadius = 20;
            this.deletestaffbtn.ActiveFillColor = System.Drawing.Color.Maroon;
            this.deletestaffbtn.ActiveForecolor = System.Drawing.Color.White;
            this.deletestaffbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deletestaffbtn.BackColor = System.Drawing.SystemColors.Control;
            this.deletestaffbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletestaffbtn.BackgroundImage")));
            this.deletestaffbtn.ButtonText = "Delete Staff";
            this.deletestaffbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletestaffbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletestaffbtn.ForeColor = System.Drawing.Color.Maroon;
            this.deletestaffbtn.IdleBorderThickness = 1;
            this.deletestaffbtn.IdleCornerRadius = 20;
            this.deletestaffbtn.IdleFillColor = System.Drawing.Color.White;
            this.deletestaffbtn.IdleForecolor = System.Drawing.Color.Maroon;
            this.deletestaffbtn.IdleLineColor = System.Drawing.Color.Maroon;
            this.deletestaffbtn.Location = new System.Drawing.Point(554, 142);
            this.deletestaffbtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.deletestaffbtn.Name = "deletestaffbtn";
            this.deletestaffbtn.Size = new System.Drawing.Size(176, 50);
            this.deletestaffbtn.TabIndex = 43;
            this.deletestaffbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editstaffbtn
            // 
            this.editstaffbtn.ActiveBorderThickness = 1;
            this.editstaffbtn.ActiveCornerRadius = 20;
            this.editstaffbtn.ActiveFillColor = System.Drawing.Color.Maroon;
            this.editstaffbtn.ActiveForecolor = System.Drawing.Color.White;
            this.editstaffbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editstaffbtn.BackColor = System.Drawing.SystemColors.Control;
            this.editstaffbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editstaffbtn.BackgroundImage")));
            this.editstaffbtn.ButtonText = "Edit  Staff";
            this.editstaffbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editstaffbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editstaffbtn.ForeColor = System.Drawing.Color.Maroon;
            this.editstaffbtn.IdleBorderThickness = 1;
            this.editstaffbtn.IdleCornerRadius = 20;
            this.editstaffbtn.IdleFillColor = System.Drawing.Color.White;
            this.editstaffbtn.IdleForecolor = System.Drawing.Color.Maroon;
            this.editstaffbtn.IdleLineColor = System.Drawing.Color.Maroon;
            this.editstaffbtn.Location = new System.Drawing.Point(366, 142);
            this.editstaffbtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.editstaffbtn.Name = "editstaffbtn";
            this.editstaffbtn.Size = new System.Drawing.Size(176, 50);
            this.editstaffbtn.TabIndex = 44;
            this.editstaffbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Back";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.Location = new System.Drawing.Point(463, 573);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(176, 50);
            this.bunifuThinButton21.TabIndex = 45;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaffDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.StaffDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StaffDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffDGV.BackgroundColor = System.Drawing.Color.White;
            this.StaffDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.StaffDGV.ColumnHeadersHeight = 28;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.StaffDGV.EnableHeadersVisualStyles = false;
            this.StaffDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffDGV.Location = new System.Drawing.Point(72, 241);
            this.StaffDGV.Name = "StaffDGV";
            this.StaffDGV.RowHeadersVisible = false;
            this.StaffDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffDGV.Size = new System.Drawing.Size(920, 319);
            this.StaffDGV.TabIndex = 58;
            this.StaffDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StaffDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StaffDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StaffDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Brown;
            this.StaffDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StaffDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffDGV.ThemeStyle.HeaderStyle.Height = 28;
            this.StaffDGV.ThemeStyle.ReadOnly = false;
            this.StaffDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StaffDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffDGV.ThemeStyle.RowsStyle.Height = 22;
            this.StaffDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 788);
            this.Controls.Add(this.StaffDGV);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.editstaffbtn);
            this.Controls.Add(this.deletestaffbtn);
            this.Controls.Add(this.addstaffbtn);
            this.Controls.Add(this.resetstaffbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.staffpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffphonetb);
            this.Controls.Add(this.staffnametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffgender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox staffnametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox staffgender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staffphonetb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox staffpass;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 addstaffbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 resetstaffbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 deletestaffbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 editstaffbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Guna.UI.WinForms.GunaDataGridView StaffDGV;
    }
}