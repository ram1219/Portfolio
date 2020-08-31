using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.UsingDataBase.SubItems
{
	public partial class LoginForm : MetroForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{

		}

		private void metroButton1_Click(object sender, EventArgs e)
		{
			LoginProcess();
		}

		private void LoginProcess()
		{
			// 빈값 비교 처리
			// TxtUserID나 TxtUserPW가 빈 값일 경우 아래 코드 실행
			if (string.IsNullOrEmpty(TxtUserID.Text) || string.IsNullOrEmpty(TxtUserPW.Text))
			{
				MetroMessageBox.Show(this,"아이디나 패스워드를 입력하세요!", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			// 실제 DB처리
			string resultId = string.Empty;

			try
			{
				// MySql Connection
				using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
				{
					conn.Open();

					MySqlCommand cmd = new MySqlCommand();
					cmd.Connection = conn;
					// space 신경써서 꼭! 넣어주기
					// @userID, @password -> 파라미터 : 입력값을 가져옴
					cmd.CommandText = "SELECT UserID FROM usertbl " +
									  " WHERE UserID = @userID " +
									  "   AND Password = @password ";

					MySqlParameter paramUserId = new MySqlParameter("@userID", MySqlDbType.VarChar, 12);
					// 입력시 발생하는 공백을 제거하기 위해 Trim()을 사용한다.
					paramUserId.Value = TxtUserID.Text.Trim();
					MySqlParameter paramUserPw = new MySqlParameter("@password", MySqlDbType.VarChar);
					paramUserPw.Value = TxtUserPW.Text.Trim();

					// Id, PW를 입력
					cmd.Parameters.Add(paramUserId);
					cmd.Parameters.Add(paramUserPw);

					MySqlDataReader reader = cmd.ExecuteReader();
					// 값을 확인하고 읽어옴
					reader.Read();

					// 읽어온 값이 아무것도 없는 경우 (읽어온 값이 있으면 return 1;)
					if (!reader.HasRows)
					{
						MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요.", "로그인 실패", 
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						TxtUserID.Text = TxtUserPW.Text = "";
						TxtUserID.Focus();
						return;
					}
					// 읽어온 값 중 userID의 값이 null 이 아니면 문자열로 변환
					resultId = reader["userID"] != null ? reader["userID"].ToString() : string.Empty;

					MetroMessageBox.Show(this, $"로그인성공 : {resultId}");
				}

			}
			catch(Exception ex)
			{
				MetroMessageBox.Show(this, $"DB접속 에러 : {ex.Message}", "로그인에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (string.IsNullOrEmpty(resultId))
			{
				MetroMessageBox.Show(this, "아이디나 패스워드를 정확히 입력하세요.", "로그인 실패",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
				TxtUserID.Text = TxtUserPW.Text = "";
				TxtUserID.Focus();
				return;
			}
			// resultID의 결과가 있는 경우 로그인창 종료
			else
			{
				this.Close();
			}
		}

		private void TxtUserID_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 엔터를 누른 경우 PW로 이동
			if (e.KeyChar == 13)
				TxtUserPW.Focus();
		}

		private void TxtUserPW_KeyPress(object sender, KeyPressEventArgs e)
		{
			// 엔터를 누르 경우 Login 버튼 이벤트 발생
			if (e.KeyChar == 13)
				metroButton1_Click(sender, new EventArgs());
		}

		private void metroButton2_Click(object sender, EventArgs e)
		{
			// Exit의 매개변수
			// 0 -> 에러없이 종료
			Environment.Exit(0);
		}
	}
}
