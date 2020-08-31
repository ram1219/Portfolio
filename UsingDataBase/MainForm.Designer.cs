namespace _02.UsingDataBase
{
	partial class MainForm
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MnuMmg = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuItemCodeMng = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuItemBooksMng = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuItemMemberTbl = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuItemRentalMng = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuItemUserMng = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.MnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
			this.UserId = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuMmg});
			this.menuStrip1.Location = new System.Drawing.Point(20, 60);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1240, 27);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MnuMmg
			// 
			this.MnuMmg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuItemCodeMng,
            this.MnuItemBooksMng,
            this.MnuItemMemberTbl,
            this.MnuItemRentalMng,
            this.MnuItemUserMng,
            this.toolStripMenuItem1,
            this.MnuItemExit});
			this.MnuMmg.Name = "MnuMmg";
			this.MnuMmg.Size = new System.Drawing.Size(70, 23);
			this.MnuMmg.Text = "관리(&M)";
			// 
			// MnuItemCodeMng
			// 
			this.MnuItemCodeMng.Name = "MnuItemCodeMng";
			this.MnuItemCodeMng.Size = new System.Drawing.Size(187, 24);
			this.MnuItemCodeMng.Text = "코드관리(&C)";
			this.MnuItemCodeMng.Click += new System.EventHandler(this.MnuItemCodeMng_Click);
			// 
			// MnuItemBooksMng
			// 
			this.MnuItemBooksMng.Name = "MnuItemBooksMng";
			this.MnuItemBooksMng.Size = new System.Drawing.Size(187, 24);
			this.MnuItemBooksMng.Text = "도서관리(&B)";
			this.MnuItemBooksMng.Click += new System.EventHandler(this.MnuItemBooksMng_Click);
			// 
			// MnuItemMemberTbl
			// 
			this.MnuItemMemberTbl.Name = "MnuItemMemberTbl";
			this.MnuItemMemberTbl.Size = new System.Drawing.Size(187, 24);
			this.MnuItemMemberTbl.Text = "멤버관리(&M)";
			this.MnuItemMemberTbl.Click += new System.EventHandler(this.MnuItemMemberTbl_Click);
			// 
			// MnuItemRentalMng
			// 
			this.MnuItemRentalMng.Name = "MnuItemRentalMng";
			this.MnuItemRentalMng.Size = new System.Drawing.Size(187, 24);
			this.MnuItemRentalMng.Text = "대여관리(&R)";
			this.MnuItemRentalMng.Click += new System.EventHandler(this.MnuItemRentalMng_Click);
			// 
			// MnuItemUserMng
			// 
			this.MnuItemUserMng.Name = "MnuItemUserMng";
			this.MnuItemUserMng.Size = new System.Drawing.Size(187, 24);
			this.MnuItemUserMng.Text = "사용자관리(&U)";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
			// 
			// MnuItemExit
			// 
			this.MnuItemExit.Name = "MnuItemExit";
			this.MnuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.MnuItemExit.Size = new System.Drawing.Size(187, 24);
			this.MnuItemExit.Text = "끝내기(&X)";
			this.MnuItemExit.Click += new System.EventHandler(this.MnuItemExit_Click);
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
			// 
			// UserId
			// 
			this.UserId.Location = new System.Drawing.Point(919, 25);
			this.UserId.Name = "UserId";
			this.UserId.Size = new System.Drawing.Size(338, 23);
			this.UserId.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.UserId);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "MainForm";
			this.Text = "Book Rental Shop v0.6";
			this.TransparencyKey = System.Drawing.Color.Empty;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MnuMmg;
		private System.Windows.Forms.ToolStripMenuItem MnuItemCodeMng;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem MnuItemExit;
		private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
		private System.Windows.Forms.ToolStripMenuItem MnuItemBooksMng;
		private System.Windows.Forms.ToolStripMenuItem MnuItemMemberTbl;
		private System.Windows.Forms.ToolStripMenuItem MnuItemRentalMng;
		private System.Windows.Forms.ToolStripMenuItem MnuItemUserMng;
		private System.Windows.Forms.Label UserId;
	}
}

