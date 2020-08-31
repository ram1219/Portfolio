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
	public partial class BooksMngForm : MetroForm
	{
		readonly string strTblName = "bookstbl";
		BaseMode myMode = BaseMode.NONE;

		public BooksMngForm()
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
				string strQuery = $"SELECT Division, Names FROM divTbl";
				conn.Open();

				MySqlCommand cmd = new MySqlCommand(strQuery, conn);
				MySqlDataReader reader = cmd.ExecuteReader();

				// DB를 이용한 콤보박스 데이터 바인딩
				Dictionary<string, string> temps = new Dictionary<string, string>();
				temps.Add("선택", "");

				while (reader.Read())
				{
					temps.Add(reader[1].ToString(), reader[0].ToString());
				}

				CboDivision.DataSource = new BindingSource(temps, null);
				CboDivision.DisplayMember = "Key";
				CboDivision.ValueMember = "Value";
				CboDivision.SelectedIndex = 0;
			}
		}

		private void UpdateData()
		{
			using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
			{
				string strQuery = "SELECT b.Idx, " +
								  "		  b.Author, " +
								  "		  b.Division, " +
								  "		  d.Names AS DivisionName, " +
								  "		  b.Names, " +
								  "		  b.ReleaseDate, " +
								  "		  b.ISBN, " +
								  "		  b.Price " +
								 $"  FROM {strTblName} AS b " +
								  " INNER JOIN divtbl AS d " +
								  "	   ON b.Division = d.Division " +
								  " ORDER BY b.Idx ASC ";

				// DB 연결
				conn.Open();
				MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);

				// 테이블 생성
				DataSet ds = new DataSet();
				adapter.Fill(ds, strTblName);

				// 테이블에 가져온 DB 삽입(?)
				GridBooksTbl.DataSource = ds;
				GridBooksTbl.DataMember = strTblName;
			}
			SetColumnHeaders();
		}

		// DB의 컬럼명이 아닌 폼에서 설정한 명으로 출력하기 위한 메서드
		private void SetColumnHeaders()
		{
			DataGridViewColumn column;

			column = GridBooksTbl.Columns[0];
			column.Width = 70;
			column.HeaderText = "번호";

			column = GridBooksTbl.Columns[1];
			column.Width = 120;
			column.HeaderText = "저자명";

			// 구분코드
			column = GridBooksTbl.Columns[2];
			column.Visible = false;

			// 구분코드명
			column = GridBooksTbl.Columns[3];
			column.Width = 100;
			column.HeaderText = "장르";

			column = GridBooksTbl.Columns[4];
			column.Width = 200;
			column.HeaderText = "이름";

			column = GridBooksTbl.Columns[5];
			column.Width = 150;
			column.HeaderText = "출간일";

			column = GridBooksTbl.Columns[6];
			column.Width = 150;
			column.HeaderText = "ISBN";

			column = GridBooksTbl.Columns[7];
			column.Width = 100;
			column.HeaderText = "가격";
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

		// 도구상자 초기화 함수
		private void InitControls()
		{
			TxtIdx.Text = TxtAuthor.Text = TxtPrice.Text = TxtNames.Text = TxtIsbn.Text = string.Empty;
			TxtIdx.Focus();
			CboDivision.SelectedIndex = 0;
			DtReleaseDate.CustomFormat = "yyyy-MM-dd";
			DtReleaseDate.Format = DateTimePickerFormat.Custom;
			DtReleaseDate.Value = DateTime.Now;                     // 현재 날짜로 초기화

			TxtIdx.ReadOnly = true;
			myMode = BaseMode.NONE;
			#region 콤보박스 데이터바인딩
			/*
			Dictionary<string, string> dic = new Dictionary<string, string>();
			dic.Add("선택", "00");
			dic.Add("서울특별시", "11");
			dic.Add("부산광역시", "21");
			dic.Add("대구광역시", "22");
			dic.Add("인천광역시", "23");
			dic.Add("광주광역시", "24");
			dic.Add("대전광역시", "25");

			CboDivision.DataSource = new BindingSource(dic, null);
			CboDivision.DisplayMember = "Key";      // Add 한 값 중 앞의 값을 Key로 지정
			CboDivision.ValueMember = "Value";      // Add 한 값 중 뒤의 값은 Value로 지정
			*/
			#endregion
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
			if (string.IsNullOrEmpty(TxtAuthor.Text) || CboDivision.SelectedIndex < 1 || 
				string.IsNullOrEmpty(TxtNames.Text) || string.IsNullOrEmpty(TxtIsbn.Text)) 
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
						cmd.CommandText = @"UPDATE bookstbl
											SET
											Author = @Author,
											Division = @Division,
											Names = @Names,
											ReleaseDate = @ReleaseDate,
											ISBN = @ISBN,
											Price = @Price
											WHERE Idx = @Idx";
					}
					// 신규 버튼을 눌렀을 때
					else if (myMode == BaseMode.INSERT)
					{
						cmd.CommandText = @"INSERT INTO bookstbl(
											Author,
											Division,
											Names,
											ReleaseDate,
											ISBN,
											Price)
											VALUES(
											@Author,
											@Division,
											@Names,
											@ReleaseDate,
											@ISBN,
											@Price)";
					}
			
					
					// 자료형과 크기는 최대한 DB의 내용과 통일한다
					MySqlParameter paramAutor = new MySqlParameter("@Author", MySqlDbType.VarChar, 45);
					paramAutor.Value = TxtAuthor.Text;
					cmd.Parameters.Add(paramAutor);
				
					MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar, 4);
					paramDivision.Value = CboDivision.SelectedValue;
					cmd.Parameters.Add(paramDivision);

					MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 100)
					{
						Value = TxtNames.Text
					};
					cmd.Parameters.Add(paramNames);

					MySqlParameter paramReleaseDate = new MySqlParameter("@ReleaseDate", MySqlDbType.Date);
					paramReleaseDate.Value = DtReleaseDate.Value;
					cmd.Parameters.Add(paramReleaseDate);

					MySqlParameter paramISBN = new MySqlParameter("@ISBN", MySqlDbType.VarChar, 13);
					paramISBN.Value = TxtIsbn.Text;
					cmd.Parameters.Add(paramISBN);

					MySqlParameter paramPrice = new MySqlParameter("@Price", MySqlDbType.Decimal)
					{
						Value = TxtPrice.Text
					};
					cmd.Parameters.Add(paramPrice);

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
				DataGridViewRow data = GridBooksTbl.Rows[e.RowIndex];

				// 텍스트 박스에 값을 출력한다.
				// 위에서 생성한 ColumnHeader의 순서에 맞춰서 설정한다.
				TxtIdx.Text = data.Cells[0].Value.ToString();			// 번호
				TxtAuthor.Text = data.Cells[1].Value.ToString();        // 작가

				// DataGridView에서 선택한 값과 같은 값을 콤보박스에서 선택하기
				// 콤보박스에는 입력으로 구분코드가 들어가고(key) 구분명으로 보여진다(Value)
				// FindString -> ()안의 문자열(공포/스릴러, 로맨스...)을 포함하고 있는 인덱스를 CboDivision 안에서 찾는다.
				//CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[3].Value.ToString());

				// 코드값(B001, B002)을 그대로 할당하여 찾는다.
				CboDivision.SelectedValue = data.Cells[2].Value;

				TxtNames.Text = data.Cells[4].Value.ToString();         // 책이름

				DtReleaseDate.CustomFormat = "yyyy-MM-dd";
				DtReleaseDate.Format = DateTimePickerFormat.Custom;
				// object인 data.Cells[].Value를 DateTime의 자료형으로 변환해야 한다.
				// DateTime.Parse를 사용하고 ()안에는 string 형식이 들어가므로 ToString을 한다.
				DtReleaseDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());

				TxtIsbn.Text = data.Cells[6].Value.ToString();			// ISBN
				TxtPrice.Text = data.Cells[7].Value.ToString();			// 가격

				// PK(Primary Key) 가 들어가는 텍스트 박스는 변경이 불가능하도록 ReadOnly로 지정한다.
				TxtIdx.ReadOnly = true;

				myMode = BaseMode.UPDATE;
			}
		}

		private void TxtDivision_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == 13)
			{
				TxtAuthor.Focus();
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
