
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static _02.UsingDataBase.Commons;

namespace _02.UsingDataBase.SubItems
{
	public partial class MemberMngForm : MetroForm
	{
		readonly string strTblName = "bookstbl";
		BaseMode myMode = BaseMode.NONE;

		public MemberMngForm()
		{
			InitializeComponent();
		}


		private void DivMngForm_Load(object sender, EventArgs e)
		{
			// 사용자 생성 함수
			UpdateComboDivision();
			UpdateData();
			InitControls();
		}

		private void UpdateComboDivision()
		{
			using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
			{
				string strQuery = $"SELECT DISTINCT Levels FROM membertbl ORDER BY Levels";
				conn.Open();

				MySqlCommand cmd = new MySqlCommand(strQuery, conn);
				MySqlDataReader reader = cmd.ExecuteReader();

				// DB를 이용한 콤보박스 데이터 바인딩
				Dictionary<string, string> temps = new Dictionary<string, string>();
				temps.Add("선택", "");

				while (reader.Read())
				{
					temps.Add(reader[0].ToString(), reader[0].ToString());
				}

				CboLevels.DataSource = new BindingSource(temps, null);
				// 필수멤버
				CboLevels.DisplayMember = "Key";
				CboLevels.ValueMember = "Value";
				CboLevels.SelectedIndex = 0;
			}
		}

		private void UpdateData()
		{
			using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
			{
				string strQuery = @"SELECT 
									Idx,
									Names,
									Levels,
									Addr,
									Mobile,
									Email
									FROM membertbl
								    ORDER BY membertbl.Idx ASC";

				// DB 연결
				conn.Open();
				MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);

				// 테이블 생성
				DataSet ds = new DataSet();
				adapter.Fill(ds, strTblName);

				// 테이블에 가져온 DB 삽입(?)
				GridMembersTbl.DataSource = ds;
				GridMembersTbl.DataMember = strTblName;
			}
			SetColumnHeaders();
		}

		// DB의 컬럼명이 아닌 폼에서 설정한 명으로 출력하기 위한 메서드
		private void SetColumnHeaders()
		{
			DataGridViewColumn column;

			column = GridMembersTbl.Columns[0];
			column.Width = 60;
			column.HeaderText = "번호";

			column = GridMembersTbl.Columns[1];
			column.Width = 60;
			column.HeaderText = "이름";

			column = GridMembersTbl.Columns[2];
			column.Width = 60;
			column.HeaderText = "레벨";

			column = GridMembersTbl.Columns[3];
			column.Width = 150;
			column.HeaderText = "주소";

			column = GridMembersTbl.Columns[4];
			column.Width = 150;
			column.HeaderText = "전화번호";

			column = GridMembersTbl.Columns[5];
			column.Width = 150;
			column.HeaderText = "이메일";
		}

		// 도구상자 초기화 함수
		private void InitControls()
		{
			TxtIdx.Text = TxtAddress.Text = TxtEmail.Text = TxtNames.Text = TxtMobile.Text = string.Empty;
			TxtIdx.Focus();
			CboLevels.SelectedIndex = 0;

			TxtIdx.ReadOnly = true;
			myMode = BaseMode.NONE;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			InitControls();

			myMode = BaseMode.INSERT;
			TxtIdx.Focus();
		}

		/// <summary>
		/// DB 업데이트(UPDATE) 및 입력(INSERT) 처리
		/// </summary>
		private void ControlDataProcess()
		{
			// 빈값확인(NULL CHECK)
			if (string.IsNullOrEmpty(TxtAddress.Text) || CboLevels.SelectedIndex < 1 || 
				string.IsNullOrEmpty(TxtNames.Text) || string.IsNullOrEmpty(TxtMobile.Text) || string.IsNullOrEmpty(TxtEmail.Text)) 
			{
				MetroMessageBox.Show(this, "빈값은 넣을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if(myMode == BaseMode.NONE)
			{
				MetroMessageBox.Show(this, "신규등록시 신규 버튼을 눌러주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			try
			{
				// DB에 새로운 값 추가/변경
				using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
				{
					conn.Open();
					MySqlCommand cmd = new MySqlCommand();
					cmd.Connection = conn;

					// 저장 버튼을 눌렀을 때
					if(myMode == BaseMode.UPDATE)
					{
						cmd.CommandText = @"UPDATE membertbl
											SET
											Names = @Names,
											Levels = @Levels,
											Addr = @Addr,
											Mobile = @Mobile,
											Email = @Email
											WHERE Idx = @Idx";
					}
					// 신규 버튼을 눌렀을 때
					else if (myMode == BaseMode.INSERT)
					{
						cmd.CommandText = @"INSERT INTO membertbl
											(Names,
											Levels,
											Addr,					
											Mobile,
											Email)
											VALUES
											(@Names,
											@Levels,
											@Addr,
											@Mobile,
											@Email)";
					}
			
					
					// 자료형과 크기는 최대한 DB의 내용과 통일한다
					MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45)
					{
						Value = TxtNames.Text
					};
					cmd.Parameters.Add(paramNames);

					MySqlParameter paramLevels = new MySqlParameter("@Levels", MySqlDbType.VarChar, 1);
					paramLevels.Value = CboLevels.SelectedValue;
					cmd.Parameters.Add(paramLevels);

					MySqlParameter paramaddr = new MySqlParameter("@Addr", MySqlDbType.VarChar, 100);
					paramaddr.Value = TxtAddress.Text;
					cmd.Parameters.Add(paramaddr);
			
					MySqlParameter paramMobile = new MySqlParameter("@Mobile", MySqlDbType.VarChar, 13);
					paramMobile.Value = TxtMobile.Text;
					cmd.Parameters.Add(paramMobile);

					MySqlParameter paramEmail = new MySqlParameter("@Email", MySqlDbType.VarChar, 50)
					{
						Value = TxtEmail.Text
					};
					cmd.Parameters.Add(paramEmail);

					// UPDATE인 경우만 Idx를 사용.
					if (myMode == BaseMode.UPDATE)
					{
						MySqlParameter paramIdx = new MySqlParameter("@Idx", MySqlDbType.Int32);
						paramIdx.Value = TxtIdx.Text;
						cmd.Parameters.Add(paramIdx);
					}

					// 값이 제대로 DB로 넘어가면 return 1
					var result = cmd.ExecuteNonQuery();

					if(myMode == BaseMode.INSERT)
					{
						MetroMessageBox.Show(this, $"{result}건이 신규입력되었습니다.", "신규입력");
					}
					else if(myMode == BaseMode.UPDATE)
					{
						MetroMessageBox.Show(this, $"{result}건이 추가되었습니다.", "추가");
					}
				}
			}
			catch(Exception ex)
			{
				MetroMessageBox.Show(this, $"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				// 위에서 생성한 사용자 생성 함수
				// 업데이트한 내용으로 DB를 다시 불러온다.
				UpdateData();
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			ControlDataProcess();
			InitControls();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			InitControls();
		}

		// DataGridView 셀을 클릭할 때 발생하는 이벤트
		private void GridDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1)
			{
				// (e)이벤트가 발생한 Row의 모든 값들을 가져온다.
				DataGridViewRow data = GridMembersTbl.Rows[e.RowIndex];

				// 텍스트 박스에 값을 출력한다.
				// 위에서 생성한 ColumnHeader의 순서에 맞춰서 설정한다.
				TxtIdx.Text = data.Cells[0].Value.ToString();			
				TxtNames.Text = data.Cells[1].Value.ToString();
				CboLevels.SelectedIndex = CboLevels.FindString(data.Cells[2].Value.ToString());
				TxtAddress.Text = data.Cells[3].Value.ToString();       
				TxtMobile.Text = data.Cells[4].Value.ToString();		
				TxtEmail.Text = data.Cells[5].Value.ToString();			

				// PK(Primary Key) 가 들어가는 텍스트 박스는 변경이 불가능하도록 ReadOnly로 지정한다.
				TxtIdx.ReadOnly = true;

				myMode = BaseMode.UPDATE;
			}
		}

		private void TxtDivision_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				TxtAddress.Focus();
			}
		}

		private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				btnNew.Focus();
			}
		}
	}
}
