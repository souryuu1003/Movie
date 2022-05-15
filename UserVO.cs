using System;

public class UserVO
{
	private uint64 KEY_NO;
	private string USER_NAME;
	private string CONTACT_INFO;
	private date REG_DATE;
	private Byte? USER_GRADE;
	private uint64 MOVIE_NO;
	private uint16? THEATER;
	private uint16? SCREEN_SESSION;
	private Byte? MOVIE_TYPE;
	private date MOVIE_START_TIME;
	private date MOVIE_END_TIME;
	private string SEAT;
	private bool USE_COUPON;
	private date INSERT_DATE;
	private string INSERT_USER;
	private date UPDATE_DATE;
	private string UPDATE_USER;

	public UserVO(uint64 KEY_NO, string USER_NAME, string CONTACT_INFO, date REG_DATE, Byte? USER_GRADE
		, uint64 MOVIE_NO, uint16? THEATER, uint16? SCREEN_SESSION, Byte? MOVIE_TYPE, date MOVIE_START_TIME
		, date MOVIE_END_TIME, string SEAT, bool USE_COUPON, date INSERT_DATE, string INSERT_USER, string UPDATE_USER)
	{
		this.KEY_NO = 0;
		this.USER_NAME = "";
		this.CONTACT_INFO = "";
		this.REG_DATE = "0000/00/00 00:00:00";
		this.USER_GRADE = null;
		this.MOVIE_NO = 0;
		this.THEATER = null;
		this.SCREEN_SESSION = null;
		this.MOVIE_TYPE = null;
		this.MOVIE_START_TIME = "0000/00/00 00:00:00";
		this.MOVIE_END_TIME = "0000/00/00 00:00:00";
		this.SEAT = "";
		this.USE_COUPON = false;
		this.INSERT_DATE = "0000/00/00 00:00:00";
		this.INSERT_USER = "";
		this.UPDATE_DATE = "0000/00/00 00:00:00";
		this.UPDATE_USER = "";
	}
}
