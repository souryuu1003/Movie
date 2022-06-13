using System;

namespace movievo
{
	// 상영 영화 테이블
	class MovieVO
	{
		private UInt64 KEY_NO; // 번호
		private string MOVIE_NAME; // 영화 제목
		private DateTime START_DATE; // 상영 시작 일시
		private DateTime END_DATE; // 상영 종료 일시
		private UInt16? THEATER; // 상영관
		private UInt16? SCREEN_SESSION; // 상영 회차
		private Byte? MOVIE_TYPE; // 영화 종류
		private DateTime MOVIE_START_TIME; // 영화 시작시간
		private DateTime MOVIE_END_TIME; // 영화 종료시간
		private string SEAT; // 좌석
		private bool RESERVED_SEAT; // 좌석 예매여부
		private UInt64? AUDIENCE_NUBER; // 관객 수
		private UInt64? TOTAL_AUDIENCE_NUMBER; // 누적 관객 수
		private DateTime INSERT_DATE; // 작성시간
		private string INSERT_USER; // 작성자
		private DateTime UPDATE_DATE; // 갱신시간
		private string UPDATE_USER; // 갱신자

		public UInt64 KEY_NO { get; set; }
		public string MOVIE_NAME { get; set; }
		public DateTime START_DATE { get; set;}
		public DateTime END_DATE { get; set;}
		public UInt16? THEATER { get; set; }
		public UInt16? SCREEN_SESSION { get; set; }
		public Byte? MOVIE_TYPE { get; set; }
		public DateTime MOVIE_START_TIME { get; set; }
		public DateTime MOVIE_END_TIME { get; set; }
		public string SEAT { get; set; }
		public bool RESERVED_SEAT { get; set; }
		public UInt64? AUDIENCE_NUBER { get; set; }
		public UInt64? TOTAL_AUDIENCE_NUMBER { get; set; }
		public DateTime INSERT_DATE { get; set; }
		public string INSERT_USER { get; set; }
		public DateTime UPDATE_DATE { get; set; }
		public string UPDATE_USER { get; set; }

		//public MovieVO()
		//{
		//	this.KEY_NO = 0;
		//	this.MOVIE_NAME = "";
		//	this.START_DATE = default(DateTime);
		//	this.END_DATE = default(DateTime);
		//	this.THEATER = null;
		//	this.SCREEN_SESSION = null;
		//	this.MOVIE_TYPE = null;
		//	this.MOVIE_START_TIME = default(DateTime);
		//	this.MOVIE_END_TIME = default(DateTime);
		//	this.SEAT = "";
		//	this.RESERVED_SEAT = false;
		//	this.AUDIENCE_NUBER = null;
		//	this.TOTAL_AUDIENCE_NUMBER = null;
		//	this.INSERT_DATE = default(DateTime);
		//	this.INSERT_USER = "";
		//	this.UPDATE_DATE = default(DateTime);
		//	this.UPDATE_USER = "";
		//}


	}
}