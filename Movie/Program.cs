using System;
using movieaccess;
using useraccess;

Console.OutputEncoding = System.Text.Encoding.UTF8;

mainPage();

void mainPage()
{
    Console.WriteLine("1 : 영화 일람");
    Console.WriteLine("2 : 영화 검색");
    Console.WriteLine("3 : 영화 예매 ");
    Console.WriteLine("4 : 비어있는 좌석 검색(LINQ 사용)");
    Console.WriteLine("5 : 쿠폰을 사용한 회원 수 검색(LINQ 사용)");
    Console.WriteLine("6 : 총 관객수로 내림차순 정렬");
    Console.WriteLine("7 : 예매한 영화 검색");
    Console.WriteLine("8 : 예매 이력 검색");
    Console.WriteLine("9 : 상영 이력 검색");

    inputPage();
}
    
void inputPage()
{
    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("영화 일람");
            listMovie();
            return;

        case "2":
            Console.WriteLine("영화 검색");
            searchMovie();
            return;

        case "3":
            Console.WriteLine("영화 예매 ");
            tikkettingMovie();
            return;

        case "4":
            Console.WriteLine("비어있는 좌석 검색(LINQ 사용)");
            searchEmptySeat();
            return;

        case "5":
            Console.WriteLine("쿠폰을 사용한 회원 수 검색(LINQ 사용)");
            searchCouponUser();
            return;

        case "6":
            Console.WriteLine("총 관객수로 내림차순 정렬");
            rankingMovie();
            return;

        case "7":
            Console.WriteLine("예매한 영화 검색");
            currentTikketting();
            return;

        case "8":
            Console.WriteLine("예매 이력 검색");
            listTikketting();
            return;

        case "9":
            Console.WriteLine("상영 이력 검색");
            listEndMovie();
            return;
    }

}


void listMovie()
{

    mainPage();
}

void searchMovie()
{
    mainPage();
}

void tikkettingMovie()
{
    mainPage();
}

void searchEmptySeat()
{
    mainPage();
}

void searchCouponUser()
{
    mainPage();
}

void rankingMovie()
{
    mainPage();
}

void currentTikketting(){
    mainPage();
}

void listTikketting(){
    mainPage();
}

void listEndMovie(){
    mainPage();
}