using Org.BouncyCastle.Bcpg;
using System;
using System.Security.Cryptography;
using System.Text;

namespace _02.UsingDataBase
{
	public class Commons
	{
		// 공동 DB 연결 문자열
		public static readonly string CONNSTR = "Data Source=127.0.0.1;Port=3306;Database=bookrentalshop;UID=root;Password=mysql_p@ssw0rd";

		public static string USERID = string.Empty;

		/// <summary>
		/// MD5 암호화 메서드
		/// </summary>
		/// <param name="md5Hash">해시키값</param>
		/// <param name="input">평문</param>
		/// <returns>암호화된 평문 문자열</returns>
		public static string GetMd5Hash(MD5 md5Hash, string input)
		{
			// 입력받은 문자열을 바이트 형식으로 변환(암호화)
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
			StringBuilder sbuilder = new StringBuilder();

			// 다시 문자열로 변환
			for(int i = 0; i < data.Length; i++)
			{
				// 문자열 형식을 x2(16진수)
				sbuilder.Append(data[i].ToString("x2"));
			}

			return sbuilder.ToString();
		}

		public enum BaseMode
		{
			NONE,		// 기본
			INSERT,		// 입력
			UPDATE,		// 수정
			DELETE,		// 삭제
			SELECT
		}
	}
}
