namespace _02.UsingDataBase.SubItems
{
	partial class RentalMngForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.GridMembersTbl = new MetroFramework.Controls.MetroGrid();
			this.Title = new System.Windows.Forms.GroupBox();
			this.BtnExcel = new MetroFramework.Controls.MetroButton();
			this.DtireturnDate = new MetroFramework.Controls.MetroDateTime();
			this.DtirentalDate = new MetroFramework.Controls.MetroDateTime();
			this.CboMember = new MetroFramework.Controls.MetroComboBox();
			this.CboBookNames = new MetroFramework.Controls.MetroComboBox();
			this.BtnCancel = new MetroFramework.Controls.MetroButton();
			this.BtnSave = new MetroFramework.Controls.MetroButton();
			this.btnNew = new MetroFramework.Controls.MetroButton();
			this.mobile = new MetroFramework.Controls.MetroLabel();
			this.CboMembers = new MetroFramework.Controls.MetroLabel();
			this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridMembersTbl)).BeginInit();
			this.Title.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(20, 60);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.GridMembersTbl);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.Title);
			this.splitContainer1.Size = new System.Drawing.Size(860, 620);
			this.splitContainer1.SplitterDistance = 485;
			this.splitContainer1.TabIndex = 0;
			// 
			// GridMembersTbl
			// 
			this.GridMembersTbl.AllowUserToResizeRows = false;
			this.GridMembersTbl.BackgroundColor = System.Drawing.Color.Thistle;
			this.GridMembersTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.GridMembersTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.GridMembersTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridMembersTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.GridMembersTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridMembersTbl.DefaultCellStyle = dataGridViewCellStyle8;
			this.GridMembersTbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridMembersTbl.EnableHeadersVisualStyles = false;
			this.GridMembersTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.GridMembersTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.GridMembersTbl.Location = new System.Drawing.Point(0, 0);
			this.GridMembersTbl.Name = "GridMembersTbl";
			this.GridMembersTbl.ReadOnly = true;
			this.GridMembersTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridMembersTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.GridMembersTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.GridMembersTbl.RowTemplate.Height = 23;
			this.GridMembersTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridMembersTbl.Size = new System.Drawing.Size(485, 620);
			this.GridMembersTbl.TabIndex = 0;
			this.GridMembersTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMembersTbl_CellClick);
			// 
			// Title
			// 
			this.Title.Controls.Add(this.BtnExcel);
			this.Title.Controls.Add(this.DtireturnDate);
			this.Title.Controls.Add(this.DtirentalDate);
			this.Title.Controls.Add(this.CboMember);
			this.Title.Controls.Add(this.CboBookNames);
			this.Title.Controls.Add(this.BtnCancel);
			this.Title.Controls.Add(this.BtnSave);
			this.Title.Controls.Add(this.btnNew);
			this.Title.Controls.Add(this.mobile);
			this.Title.Controls.Add(this.CboMembers);
			this.Title.Controls.Add(this.TxtIdx);
			this.Title.Controls.Add(this.metroLabel3);
			this.Title.Controls.Add(this.metroLabel2);
			this.Title.Controls.Add(this.metroLabel1);
			this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Title.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Title.Location = new System.Drawing.Point(0, 0);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(371, 620);
			this.Title.TabIndex = 0;
			this.Title.TabStop = false;
			this.Title.Text = "상세";
			// 
			// BtnExcel
			// 
			this.BtnExcel.Location = new System.Drawing.Point(88, 344);
			this.BtnExcel.Name = "BtnExcel";
			this.BtnExcel.Size = new System.Drawing.Size(254, 23);
			this.BtnExcel.TabIndex = 8;
			this.BtnExcel.Text = "Excel Export";
			this.BtnExcel.UseSelectable = true;
			this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
			// 
			// DtireturnDate
			// 
			this.DtireturnDate.Location = new System.Drawing.Point(88, 231);
			this.DtireturnDate.MinimumSize = new System.Drawing.Size(0, 29);
			this.DtireturnDate.Name = "DtireturnDate";
			this.DtireturnDate.Size = new System.Drawing.Size(254, 29);
			this.DtireturnDate.TabIndex = 4;
			this.DtireturnDate.ValueChanged += new System.EventHandler(this.DtireturnDate_ValueChanged);
			// 
			// DtirentalDate
			// 
			this.DtirentalDate.Location = new System.Drawing.Point(88, 191);
			this.DtirentalDate.MinimumSize = new System.Drawing.Size(0, 29);
			this.DtirentalDate.Name = "DtirentalDate";
			this.DtirentalDate.Size = new System.Drawing.Size(254, 29);
			this.DtirentalDate.TabIndex = 3;
			// 
			// CboMember
			// 
			this.CboMember.FormattingEnabled = true;
			this.CboMember.ItemHeight = 23;
			this.CboMember.Location = new System.Drawing.Point(88, 106);
			this.CboMember.Name = "CboMember";
			this.CboMember.Size = new System.Drawing.Size(254, 29);
			this.CboMember.TabIndex = 1;
			this.CboMember.UseSelectable = true;
			// 
			// CboBookNames
			// 
			this.CboBookNames.FormattingEnabled = true;
			this.CboBookNames.ItemHeight = 23;
			this.CboBookNames.Location = new System.Drawing.Point(88, 148);
			this.CboBookNames.Name = "CboBookNames";
			this.CboBookNames.Size = new System.Drawing.Size(254, 29);
			this.CboBookNames.TabIndex = 2;
			this.CboBookNames.UseSelectable = true;
			// 
			// BtnCancel
			// 
			this.BtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.BtnCancel.Location = new System.Drawing.Point(261, 293);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(81, 34);
			this.BtnCancel.TabIndex = 7;
			this.BtnCancel.Text = "취소";
			this.BtnCancel.UseSelectable = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnSave
			// 
			this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.BtnSave.Location = new System.Drawing.Point(174, 293);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(81, 34);
			this.BtnSave.TabIndex = 6;
			this.BtnSave.Text = "저장";
			this.BtnSave.UseSelectable = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// btnNew
			// 
			this.btnNew.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnNew.Location = new System.Drawing.Point(87, 293);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(81, 34);
			this.btnNew.TabIndex = 5;
			this.btnNew.Text = "신규";
			this.btnNew.UseSelectable = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// mobile
			// 
			this.mobile.Location = new System.Drawing.Point(6, 234);
			this.mobile.Name = "mobile";
			this.mobile.Size = new System.Drawing.Size(76, 20);
			this.mobile.TabIndex = 1;
			this.mobile.Text = "반납일 : ";
			this.mobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CboMembers
			// 
			this.CboMembers.Location = new System.Drawing.Point(25, 106);
			this.CboMembers.Name = "CboMembers";
			this.CboMembers.Size = new System.Drawing.Size(58, 20);
			this.CboMembers.TabIndex = 1;
			this.CboMembers.Text = "회원 : ";
			this.CboMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtIdx
			// 
			// 
			// 
			// 
			this.TxtIdx.CustomButton.Image = null;
			this.TxtIdx.CustomButton.Location = new System.Drawing.Point(232, 1);
			this.TxtIdx.CustomButton.Name = "";
			this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtIdx.CustomButton.TabIndex = 1;
			this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtIdx.CustomButton.UseSelectable = true;
			this.TxtIdx.CustomButton.Visible = false;
			this.TxtIdx.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.TxtIdx.Lines = new string[0];
			this.TxtIdx.Location = new System.Drawing.Point(88, 70);
			this.TxtIdx.MaxLength = 12;
			this.TxtIdx.Name = "TxtIdx";
			this.TxtIdx.PasswordChar = '\0';
			this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtIdx.SelectedText = "";
			this.TxtIdx.SelectionLength = 0;
			this.TxtIdx.SelectionStart = 0;
			this.TxtIdx.ShortcutsEnabled = true;
			this.TxtIdx.Size = new System.Drawing.Size(254, 23);
			this.TxtIdx.TabIndex = 0;
			this.TxtIdx.UseSelectable = true;
			this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// metroLabel3
			// 
			this.metroLabel3.Location = new System.Drawing.Point(21, 150);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(61, 20);
			this.metroLabel3.TabIndex = 2;
			this.metroLabel3.Text = "책 : ";
			this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroLabel2
			// 
			this.metroLabel2.Location = new System.Drawing.Point(8, 192);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(73, 20);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "대여일 : ";
			this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroLabel1
			// 
			this.metroLabel1.Location = new System.Drawing.Point(25, 70);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(57, 20);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "번호 : ";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// RentalMngForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 700);
			this.Controls.Add(this.splitContainer1);
			this.Name = "RentalMngForm";
			this.Style = MetroFramework.MetroColorStyle.Pink;
			this.Text = "RentalMngForm";
			this.Load += new System.EventHandler(this.DivMngForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridMembersTbl)).EndInit();
			this.Title.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private MetroFramework.Controls.MetroGrid GridMembersTbl;
		private System.Windows.Forms.GroupBox Title;
		private MetroFramework.Controls.MetroButton BtnCancel;
		private MetroFramework.Controls.MetroButton BtnSave;
		private MetroFramework.Controls.MetroButton btnNew;
		private MetroFramework.Controls.MetroTextBox TxtIdx;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox CboBookNames;
		private MetroFramework.Controls.MetroLabel mobile;
		private MetroFramework.Controls.MetroLabel CboMembers;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroComboBox CboMember;
		private MetroFramework.Controls.MetroDateTime DtireturnDate;
		private MetroFramework.Controls.MetroDateTime DtirentalDate;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroButton BtnExcel;
	}
}