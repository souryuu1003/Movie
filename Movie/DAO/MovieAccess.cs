using System;
using movievo;
using uservo;

namespace movieaccess
{
	public class MovieAccess
	{
		MovieVO movieVO;

		int maxLength = 1;

		public MovieAccess()
		{
			
		}

		public List<MovieVO> listMovie()
		{

			List<MovieVO> movieList = new List<MovieVO>();
			
			for (int i = 0; i < maxLength; i++)
            {
				movieVO = new MovieVO();
				

				movieList.Add(movieVO);
			}

			
			
			return movieList;
		}
	}
}