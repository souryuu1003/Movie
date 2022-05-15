using System;

namespace movievo
{
	class MovieVO
	{
		private UInt64 mv_KEY_NO;
		private string mv_MOVIE_NAME;
		private DateTime mv_START_DATE;
		private DateTime mv_END_DATE;
		private UInt16? mv_THEATER;
		private UInt16? mv_SCREEN_SESSION;
		private Byte? mv_MOVIE_TYPE;
		private DateTime mv_MOVIE_START_TIME;
		private DateTime mv_MOVIE_END_TIME;
		private string mv_SEAT;
		private bool mv_RESERVED_SEAT;
		private UInt64? mv_AUDIENCE_NUBER;
		private UInt64? mv_TOTAL_AUDIENCE_NUMBER;
		private DateTime mv_INSERT_DATE;
		private string mv_INSERT_USER;
		private DateTime mv_UPDATE_DATE;
		private string mv_UPDATE_USER;

		public MovieVO()
		{
			this.mv_KEY_NO = 0;
			this.mv_MOVIE_NAME = "";
			this.mv_START_DATE = default(DateTime);
			this.mv_END_DATE = default(DateTime);
			this.mv_THEATER = null;
			this.mv_SCREEN_SESSION = null;
			this.mv_MOVIE_TYPE = null;
			this.mv_MOVIE_START_TIME = default(DateTime);
			this.mv_MOVIE_END_TIME = default(DateTime);
			this.mv_SEAT = "";
			this.mv_RESERVED_SEAT = false;
			this.mv_AUDIENCE_NUBER = null;
			this.mv_TOTAL_AUDIENCE_NUMBER = null;
			this.mv_INSERT_DATE = default(DateTime);
			this.mv_INSERT_USER = "";
			this.mv_UPDATE_DATE = default(DateTime);
			this.mv_UPDATE_USER = "";
		}

	}
}