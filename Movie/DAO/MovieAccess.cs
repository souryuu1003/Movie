using System;
using movievo;
using uservo;

namespace movieaccess
{

	public class MovieAccess
	{
		MovieVO	mv;
		UserVO ur;

		String sql = "";

		// 영화 일람
		String listOfMovie
			= "SELECT"
			+ "FROM MOVIE"
			+ "WHERE"
			+ "ORDER BY ";

		// 영화 검색
		String searchOfMovie
			= "SELECT"
			+ "FROM MOVIE"
			+ "WHERE";

		// 영화 예매
		String tikkettingOfMovie;

		// 비어있는 좌석 검색(LINQ 사용)
		String emptyOfSeat;

		// 쿠폰을 사용한 회원 수 검색(LINQ 사용)
		String countOfUseCoupon;

		// 총 관객수로 내림차순 정렬
		String descOfPopuler;

		// 예매한 영화 검색
		String searchOfTikkettingMovie;

		// 예매 이력 검색
		String searchOfTikkettingMovieList;

		// 상영 이력 검색
		String EmptyOfSeat;


		public Tuple<MovieVO, UserVO> MovieObject()
        {
			Tuple<MovieVO, UserVO> tuple;

			mv = new MovieVO();
			ur = new UserVO();

			if (insert.Count > 0)
			{
				foreach(MovieVO in insert)
                {
					this.insertSql(mv);

				}
			}
			else if (update.Count > 0)
            {
				foreach (MovieVO in update)
				{
					this.updateSql(mv);
				}
			}
			else if (delete.Count > 0)
			{
				foreach (MovieVO in delete)
				{
					this.deleteSql(mv);
				}
			}

			this.selectSql(mv);

			return tuple;
		}

		public String selectSql(MovieVO mv)
		{
			sql += "SELECT";
			sql += "FROM";
			if()
			sql += "MOVIE";
			
			sql += "WHERE";
			sql += "ORDER BY";

			return sql;
		}

		public String insertSql(MovieVO mv)
        {
			sql += "INSERT INTO";
			sql += "VALUES";

			return sql;
		}

		public String updateSql(MovieVO mv)
		{
			sql += "UPDATE";
			sql += "SET";

			return sql;
		}

		public String deleteSql(MovieVO mv)
		{
			sql += "DELETE";
			sql += "WHERE";

			return sql;
		}

		//string insertOfMovieList = "insert into Movie (mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE, mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE, mv_MOVIE_START_TIME"
		//	+ ", mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER, mv_INSERT_DATE, mv_INSERT_USER, mv_UPDATE_DATE, mv_UPDATE_USER)"
		//	+ "values (mv_KEY_NO = mv_KEY_NO" + "mv_MOVIE_NAME = mv_MOVIE_NAME" + "mv_START_DATE = mv_START_DATE" + "mv_THEATER = mv_THEATER" + "mv_SCREEN_SESSION = mv_SCREEN_SESSION"
		//	+ "mv_MOVIE_TYPE = mv_MOVIE_TYPE" + "mv_MOVIE_START_TIME = mv_MOVIE_START_TIME" + "mv_MOVIE_END_TIME = mv_MOVIE_END_TIME" + "mv_SEAT = mv_SEAT" + "mv_RESERVED_SEAT = mv_RESERVED_SEAT"
		//	+ "mv_AUDIENCE_NUBER = mv_AUDIENCE_NUBER" + "mv_TOTAL_AUDIENCE_NUMBER = mv_TOTAL_AUDIENCE_NUMBER" + "mv_INSERT_DATE = mv_INSERT_DATE" + "mv_INSERT_USER = mv_INSERT_USER"
		//	+ "mv_UPDATE_DATE = mv_UPDATE_DATE" + "mv_UPDATE_USER = mv_UPDATE_USER)";

		//string selectOfMovieList = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE, mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE, mv_MOVIE_START_TIME"
		//	+ ", mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER, mv_INSERT_DATE, mv_INSERT_USER, mv_UPDATE_DATE, mv_UPDATE_USER, mv_UPDATE_USER"
		//	+ " from Movie order by mv_START_DATE desc";

		//string updateOfMovieList = "update Movie set"
		//	+"mv_MOVIE_TYPE = mv_MOVIE_TYPE" + "and mv_MOVIE_START_TIME = mv_MOVIE_START_TIME" + "and mv_MOVIE_END_TIME = mv_MOVIE_END_TIME" + "and mv_SEAT = mv_SEAT"
		//	+ "and mv_RESERVED_SEAT = mv_RESERVED_SEAT" + "and mv_AUDIENCE_NUBER = mv_AUDIENCE_NUBER" + "and mv_TOTAL_AUDIENCE_NUMBER = mv_TOTAL_AUDIENCE_NUMBER"
		//	+ "and mv_UPDATE_DATE = mv_UPDATE_DATE" + "and mv_UPDATE_USER = mv_UPDATE_USER)";

		//string deleteOfMovie = "delete Movie where mv_KEY_NO = mv_KEY_NO";


		//string sesearchOfMovie = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE" + ", mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE" +
		//	", mv_MOVIE_START_TIME, mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER" + " from Movie where mv_MOVIE_NAME = title";
		//string searchOfEmptySeat = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE" + ", mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE" +
		//	", mv_MOVIE_START_TIME, mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER" + " from Movie where mv_RESERVED_SEAT = false";
		//string rankingOfMovie = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE" + ", mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE" +
		//	", mv_MOVIE_START_TIME, mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER" + " from Movie order by mv_AUDIENCE_NUBER desc";
		//string listOfEndMovie = "select mv_KEY_NO, mv_MOVIE_NAME, mv_START_DATE, mv_END_DATE" + ", mv_THEATER, mv_SCREEN_SESSION, mv_MOVIE_TYPE" +
		//	", mv_MOVIE_START_TIME, mv_MOVIE_END_TIME, mv_SEAT, mv_RESERVED_SEAT, mv_AUDIENCE_NUBER, mv_TOTAL_AUDIENCE_NUMBER" + " from Movie order by mv_END_DATE desc";

	}
}