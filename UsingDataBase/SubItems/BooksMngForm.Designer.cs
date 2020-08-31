namespace _02.UsingDataBase.SubItems
{
	partial class BooksMngForm
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
			this.GridBooksTbl = new MetroFramework.Controls.MetroGrid();
			this.Title = new System.Windows.Forms.GroupBox();
			this.DtReleaseDate = new MetroFramework.Controls.MetroDateTime();
			this.CboDivision = new MetroFramework.Controls.MetroComboBox();
			this.BtnCancel = new MetroFramework.Controls.MetroButton();
			this.BtnSave = new MetroFramework.Controls.MetroButton();
			this.btnNew = new MetroFramework.Controls.MetroButton();
			this.BtnDelete = new MetroFramework.Controls.MetroButton();
			this.TxtPrice = new MetroFramework.Controls.MetroTextBox();
			this.TxtIsbn = new MetroFramework.Controls.MetroTextBox();
			this.TxtNames = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
			this.Isbn = new MetroFramework.Controls.MetroLabel();
			this.TxtAuthor = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GridBooksTbl)).BeginInit();
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
			this.splitContainer1.Panel1.Controls.Add(this.GridBooksTbl);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.Title);
			this.splitContainer1.Size = new System.Drawing.Size(860, 620);
			this.splitContainer1.SplitterDistance = 453;
			this.splitContainer1.TabIndex = 0;
			// 
			// GridBooksTbl
			// 
			this.GridBooksTbl.AllowUserToResizeRows = false;
			this.GridBooksTbl.BackgroundColor = System.Drawing.Color.LightYellow;
			this.GridBooksTbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.GridBooksTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.GridBooksTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridBooksTbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.GridBooksTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GridBooksTbl.DefaultCellStyle = dataGridViewCellStyle2;
			this.GridBooksTbl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridBooksTbl.EnableHeadersVisualStyles = false;
			this.GridBooksTbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.GridBooksTbl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.GridBooksTbl.Location = new System.Drawing.Point(0, 0);
			this.GridBooksTbl.Name = "GridBooksTbl";
			this.GridBooksTbl.ReadOnly = true;
			this.GridBooksTbl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GridBooksTbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.GridBooksTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.GridBooksTbl.RowTemplate.Height = 23;
			this.GridBooksTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.GridBooksTbl.Size = new System.Drawing.Size(453, 620);
			this.GridBooksTbl.TabIndex = 0;
			this.GridBooksTbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDivTbl_CellClick);
			// 
			// Title
			// 
			this.Title.Controls.Add(this.DtReleaseDate);
			this.Title.Controls.Add(this.CboDivision);
			this.Title.Controls.Add(this.BtnCancel);
			this.Title.Controls.Add(this.BtnSave);
			this.Title.Controls.Add(this.btnNew);
			this.Title.Controls.Add(this.BtnDelete);
			this.Title.Controls.Add(this.TxtPrice);
			this.Title.Controls.Add(this.TxtIsbn);
			this.Title.Controls.Add(this.TxtNames);
			this.Title.Controls.Add(this.metroLabel7);
			this.Title.Controls.Add(this.Isbn);
			this.Title.Controls.Add(this.TxtAuthor);
			this.Title.Controls.Add(this.metroLabel4);
			this.Title.Controls.Add(this.metroLabel5);
			this.Title.Controls.Add(this.TxtIdx);
			this.Title.Controls.Add(this.metroLabel3);
			this.Title.Controls.Add(this.metroLabel2);
			this.Title.Controls.Add(this.metroLabel1);
			this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Title.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Title.Location = new System.Drawing.Point(0, 0);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(403, 620);
			this.Title.TabIndex = 0;
			this.Title.TabStop = false;
			this.Title.Text = "상세";
			// 
			// DtReleaseDate
			// 
			this.DtReleaseDate.Location = new System.Drawing.Point(112, 230);
			this.DtReleaseDate.MinimumSize = new System.Drawing.Size(0, 29);
			this.DtReleaseDate.Name = "DtReleaseDate";
			this.DtReleaseDate.Size = new System.Drawing.Size(255, 29);
			this.DtReleaseDate.TabIndex = 4;
			// 
			// CboDivision
			// 
			this.CboDivision.FormattingEnabled = true;
			this.CboDivision.ItemHeight = 23;
			this.CboDivision.Location = new System.Drawing.Point(112, 148);
			this.CboDivision.Name = "CboDivision";
			this.CboDivision.Size = new System.Drawing.Size(254, 29);
			this.CboDivision.TabIndex = 2;
			this.CboDivision.UseSelectable = true;
			// 
			// BtnCancel
			// 
			this.BtnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.BtnCancel.Location = new System.Drawing.Point(285, 371);
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
			this.BtnSave.Location = new System.Drawing.Point(198, 371);
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
			this.btnNew.Location = new System.Drawing.Point(111, 371);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(81, 34);
			this.btnNew.TabIndex = 7;
			this.btnNew.Text = "신규";
			this.btnNew.UseSelectable = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// BtnDelete
			// 
			this.BtnDelete.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.BtnDelete.Location = new System.Drawing.Point(111, 426);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(81, 34);
			this.BtnDelete.TabIndex = 9;
			this.BtnDelete.Text = "삭제";
			this.BtnDelete.UseSelectable = true;
			this.BtnDelete.Visible = false;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// TxtPrice
			// 
			// 
			// 
			// 
			this.TxtPrice.CustomButton.Image = null;
			this.TxtPrice.CustomButton.Location = new System.Drawing.Point(233, 1);
			this.TxtPrice.CustomButton.Name = "";
			this.TxtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtPrice.CustomButton.TabIndex = 1;
			this.TxtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtPrice.CustomButton.UseSelectable = true;
			this.TxtPrice.CustomButton.Visible = false;
			this.TxtPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.TxtPrice.Lines = new string[0];
			this.TxtPrice.Location = new System.Drawing.Point(112, 314);
			this.TxtPrice.MaxLength = 45;
			this.TxtPrice.Name = "TxtPrice";
			this.TxtPrice.PasswordChar = '\0';
			this.TxtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtPrice.SelectedText = "";
			this.TxtPrice.SelectionLength = 0;
			this.TxtPrice.SelectionStart = 0;
			this.TxtPrice.ShortcutsEnabled = true;
			this.TxtPrice.Size = new System.Drawing.Size(255, 23);
			this.TxtPrice.TabIndex = 6;
			this.TxtPrice.UseSelectable = true;
			this.TxtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TxtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNames_KeyPress);
			// 
			// TxtIsbn
			// 
			// 
			// 
			// 
			this.TxtIsbn.CustomButton.Image = null;
			this.TxtIsbn.CustomButton.Location = new System.Drawing.Point(233, 1);
			this.TxtIsbn.CustomButton.Name = "";
			this.TxtIsbn.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtIsbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtIsbn.CustomButton.TabIndex = 1;
			this.TxtIsbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtIsbn.CustomButton.UseSelectable = true;
			this.TxtIsbn.CustomButton.Visible = false;
			this.TxtIsbn.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.TxtIsbn.Lines = new string[0];
			this.TxtIsbn.Location = new System.Drawing.Point(112, 272);
			this.TxtIsbn.MaxLength = 13;
			this.TxtIsbn.Name = "TxtIsbn";
			this.TxtIsbn.PasswordChar = '\0';
			this.TxtIsbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtIsbn.SelectedText = "";
			this.TxtIsbn.SelectionLength = 0;
			this.TxtIsbn.SelectionStart = 0;
			this.TxtIsbn.ShortcutsEnabled = true;
			this.TxtIsbn.Size = new System.Drawing.Size(255, 23);
			this.TxtIsbn.TabIndex = 5;
			this.TxtIsbn.UseSelectable = true;
			this.TxtIsbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtIsbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TxtIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNames_KeyPress);
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
			this.TxtNames.Location = new System.Drawing.Point(112, 188);
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
			// metroLabel7
			// 
			this.metroLabel7.Location = new System.Drawing.Point(14, 314);
			this.metroLabel7.Name = "metroLabel7";
			this.metroLabel7.Size = new System.Drawing.Size(95, 20);
			this.metroLabel7.TabIndex = 1;
			this.metroLabel7.Text = "가격 : ";
			this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Isbn
			// 
			this.Isbn.Location = new System.Drawing.Point(14, 272);
			this.Isbn.Name = "Isbn";
			this.Isbn.Size = new System.Drawing.Size(95, 20);
			this.Isbn.TabIndex = 1;
			this.Isbn.Text = "ISBN : ";
			this.Isbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtAuthor
			// 
			// 
			// 
			// 
			this.TxtAuthor.CustomButton.Image = null;
			this.TxtAuthor.CustomButton.Location = new System.Drawing.Point(232, 1);
			this.TxtAuthor.CustomButton.Name = "";
			this.TxtAuthor.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtAuthor.CustomButton.TabIndex = 1;
			this.TxtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtAuthor.CustomButton.UseSelectable = true;
			this.TxtAuthor.CustomButton.Visible = false;
			this.TxtAuthor.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.TxtAuthor.Lines = new string[0];
			this.TxtAuthor.Location = new System.Drawing.Point(112, 109);
			this.TxtAuthor.MaxLength = 45;
			this.TxtAuthor.Name = "TxtAuthor";
			this.TxtAuthor.PasswordChar = '\0';
			this.TxtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtAuthor.SelectedText = "";
			this.TxtAuthor.SelectionLength = 0;
			this.TxtAuthor.SelectionStart = 0;
			this.TxtAuthor.ShortcutsEnabled = true;
			this.TxtAuthor.Size = new System.Drawing.Size(254, 23);
			this.TxtAuthor.TabIndex = 1;
			this.TxtAuthor.UseSelectable = true;
			this.TxtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TxtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNames_KeyPress);
			// 
			// metroLabel4
			// 
			this.metroLabel4.Location = new System.Drawing.Point(14, 188);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(95, 20);
			this.metroLabel4.TabIndex = 1;
			this.metroLabel4.Text = "이름 : ";
			this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroLabel5
			// 
			this.metroLabel5.Location = new System.Drawing.Point(14, 230);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(95, 20);
			this.metroLabel5.TabIndex = 1;
			this.metroLabel5.Text = "출간일 : ";
			this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.TxtIdx.Location = new System.Drawing.Point(112, 70);
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
			this.metroLabel3.Location = new System.Drawing.Point(16, 149);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(95, 20);
			this.metroLabel3.TabIndex = 1;
			this.metroLabel3.Text = "장르 : ";
			this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroLabel2
			// 
			this.metroLabel2.Location = new System.Drawing.Point(14, 109);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(95, 20);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "저자명 : ";
			this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroLabel1
			// 
			this.metroLabel1.Location = new System.Drawing.Point(14, 70);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(95, 20);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "번호 : ";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// BooksMngForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 700);
			this.Controls.Add(this.splitContainer1);
			this.Name = "BooksMngForm";
			this.Style = MetroFramework.MetroColorStyle.Lime;
			this.Text = "BookMngForm";
			this.Load += new System.EventHandler(this.DivMngForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GridBooksTbl)).EndInit();
			this.Title.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private MetroFramework.Controls.MetroGrid GridBooksTbl;
		private System.Windows.Forms.GroupBox Title;
		private MetroFramework.Controls.MetroButton BtnCancel;
		private MetroFramework.Controls.MetroButton BtnSave;
		private MetroFramework.Controls.MetroButton btnNew;
		private MetroFramework.Controls.MetroButton BtnDelete;
		private MetroFramework.Controls.MetroTextBox TxtAuthor;
		private MetroFramework.Controls.MetroTextBox TxtIdx;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroDateTime DtReleaseDate;
		private MetroFramework.Controls.MetroComboBox CboDivision;
		private MetroFramework.Controls.MetroTextBox TxtPrice;
		private MetroFramework.Controls.MetroTextBox TxtIsbn;
		private MetroFramework.Controls.MetroTextBox TxtNames;
		private MetroFramework.Controls.MetroLabel metroLabel7;
		private MetroFramework.Controls.MetroLabel Isbn;
		private MetroFramework.Controls.MetroLabel metroLabel4;
		private MetroFramework.Controls.MetroLabel metroLabel5;
		private MetroFramework.Controls.MetroLabel metroLabel3;
	}
}