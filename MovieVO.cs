using System;

public class MovieVO
{
	private uint64 KEY_NO;
	private string MOVIE_NAME;
	private date START_DATE;
	private date END_DATE;
	private uint16? THEATER;
	private uint16? SCREEN_SESSION;
	private Byte? MOVIE_TYPE;
	private date MOVIE_START_TIME;
	private date MOVIE_END_TIME;
	private string SEAT;
	private bool RESERVED_SEAT;
	private uint64? AUDIENCE_NUBER;
	private uint64? TOTAL_AUDIENCE_NUMBER;
	private date INSERT_DATE;
	private string INSERT_USER;
	private date UPDATE_DATE;
	private string UPDATE_USER;

	public MovieVO(uint64 KEY_NO, string MOVIE_NAME, date START_DATE, date END_DATE, uint16? THEATER
		, uint16? SCREEN_SESSION, Byte? MOVIE_TYPE, date MOVIE_START_TIME, string SEAT, bool RESERVED_SEAT
		, uint64? AUDIENCE_NUBER, date INSERT_DATE, string INSERT_USER, date UPDATE_DATE, string UPDATE_USER)
    {
		this.KEY_NO = 0;
		this.MOVIE_NAME = "";
		this.START_DATE = "0000/00/00 00:00:00";
		this.END_DATE = "0000/00/00 00:00:00";
		this.THEATER = null;
		this.SCREEN_SESSION = null;
		this.MOVIE_TYPE = null;
		this.MOVIE_START_TIME = "0000/00/00 00:00:00";
		this.MOVIE_END_TIME = "0000/00/00 00:00:00";
		this.SEAT = "";
		this.RESERVED_SEAT = false;
		this.AUDIENCE_NUBER = null;
		this.TOTAL_AUDIENCE_NUMBER = null;
		this.INSERT_DATE = "0000/00/00 00:00:00";
		this.INSERT_USER = "";
		this.UPDATE_DATE = "0000/00/00 00:00:00";
		this.UPDATE_USER = "";
	}

}