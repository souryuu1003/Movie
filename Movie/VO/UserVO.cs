using System;

namespace uservo
{
	class UserVO
	{
		private UInt64 ur_KEY_NO;
		private string ur_USER_NAME;
		private string ur_CONTACT_INFO;
		private DateTime ur_REG_DATE;
		private Byte? ur_USER_GRADE;
		private UInt64 ur_MOVIE_NO;
		private UInt16? ur_THEATER;
		private UInt16? ur_SCREEN_SESSION;
		private Byte? ur_MOVIE_TYPE;
		private DateTime ur_MOVIE_START_TIME;
		private DateTime ur_MOVIE_END_TIME;
		private string ur_SEAT;
		private bool ur_USE_COUPON;
		private DateTime ur_INSERT_DATE;
		private string ur_INSERT_USER;
		private DateTime ur_UPDATE_DATE;
		private string ur_UPDATE_USER;

		public UserVO()
		{
			this.ur_KEY_NO = 0;
			this.ur_USER_NAME = "";
			this.ur_CONTACT_INFO = "";
			this.ur_REG_DATE = default(DateTime);
			this.ur_USER_GRADE = null;
			this.ur_MOVIE_NO = 0;
			this.ur_THEATER = null;
			this.ur_SCREEN_SESSION = null;
			this.ur_MOVIE_TYPE = null;
			this.ur_MOVIE_START_TIME = default(DateTime);
			this.ur_MOVIE_END_TIME = default(DateTime);
			this.ur_SEAT = "";
			this.ur_USE_COUPON = false;
			this.ur_INSERT_DATE = default(DateTime);
			this.ur_INSERT_USER = "";
			this.ur_UPDATE_DATE = default(DateTime);
			this.ur_UPDATE_USER = "";
		}
	}
}