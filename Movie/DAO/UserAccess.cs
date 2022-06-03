using System;
using uservo;
using movievo;

namespace useraccess
{
	public class UserAccess
	{
		string insertOUserList = "insert into Movie (ur_KEY_NO, ur_USER_NAME, ur_CONTACT_INFO, ur_REG_DATE, ur_USER_GRADE, ur_MOVIE_NO, ur_THEATER, ur_SCREEN_SESSION"
			+ ", ur_MOVIE_TYPE, ur_MOVIE_START_TIME, ur_MOVIE_END_TIME, ur_SEAT, ur_USE_COUPON, ur_INSERT_DATE, ur_INSERT_USER, ur_UPDATE_DATE, ur_UPDATE_USER)"
			+ "values (ur_KEY_NO = ur_KEY_NO" + "ur_USER_NAME = ur_USER_NAME" + "ur_CONTACT_INFO = ur_CONTACT_INFO" + "ur_USER_GRADE = ur_USER_GRADE" + "ur_MOVIE_NO = ur_MOVIE_NO"
			+ "ur_THEATER = ur_THEATER" + "ur_SCREEN_SESSION = ur_SCREEN_SESSION" + "ur_MOVIE_TYPE = ur_MOVIE_TYPE" + "ur_MOVIE_START_TIME = ur_MOVIE_START_TIME" + "ur_MOVIE_END_TIME = ur_MOVIE_END_TIME"
			+ "ur_SEAT = ur_SEAT" + "ur_USE_COUPON = ur_USE_COUPON" + "ur_INSERT_DATE = ur_INSERT_DATE" + "ur_INSERT_USER = ur_INSERT_USER"
			+ "ur_UPDATE_DATE = ur_UPDATE_DATE" + "ur_UPDATE_USER = ur_UPDATE_USER)";

		string selectOfUserList = "select ur_KEY_NO, ur_USER_NAME, ur_CONTACT_INFO, ur_REG_DATE, ur_USER_GRADE, ur_MOVIE_NO, ur_THEATER, ur_SCREEN_SESSION"
			+ ", ur_MOVIE_TYPE, ur_MOVIE_START_TIME, ur_MOVIE_END_TIME, ur_SEAT, ur_USE_COUPON, ur_INSERT_DATE, ur_INSERT_USER, ur_UPDATE_DATE, ur_UPDATE_USER, ur_UPDATE_USER"
			+ " from Movie order by ur_CONTACT_INFO desc";

		string updateOfUserList = "update Movie set"
			+ "ur_THEATER = ur_THEATER" + "and ur_SCREEN_SESSION = ur_SCREEN_SESSION" + "and ur_MOVIE_TYPE = ur_MOVIE_TYPE" + "and ur_MOVIE_START_TIME = ur_MOVIE_START_TIME"
			+ "and ur_MOVIE_END_TIME = ur_MOVIE_END_TIME" + "and ur_SEAT = ur_SEAT" + "and ur_USE_COUPON = ur_USE_COUPON"
			+ "and ur_UPDATE_DATE = ur_UPDATE_DATE" + "and ur_UPDATE_USER = ur_UPDATE_USER)";

		string deleteOfUser = "delete Movie where ur_KEY_NO = ur_KEY_NO";


		string tikkettingOfMovie = "update Movie set ur_MOVIE_END_TIME = true where ur_KEY_NO";
		string searchOfCouponUser = "";
		string currentOfTikketting = "";
		string listOfTikketting = "select ur_KEY_NO, ur_USER_NAME, ur_CONTACT_INFO, ur_REG_DATE, ur_USER_GRADE" +
			", ur_MOVIE_NO, ur_THEATER, ur_SCREEN_SESSION, ur_MOVIE_TYPE" +
			"ur_MOVIE_START_TIME, ur_MOVIE_END_TIME, ur_SEAT, ur_USE_COUPON from User where ur_SEAT != \"\"";

		public UserAccess()
		{
			
		}
	}
}