using System;
using movievo;
using uservo;

namespace movieaccess
{
	public class MovieAccess
	{
		string insertOfMovieList = "insert into Movie (mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE, mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE, mv_MOVIE_START_TIME"
			+ ", mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER, mv_INSERT_DATE, mv_INSERT_USER, mv_UPDATE_DATE, mv_UPDATE_USER)"
			+ "values (mv_KEY_NO = mv_KEY_NO" + "mv_MOVIE_NAME = mv_MOVIE_NAME" + "mv_START_DATE = mv_START_DATE" + "mv_THEATER = mv_THEATER" + "mv_SCREEN_SESSION = mv_SCREEN_SESSION"
			+ "mv_MOVIE_TYPE = mv_MOVIE_TYPE" + "mv_MOVIE_START_TIME = mv_MOVIE_START_TIME" + "mv_MOVIE_END_TIME = mv_MOVIE_END_TIME" + "mv_SEAT = mv_SEAT" + "mv_RESERVED_SEAT = mv_RESERVED_SEAT"
			+ "mv_AUDIENCE_NUBER = mv_AUDIENCE_NUBER" + "mv_TOTAL_AUDIENCE_NUMBER = mv_TOTAL_AUDIENCE_NUMBER" + "mv_INSERT_DATE = mv_INSERT_DATE" + "mv_INSERT_USER = mv_INSERT_USER"
			+ "mv_UPDATE_DATE = mv_UPDATE_DATE" + "mv_UPDATE_USER = mv_UPDATE_USER)";

		string selectOfMovieList = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE, mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE, mv_MOVIE_START_TIME"
			+ ", mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER, mv_INSERT_DATE, mv_INSERT_USER, mv_UPDATE_DATE, mv_UPDATE_USER, mv_UPDATE_USER"
			+ " from Movie order by mv_START_DATE desc";

		string updateOfMovieList = "update Movie set"
			+"mv_MOVIE_TYPE = mv_MOVIE_TYPE" + "and mv_MOVIE_START_TIME = mv_MOVIE_START_TIME" + "and mv_MOVIE_END_TIME = mv_MOVIE_END_TIME" + "and mv_SEAT = mv_SEAT"
			+ "and mv_RESERVED_SEAT = mv_RESERVED_SEAT" + "and mv_AUDIENCE_NUBER = mv_AUDIENCE_NUBER" + "and mv_TOTAL_AUDIENCE_NUMBER = mv_TOTAL_AUDIENCE_NUMBER"
			+ "and mv_UPDATE_DATE = mv_UPDATE_DATE" + "and mv_UPDATE_USER = mv_UPDATE_USER)";

		string deleteOfMovie = "delete Movie where mv_KEY_NO = mv_KEY_NO";


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