using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _02.UsingDataBase.Commons;

namespace _02.UsingDataBase.SubItems
{
	public partial class DivMngForm : MetroForm
	{
		readonly string strTblName = "divTbl";
		BaseMode myMode = BaseMode.NONE;

		public DivMngForm()
		{
			InitializeComponent();
		}

		private void DivMngForm_Load(object sender, EventArgs e)
		{
			// 사용자 생성 함수
			UpdateData();
		}

		private void UpdateData()
		{
			using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
			{
				string strQuery = $"SELECT Division, Names FROM {strTblName} ";

				conn.Open();
				MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);

				DataSet ds = new DataSet();
				adapter.Fill(ds, strTblName);

				GridDivTbl.DataSource = ds;
				GridDivTbl.DataMember = strTblName;
			}
			SetColumnHeaders();
		}

		// DB의 컬럼명이 아닌 폼에서 설정한 명으로 출력하기 위한 메서드
		private void SetColumnHeaders()
		{
			DataGridViewColumn column;

			column = GridDivTbl.Columns[0];
			column.Width = 100;
			column.HeaderText = "구분코드";

			column = GridDivTbl.Columns[1];
			column.Width = 100;
			column.HeaderText = "이름";
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			if(myMode != BaseMode.UPDATE)
			{
				MetroMessageBox.Show(this, "삭제할 데이터를 선택하세요", "알림");
				return;
			}

			myMode = BaseMode.DELETE;
			ControlDataProcess();

			InitControls();
		}

		private void InitControls()
		{
			TxtDivision.Text = TxtNames.Text = "";
			TxtDivision.Focus();

			myMode = BaseMode.NONE;
		}

		#region 삭제 메서드 주석처리
		/*
		private void DeleteProcess()
		{
			
			try
			{
				using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
				{
					conn.Open();
					MySqlCommand cmd = new MySqlCommand();
					cmd.Connection = conn;
					cmd.CommandText = "DELETE FROM divtbl " +
									  " WHERE Division = @Division ";

					MySqlParameter paramDeivison = new MySqlParameter("@Division", MySqlDbType.VarChar);
					cmd.Parameters.Add(paramDeivison);

					var result = cmd.ExecuteNonQuery();

					MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
				}
			}
			catch (Exception ex)
			{
				MetroMessageBox.Show(this, $"에러발생 : {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				UpdateData();
			}	
		}
		*/
		#endregion

		private void btnNew_Click(object sender, EventArgs e)
		{
			TxtDivision.Text = TxtNames.Text = string.Empty;
			// 새로운 삽입하기 위해 ReadOnly를 false 상태로 만든다.
			TxtDivision.ReadOnly = false;

			myMode = BaseMode.INSERT;
			TxtDivision.Focus();
		}

		/// <summary>
		/// DB 업데이트(UPDATE) 및 입력(INSERT) 삭제 처리
		/// </summary>
		private void ControlDataProcess()
		{
			if (string.IsNullOrEmpty(TxtDivision.Text) || string.IsNullOrEmpty(TxtNames.Text)) 
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
						cmd.CommandText = "UPDATE divtbl " +
										  "   SET Names = @Names " +
										  " WHERE Division = @Division ";
					}
					// 신규 버튼을 눌렀을 때
					else if (myMode == BaseMode.INSERT)
					{
						cmd.CommandText = "INSERT INTO divtbl " +
										  " (Division,Names) " +
										  " VALUES(@Division, @Names) ";
					}
					else if(myMode == BaseMode.DELETE)
					{
						cmd.CommandText = "DELETE FROM divtbl " +
									  " WHERE Division = @Division ";
					}

					// Delete에는 Names를 사용하지 않으므로 if문을 이용해서 분기한다.
					if(myMode ==BaseMode.INSERT || myMode == BaseMode.UPDATE)
					{
						// 자료형과 크기는 최대한 DB의 내용과 통일한다
						MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45);
						paramNames.Value = TxtNames.Text;
						cmd.Parameters.Add(paramNames);
					}

					MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar, 4);
					paramDivision.Value = TxtDivision.Text;
					cmd.Parameters.Add(paramDivision);

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
					else if(myMode == BaseMode.DELETE)
					{
						MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
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

		// 셀을 클릭할 때 발생하는 이벤트
		private void GridDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex > -1)
			{
				// (e)이벤트가 발생한 Row의 모든 값들을 가져온다.
				DataGridViewRow data = GridDivTbl.Rows[e.RowIndex];

				// 텍스트 박스에 값을 출력한다.
				TxtDivision.Text = data.Cells[0].Value.ToString();
				TxtNames.Text = data.Cells[1].Value.ToString();

				// PK(Primary Key) 가 들어가는 텍스트 박스는 변경이 불가능하도록 ReadOnly로 지정한다.
				TxtDivision.ReadOnly = true;

				myMode = BaseMode.UPDATE;
			}
		}

		private void TxtDivision_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				TxtNames.Focus();
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
