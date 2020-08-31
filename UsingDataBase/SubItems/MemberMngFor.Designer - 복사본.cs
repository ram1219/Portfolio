namespace _02.UsingDataBase.SubItems
{
	partial class MemberMngForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.GridMembersTbl = new MetroFramework.Controls.MetroGrid();
			this.Title = new System.Windows.Forms.GroupBox();
			this.CboLevels = new MetroFramework.Controls.MetroComboBox();
			this.BtnCancel = new MetroFramework.Controls.MetroButton();
			this.BtnSave = new MetroFramework.Controls.MetroButton();
			this.btnNew = new MetroFramework.Controls.MetroButton();
			this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
			this.TxtMobile = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.mobile = new MetroFramework.Controls.MetroLabel();
			this.TxtAddress = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.TxtNames = new MetroFramework.Controls.MetroTextBox();
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
			this.GridMembersTbl.BackgroundColor = System.Drawing.Color.LightYellow;
			this.GridMembersTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.GridMembersTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.GridMembersTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridMembersTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.GridMembersTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridMembersTbl.DefaultCellStyle = dataGridViewCellStyle2;
			this.GridMembersTbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridMembersTbl.EnableHeadersVisualStyles = false;
			this.GridMembersTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.GridMembersTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.GridMembersTbl.Location = new System.Drawing.Point(0, 0);
			this.GridMembersTbl.Name = "GridMembersTbl";
			this.GridMembersTbl.ReadOnly = true;
			this.GridMembersTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridMembersTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.GridMembersTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.GridMembersTbl.RowTemplate.Height = 23;
			this.GridMembersTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridMembersTbl.Size = new System.Drawing.Size(485, 620);
			this.GridMembersTbl.TabIndex = 0;
			this.GridMembersTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDivTbl_CellClick);
			// 
			// Title
			// 
			this.Title.Controls.Add(this.CboLevels);
			this.Title.Controls.Add(this.BtnCancel);
			this.Title.Controls.Add(this.BtnSave);
			this.Title.Controls.Add(this.btnNew);
			this.Title.Controls.Add(this.TxtEmail);
			this.Title.Controls.Add(this.TxtMobile);
			this.Title.Controls.Add(this.TxtNames);
			this.Title.Controls.Add(this.metroLabel7);
			this.Title.Controls.Add(this.mobile);
			this.Title.Controls.Add(this.TxtAddress);
			this.Title.Controls.Add(this.metroLabel4);
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
			// CboLevels
			// 
			this.CboLevels.FormattingEnabled = true;
			this.CboLevels.ItemHeight = 23;
			this.CboLevels.Location = new System.Drawing.Point(90, 148);
			this.CboLevels.Name = "CboLevels";
			this.CboLevels.Size = new System.Drawing.Size(254, 29);
			this.CboLevels.TabIndex = 2;
			this.CboLevels.UseSelectable = true;
			// 
			// BtnCancel
			// 
			this.BtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.BtnCancel.Location = new System.Drawing.Point(264, 321);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(81, 34);
			this.BtnCancel.TabIndex = 10;
			this.BtnCancel.Text = "취소";
			this.BtnCancel.UseSelectable = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnSave
			// 
			this.BtnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.BtnSave.Location = new System.Drawing.Point(177, 321);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(81, 34);
			this.BtnSave.TabIndex = 8;
			this.BtnSave.Text = "저장";
			this.BtnSave.UseSelectable = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// btnNew
			// 
			this.btnNew.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnNew.Location = new System.Drawing.Point(90, 321);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(81, 34);
			this.btnNew.TabIndex = 7;
			this.btnNew.Text = "신규";
			this.btnNew.UseSelectable = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// TxtEmail
			// 
			// 
			// 
			// 
			this.TxtEmail.CustomButton.Image = null;
			this.TxtEmail.CustomButton.Location = new System.Drawing.Point(233, 1);
			this.TxtEmail.CustomButton.Name = "";
			this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtEmail.CustomButton.TabIndex = 1;
			this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtEmail.CustomButton.UseSelectable = true;
			this.TxtEmail.CustomButton.Visible = false;
			this.TxtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.TxtEmail.Lines = new string[0];
			this.TxtEmail.Location = new System.Drawing.Point(90, 273);
			this.TxtEmail.MaxLength = 45;
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.PasswordChar = '\0';
			this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtEmail.SelectedText = "";
			this.TxtEmail.SelectionLength = 0;
			this.TxtEmail.SelectionStart = 0;
			this.TxtEmail.ShortcutsEnabled = true;
			this.TxtEmail.Size = new System.Drawing.Size(255, 23);
			this.TxtEmail.TabIndex = 6;
			this.TxtEmail.UseSelectable = true;
			this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNames_KeyPress);
			// 
			// TxtMobile
			// 
			// 
			// 
			// 
			this.TxtMobile.CustomButton.Image = null;
			this.TxtMobile.CustomButton.Location = new System.Drawing.Point(233, 1);
			this.TxtMobile.CustomButton.Name = "";
			this.TxtMobile.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtMobile.CustomButton.TabIndex = 1;
			this.TxtMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtMobile.CustomButton.UseSelectable = true;
			this.TxtMobile.CustomButton.Visible = false;
			this.TxtMobile.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.TxtMobile.Lines = new string[0];
			this.TxtMobile.Location = new System.Drawing.Point(90, 231);
			this.TxtMobile.MaxLength = 13;
			this.TxtMobile.Name = "TxtMobile";
			this.TxtMobile.PasswordChar = '\0';
			this.TxtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtMobile.SelectedText = "";
			this.TxtMobile.SelectionLength = 0;
			this.TxtMobile.SelectionStart = 0;
			this.TxtMobile.ShortcutsEnabled = true;
			this.TxtMobile.Size = new System.Drawing.Size(255, 23);
			this.TxtMobile.TabIndex = 5;
			this.TxtMobile.UseSelectable = true;
			this.TxtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TxtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNames_KeyPress);
			// 
			// metroLabel7
			// 
			this.metroLabel7.Location = new System.Drawing.Point(21, 273);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(62, 20);
			this.metroLabel7.TabIndex = 1;
			this.metroLabel7.Text = "이메일 : ";
			this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// mobile
			// 
			this.mobile.Location = new System.Drawing.Point(6, 231);
			this.mobile.Name = "mobile";
			this.mobile.Size = new System.Drawing.Size(76, 20);
			this.mobile.TabIndex = 1;
			this.mobile.Text = "전화번호 : ";
			this.mobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtAddress
			// 
			// 
			// 
			// 
			this.TxtAddress.CustomButton.Image = null;
			this.TxtAddress.CustomButton.Location = new System.Drawing.Point(232, 1);
			this.TxtAddress.CustomButton.Name = "";
			this.TxtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtAddress.CustomButton.TabIndex = 1;
			this.TxtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtAddress.CustomButton.UseSelectable = true;
			this.TxtAddress.CustomButton.Visible = false;
			this.TxtAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.TxtAddress.Lines = new string[0];
			this.TxtAddress.Location = new System.Drawing.Point(90, 191);
			this.TxtAddress.MaxLength = 45;
			this.TxtAddress.Name = "TxtAddress";
			this.TxtAddress.PasswordChar = '\0';
			this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtAddress.SelectedText = "";
			this.TxtAddress.SelectionLength = 0;
			this.TxtAddress.SelectionStart = 0;
			this.TxtAddress.ShortcutsEnabled = true;
			this.TxtAddress.Size = new System.Drawing.Size(254, 23);
			this.TxtAddress.TabIndex = 1;
			this.TxtAddress.UseSelectable = true;
			this.TxtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TxtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNames_KeyPress);
			// 
			// metroLabel4
			// 
			this.metroLabel4.Location = new System.Drawing.Point(25, 106);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(58, 20);
			this.metroLabel4.TabIndex = 1;
			this.metroLabel4.Text = "이름 : ";
			this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.TxtIdx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDivision_KeyPress);
			// 
			// metroLabel3
			// 
			this.metroLabel3.Location = new System.Drawing.Point(21, 148);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(61, 20);
			this.metroLabel3.TabIndex = 1;
			this.metroLabel3.Text = "Levels : ";
			this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroLabel2
			// 
			this.metroLabel2.Location = new System.Drawing.Point(21, 191);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(58, 20);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "주소 : ";
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
			// TxtNames
			// 
			// 
			// 
			// 
			this.TxtNames.CustomButton.Image = null;
			this.TxtNames.CustomButton.Location = new System.Drawing.Point(233, 1);
			this.TxtNames.CustomButton.Name = "";
			this.TxtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtNames.CustomButton.TabIndex = 1;
			this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtNames.CustomButton.UseSelectable = true;
			this.TxtNames.CustomButton.Visible = false;
			this.TxtNames.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.TxtNames.Lines = new string[0];
			this.TxtNames.Location = new System.Drawing.Point(89, 106);
			this.TxtNames.MaxLength = 100;
			this.TxtNames.Name = "TxtNames";
			this.TxtNames.PasswordChar = '\0';
			this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtNames.SelectedText = "";
			this.TxtNames.SelectionLength = 0;
			this.TxtNames.SelectionStart = 0;
			this.TxtNames.ShortcutsEnabled = true;
			this.TxtNames.Size = new System.Drawing.Size(255, 23);
			this.TxtNames.TabIndex = 3;
			this.TxtNames.UseSelectable = true;
			this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TxtNames.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNames_KeyPress);
			// 
			// MemberMngForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 700);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MemberMngForm";
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "MemberMngForm";
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
		private MetroFramework.Controls.MetroTextBox TxtAddress;
		private MetroFramework.Controls.MetroTextBox TxtIdx;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroComboBox CboLevels;
		private MetroFramework.Controls.MetroTextBox TxtEmail;
		private MetroFramework.Controls.MetroTextBox TxtMobile;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroLabel mobile;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox TxtNames;
	}
}