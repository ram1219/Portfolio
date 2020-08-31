namespace _02.UsingDataBase.SubItems
{
	partial class LoginForm
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
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.TxtUserID = new MetroFramework.Controls.MetroTextBox();
			this.TxtUserPW = new MetroFramework.Controls.MetroTextBox();
			this.metroButton1 = new MetroFramework.Controls.MetroButton();
			this.metroButton2 = new MetroFramework.Controls.MetroButton();
			this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(34, 99);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(45, 23);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "ID";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// metroLabel2
			// 
			this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel2.Location = new System.Drawing.Point(34, 144);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(45, 19);
			this.metroLabel2.TabIndex = 1;
			this.metroLabel2.Text = "PW";
			this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TxtUserID
			// 
			// 
			// 
			// 
			this.TxtUserID.CustomButton.Image = null;
			this.TxtUserID.CustomButton.Location = new System.Drawing.Point(185, 1);
			this.TxtUserID.CustomButton.Name = "";
			this.TxtUserID.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtUserID.CustomButton.TabIndex = 1;
			this.TxtUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtUserID.CustomButton.UseSelectable = true;
			this.TxtUserID.CustomButton.Visible = false;
			this.TxtUserID.Lines = new string[0];
			this.TxtUserID.Location = new System.Drawing.Point(94, 99);
			this.TxtUserID.MaxLength = 12;
			this.TxtUserID.Name = "TxtUserID";
			this.TxtUserID.PasswordChar = '\0';
			this.TxtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtUserID.SelectedText = "";
			this.TxtUserID.SelectionLength = 0;
			this.TxtUserID.SelectionStart = 0;
			this.TxtUserID.ShortcutsEnabled = true;
			this.TxtUserID.Size = new System.Drawing.Size(207, 23);
			this.TxtUserID.TabIndex = 0;
			this.TxtUserID.UseSelectable = true;
			this.TxtUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TxtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserID_KeyPress);
			// 
			// TxtUserPW
			// 
			// 
			// 
			// 
			this.TxtUserPW.CustomButton.Image = null;
			this.TxtUserPW.CustomButton.Location = new System.Drawing.Point(185, 1);
			this.TxtUserPW.CustomButton.Name = "";
			this.TxtUserPW.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.TxtUserPW.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.TxtUserPW.CustomButton.TabIndex = 1;
			this.TxtUserPW.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.TxtUserPW.CustomButton.UseSelectable = true;
			this.TxtUserPW.CustomButton.Visible = false;
			this.TxtUserPW.Lines = new string[0];
			this.TxtUserPW.Location = new System.Drawing.Point(94, 144);
			this.TxtUserPW.MaxLength = 32767;
			this.TxtUserPW.Name = "TxtUserPW";
			this.TxtUserPW.PasswordChar = '\0';
			this.TxtUserPW.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.TxtUserPW.SelectedText = "";
			this.TxtUserPW.SelectionLength = 0;
			this.TxtUserPW.SelectionStart = 0;
			this.TxtUserPW.ShortcutsEnabled = true;
			this.TxtUserPW.Size = new System.Drawing.Size(207, 23);
			this.TxtUserPW.TabIndex = 1;
			this.TxtUserPW.UseSelectable = true;
			this.TxtUserPW.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.TxtUserPW.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.TxtUserPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserPW_KeyPress);
			// 
			// metroButton1
			// 
			this.metroButton1.Location = new System.Drawing.Point(94, 201);
			this.metroButton1.Name = "metroButton1";
			this.metroButton1.Size = new System.Drawing.Size(96, 42);
			this.metroButton1.TabIndex = 2;
			this.metroButton1.Text = "Login";
			this.metroButton1.UseSelectable = true;
			this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
			// 
			// metroButton2
			// 
			this.metroButton2.Location = new System.Drawing.Point(205, 201);
			this.metroButton2.Name = "metroButton2";
			this.metroButton2.Size = new System.Drawing.Size(96, 42);
			this.metroButton2.TabIndex = 3;
			this.metroButton2.Text = "Cancel";
			this.metroButton2.UseSelectable = true;
			this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
			// 
			// metroDateTime1
			// 
			this.metroDateTime1.Location = new System.Drawing.Point(0, 0);
			this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
			this.metroDateTime1.Name = "metroDateTime1";
			this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
			this.metroDateTime1.TabIndex = 4;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 290);
			this.Controls.Add(this.metroDateTime1);
			this.Controls.Add(this.metroButton2);
			this.Controls.Add(this.metroButton1);
			this.Controls.Add(this.TxtUserPW);
			this.Controls.Add(this.TxtUserID);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.MaximizeBox = false;
			this.Name = "LoginForm";
			this.Resizable = false;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
		private MetroFramework.Controls.MetroTextBox TxtUserID;
		private MetroFramework.Controls.MetroTextBox TxtUserPW;
		private MetroFramework.Controls.MetroButton metroButton1;
		private MetroFramework.Controls.MetroButton metroButton2;
		private MetroFramework.Controls.MetroDateTime metroDateTime1;
	}
}