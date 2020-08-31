using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static _02.UsingDataBase.Commons;

namespace _02.UsingDataBase.SubItems
{
	public partial class RentalMngForm : MetroForm
	{
		readonly string strTblName = "rentaltbl";
		BaseMode myMode = BaseMode.NONE;

		#region 이벤트 함수

		public RentalMngForm()
		{
			InitializeComponent();
		}

		private void DivMngForm_Load(object sender, EventArgs e)
		{
			UpdateComboMember();
			UpdateComboBook();
			UpdateData();
			InitControls();
		}

		private void GridMembersTbl_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				DataGridViewRow data = GridMembersTbl.Rows[e.RowIndex];

				TxtIdx.Text = data.Cells[0].Value.ToString();
				CboMember.SelectedValue = data.Cells[6].Value.ToString();
				CboBookNames.SelectedValue = data.Cells[7].Value.ToString();

				DtirentalDate.Value = DateTime.Parse(data.Cells[4].Value.ToString());

				// 반납을 하지 않은 사람이 있을 경우 반납일 DateTime 처리
				if(!string.IsNullOrEmpty(data.Cells[5].Value.ToString()))
				{
					// InitControl() 에서 returnDate는 빈값으로 뒀기때문에 여기서 형식을 지정해준다.
					DtireturnDate.CustomFormat = "yyyy-MM-dd";
					DtireturnDate.Format = DateTimePickerFormat.Custom;
					DtireturnDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());
				}
				else
				{
					DtireturnDate.CustomFormat = " ";
					DtireturnDate.Format = DateTimePickerFormat.Custom;
				}

				TxtIdx.ReadOnly = true;
				myMode = BaseMode.UPDATE;
			}
		}

		private void DtireturnDate_ValueChanged(object sender, EventArgs e)
		{
			DtireturnDate.CustomFormat = "yyyy-MM-dd";
			DtireturnDate.Format = DateTimePickerFormat.Custom;
		}

		private void BtnExcel_Click(object sender, EventArgs e)
		{
			// 2003년 이전 버전 엑셀 (xls)
			//IWorkbook workbook = new HSSFWorkbook();

			// 엑셀 시트 생성 (xlsx)
			IWorkbook workbook = new XSSFWorkbook();
			ISheet sheet1 = workbook.CreateSheet("sheet1");
			sheet1.CreateRow(0).CreateCell(0).SetCellValue("Rental Book Data");

			DataSet ds = GridMembersTbl.DataSource as DataSet;

			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				IRow row = sheet1.CreateRow(i);
				for (int j = 0; j < ds.Tables[0].Rows[0].ItemArray.Length; j++)
				{
					// 대여일 || 반납일
					if (j == 4 || j == 5)
					{
						// 반납일이 null 값인 경우 ""로 입력하고 아니면 문자열의 0~10째까지만 value에 저장한다.
						var value = string.IsNullOrEmpty(ds.Tables[0].Rows[i].ItemArray[j].ToString()) ?
							"" : ds.Tables[0].Rows[i].ItemArray[j].ToString().Substring(0, 10);
						row.CreateCell(j).SetCellValue(value);
					}
					// 뒤는 저장을 하지 않을 것이므로 break
					else if (j > 5)
						break;
					// 나머지 값은 그대로 저장
					else
						row.CreateCell(j).SetCellValue(ds.Tables[0].Rows[i].ItemArray[j].ToString());
				}
			}
			// export.xlsx 파일로 저장
			// 2003년 이전 버전의 엑셀은 xls
			FileStream file = File.Create(Environment.CurrentDirectory + $@"\export.xlsx");
			workbook.Write(file);
			file.Close();

			MessageBox.Show("Export done!!");
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			InitControls();
			myMode = BaseMode.INSERT;
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

		#endregion

		#region 사용자 생성 함수

		// 회원 콤보박스 바인딩
		private void UpdateComboMember()
		{
			using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
			{
				string strQuery = $"SELECT Idx, Names FROM memberTbl";
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

				CboMember.DataSource = new BindingSource(temps, null);
				// 필수멤버
				CboMember.DisplayMember = "Key";
				CboMember.ValueMember = "Value";
			}
		}

		// 책 콤보박스 데이터 바인딩
		private void UpdateComboBook()
		{
			using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
			{
				string strQuery = @"SELECT b.Idx, b.Names,
										(SELECT Names FROM divTbl WHERE Division = b.Division) AS DIvision
									FROM booksTbl AS b";
				conn.Open();
				MySqlCommand cmd = new MySqlCommand(strQuery, conn);
				MySqlDataReader reader = cmd.ExecuteReader();

				// DB를 이용한 콤보박스 데이터 바인딩
				Dictionary<string, string> temps = new Dictionary<string, string>();
				temps.Add("선택", "");

				while (reader.Read())
				{
					temps.Add($"[{reader[2]}] {reader[1]}", $"{reader[0]}");
				}

				CboBookNames.DataSource = new BindingSource(temps, null);
				// 필수멤버
				CboBookNames.DisplayMember = "Key";
				CboBookNames.ValueMember = "Value";
			}
		}

		// DB 연결
		private void UpdateData()
		{
			using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
			{
				string strQuery = @"SELECT 
										r.idx AS '대여번호',
										m.Names AS '대여회원',
										b.Names AS '대여책제목',
										b.ISBN,
										r.rentalDate AS '대여일',
										r.returnDate AS '반납일',
										r.memberIdx, 	
										r.bookIdx
									FROM
										rentaltbl AS r
											INNER JOIN
										membertbl AS m ON r.memberIdx = m.Idx
											INNER JOIN
										bookstbl AS b ON r.bookIdx = b.Idx";

				// DB 연결
				conn.Open();
				MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, conn);

				DataSet ds = new DataSet();
				adapter.Fill(ds, strTblName);

				GridMembersTbl.DataSource = ds;
				GridMembersTbl.DataMember = strTblName;
			}
			SetColumnHeaders();
		}

		// 초기화 함수
		private void InitControls()
		{
			TxtIdx.Text = string.Empty;
			TxtIdx.Focus();
			CboMember.SelectedIndex = 0;
			CboBookNames.SelectedIndex = 0;

			DtirentalDate.CustomFormat = "yyyy-MM-dd";
			DtirentalDate.Format = DateTimePickerFormat.Custom;
			DtirentalDate.Value = DateTime.Now;                     // 현재 날짜로 초기화

			DtireturnDate.CustomFormat = " ";
			DtireturnDate.Format = DateTimePickerFormat.Custom; 
			
			TxtIdx.ReadOnly = true;
			myMode = BaseMode.NONE;
		}

		/// <summary>
		/// DB 업데이트(UPDATE) 및 입력(INSERT) 처리
		/// </summary>
		private void ControlDataProcess()
		{
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
						cmd.CommandText = @"UPDATE rentaltbl
											SET
												memberIdx = @memberIdx,
												bookIdx = @bookIdx,
												rentalDate = @rentalDate,
												returnDate = @returnDate
											WHERE Idx = @Idx";
					}
					// 신규 버튼을 눌렀을 때
					else if (myMode == BaseMode.INSERT)
					{
						cmd.CommandText = @"INSERT INTO rentaltbl
											(
											 memberIdx,
											 bookIdx,
											 rentalDate,
											 returnDate
											)
											VALUES
											(
											 @memberIdx,
											 @bookIdx,
											 @rentalDate,
											 @returnDate
											)";
					}

					MySqlParameter paramMemberIdx = new MySqlParameter("@memberIdx", MySqlDbType.Int32);
					paramMemberIdx.Value = CboMember.SelectedValue;
					cmd.Parameters.Add(paramMemberIdx);

					MySqlParameter paramBookIdx = new MySqlParameter("@bookIdx", MySqlDbType.Int32);
					paramBookIdx.Value = CboBookNames.SelectedValue;
					cmd.Parameters.Add(paramBookIdx);
			
					MySqlParameter paramRentalDate = new MySqlParameter("@rentalDate", MySqlDbType.Date);
					paramRentalDate.Value = DtirentalDate.Value;
					cmd.Parameters.Add(paramRentalDate);

					// INSERT인 경우 ReturnDate(반납일)는 빈 값으로 저장한다.
					MySqlParameter paramReturnDate = new MySqlParameter("@returnDate", MySqlDbType.Date);
					if(myMode == BaseMode.INSERT)
						paramReturnDate.Value = null;
					else
						paramReturnDate.Value = DtireturnDate.Value;
					cmd.Parameters.Add(paramReturnDate);

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
				UpdateData();
			}
		}

		// DB의 컬럼명이 아닌 폼에서 설정한 명으로 출력하기 위한 메서드
		private void SetColumnHeaders()
		{
			DataGridViewColumn column;

			column = GridMembersTbl.Columns[0];
			column.Width = 60;
			column.HeaderText = "번호";

			column = GridMembersTbl.Columns[1];
			column.Width = 90;
			column.HeaderText = "회원";

			column = GridMembersTbl.Columns[2];
			column.Width = 180;
			column.HeaderText = "책";

			column = GridMembersTbl.Columns[3];
			column.Width = 110;
			column.HeaderText = "ISBN";

			column = GridMembersTbl.Columns[4];
			column.Width = 90;
			column.HeaderText = "대여일";

			column = GridMembersTbl.Columns[5];
			column.Width = 90;
			column.HeaderText = "반납일";

			// MemberIdx
			column = GridMembersTbl.Columns[6];
			column.Visible = false;

			// BookIdx
			column = GridMembersTbl.Columns[7];
			column.Visible = false;
		}
		#endregion
	}
}
