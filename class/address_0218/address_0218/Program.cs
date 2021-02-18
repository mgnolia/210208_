using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_0218
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                switch (getMenu())
                {
                    case 1:
                        Console.WriteLine("정보 추가");
                    case 2:
                        Console.WriteLine("정보 보기");
                    case 3:
                        Console.WriteLine();

                }
            }
        }
        public static int getMenu()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("1.주소록 정보 추가");
            Console.WriteLine("2.주소록 정보 추가");
            Console.WriteLine("3.종료");
            Console.WriteLine("---------------------");
            Console.WriteLine("메뉴 선택: ");
            int menu =
                Convert.ToInt32(Console.ReadLine());
            return menu;
        }
    }
}
