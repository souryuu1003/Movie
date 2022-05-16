using System;
using uservo;
using movievo;

namespace useraccess
{
	public class UserAccess
	{
		string tikkettingOfMovie = "update Movie set mv_RESERVED_SEAT = true where ur_KEY_NO";
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