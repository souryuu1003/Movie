using System;

namespace uservo
{
	// 회원 테이블
	class UserVO
	{
		private UInt64 KEY_NO; // 번호
		private string USER_NAME; // 회원 이름
		private string CONTACT_INFO; // 회원 연락처
		private DateTime REG_DATE; // 회원 가입 날짜
		private Byte? USER_GRADE; // 회원 등급
		private UInt64 MOVIE_NO; // 영화 번호
		private UInt16? THEATER; // 상영관
		private UInt16? SCREEN_SESSION; // 상영 회차
		private Byte? MOVIE_TYPE; // 영화 종류
		private DateTime MOVIE_START_TIME; // 영화 시작시간
		private DateTime MOVIE_END_TIME; // 영화 종료시간
		private string SEAT; // 좌석
		private bool USE_COUPON; // 쿠폰 사용 여부
		private DateTime INSERT_DATE; // 작성시간
		private string INSERT_USER; // 작성자
		private DateTime UPDATE_DATE; // 갱신시간
		private string UPDATE_USER; // 갱신자

		public UInt64 KEY_NO { get; set; }
		public string USER_NAME { get; set; }
		public string CONTACT_INFO { get; set; }
		public DateTime REG_DATE { get; set; }
		public Byte? USER_GRADE { get; set; }
		public UInt64 MOVIE_NO { get; set; }
		public UInt16? THEATER { get; set; }
		public UInt16? SCREEN_SESSION { get; set; }
		public Byte? MOVIE_TYPE { get; set; }
		public DateTime MOVIE_START_TIME { get; set; }
		public DateTime MOVIE_END_TIME { get; set; }
		public string SEAT { get; set; }
		public bool USE_COUPON { get; set; }
		public DateTime INSERT_DATE { get; set; }
		public string INSERT_USER { get; set; }
		public DateTime UPDATE_DATE { get; set; }
		public string UPDATE_USER { get; set; }

		//public UserVO()
		//{
		//	this.KEY_NO = 0;
		//	this.USER_NAME = "";
		//	this.CONTACT_INFO = "";
		//	this.REG_DATE = default(DateTime);
		//	this.USER_GRADE = null;
		//	this.MOVIE_NO = 0;
		//	this.THEATER = null;
		//	this.SCREEN_SESSION = null;
		//	this.MOVIE_TYPE = null;
		//	this.MOVIE_START_TIME = default(DateTime);
		//	this.MOVIE_END_TIME = default(DateTime);
		//	this.SEAT = "";
		//	this.USE_COUPON = false;
		//	this.INSERT_DATE = default(DateTime);
		//	this.INSERT_USER = "";
		//	this.UPDATE_DATE = default(DateTime);
		//	this.UPDATE_USER = "";
		//}
	}
}