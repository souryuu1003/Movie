using System;
using movievo;
using uservo;

namespace movieaccess
{
	public class MovieAccess
	{
		string listOfMovie = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE" +", mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE" +
			", mv_MOVIE_START_TIME, mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER" + " from Movie order by mv_START_DATE desc";
		string sesearchOfMovie = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE" + ", mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE" +
			", mv_MOVIE_START_TIME, mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER" + " from Movie where mv_MOVIE_NAME = title";
		string searchOfEmptySeat = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE" + ", mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE" +
			", mv_MOVIE_START_TIME, mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER" + " from Movie where mv_RESERVED_SEAT = false";
		string rankingOfMovie = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE" + ", mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE" +
			", mv_MOVIE_START_TIME, mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER" + " from Movie order by mv_AUDIENCE_NUBER desc";
		string listOfEndMovie = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE" + ", mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE" +
			", mv_MOVIE_START_TIME, mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER" + " from Movie order by mv_END_DATE desc";

		public MovieAccess()
		{
			
		}
	}
}