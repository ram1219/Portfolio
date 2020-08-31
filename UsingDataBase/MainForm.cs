using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _02.UsingDataBase.SubItems;
using MetroFramework;
using MetroFramework.Forms;

namespace _02.UsingDataBase
{
	public partial class MainForm : MetroForm
	{
		public MainForm()
		{
			InitializeComponent();
			// 폼 실행시 화면 가운데 위치
			//this.Location = new Point(Screen.AllScreens[1].Bounds.Width / 2 - this.Size.Width / 2
			//	, Screen.AllScreens[1].Bounds.Height / 2 - this.Size.Height / 2);
		}

		#region 이벤트 핸들러 영역
		private void MainForm_Load(object sender, EventArgs e)
		{
			// 메인폼이 실행될 때 로그인 폼 생성
			LoginForm login = new LoginForm();
			login.ShowDialog();

			UserId.Text = $"LOGIN : {Commons.USERID}";
		}

		// 폼이 종료 하기 전 실행
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var result = MetroMessageBox.Show(this, "종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// 위의 메세지 박스에서 Yes 버튼을 누른 경우 실행 -> 종료
			if (result == DialogResult.Yes)
			{
				// 위에서 발생한 메세지박스 이벤트(종료)의 캔슬을 하지 않음 -> 실행
				e.Cancel = false;
				Environment.Exit(0);			// 완전 종료
			}
			else
			{
				e.Cancel = true;
			}
		}

		// 바의 코드관리 클릭한 경우
		private void MnuItemCodeMng_Click(object sender, EventArgs e)
		{
			DivMngForm form = new DivMngForm();
			ShowFormControl(form, "구분코드 관리");
		}

		// 바의 종료 클릭한 경우
		private void MnuItemExit_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// 바의 도서관리를 클릭한 경우
		private void MnuItemBooksMng_Click(object sender, EventArgs e)
		{
			BooksMngForm form = new BooksMngForm();
			ShowFormControl(form, "도서 관리");
		}

		// 바의 도서멤버관리를 클릭한 경우
		private void MnuItemMemberTbl_Click(object sender, EventArgs e)
		{
			MemberMngForm form = new MemberMngForm();
			ShowFormControl(form, "도서멤버 관리");
		}

		// 바의 렌탈관리를 클릭한 경우
		private void MnuItemRentalMng_Click(object sender, EventArgs e)
		{
			RentalMngForm form = new RentalMngForm();
			ShowFormControl(form, "렌탈 관리");
		}
		#endregion

		private void ShowFormControl(Form form, string title)
		{
			// Mdi를 사용하는 경우(폼 안의 폼)
			// DivMngForm의 작업 공간이 MainForm이므로 MdiParent를 사용하고 this로 값 지정.
			form.MdiParent = this;
			form.Text = title;
			form.Dock = DockStyle.Fill;
			form.Show();
			form.WindowState = FormWindowState.Maximized;
		}


	}
}
