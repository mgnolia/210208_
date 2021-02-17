﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayTest210208
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1차원 배월 초기화
            int[] arrInt = { 10, 20, 30, 40 };
            for (int i=0; i<arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i] + "");
                string str = string.Format("배열[{0}]:{1}",
                    i, arrInt[i]);
                Console.WriteLine(str);
            }

            //1차원 배열 초기화 2
            Char[] arrCh = new char[4] { '이', '김', '박', '홍' };
            for (int i = 0; i < arrCh.Length; i++)
            {
                // System.out.println()
                // System.out.print()
                Console.WriteLine(arrCh[i] + " ");
            }

            //2차원 배열 초기화
            int[,] arrInt2 =
            {
                {1, 2, 3 }, {4, 5, 6}
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrInt2[i, j] + " ");
                }
                // 2차원 배열 초기화
                // 상수 변수 (final)
                const int SIZE_ROW = 2;
                const int SIZE_COL = 3;
                int[,] arrInt2_1 =
                    new int[SIZE_ROW, SIZE_COL]
                    {
                        {1, 2, 3 },
                        {4, 5, 6 }
                    };
                for (int i = 0; i < SIZE_ROW; i++)
                {
                    for (int j = 0; j < SIZE_COL; j++)
                    {
                        Console.Write(arrInt2_1[i, j]+"");
                    }
                    Console.WriteLine();
                }
                // 2차원 배열 초기화 3
                string[][] arrStr1 = new string[2][];
                arrStr1[0] = 
                    new string[] { "김길동", "홍길동", "박길동" };
                arrStr1[1] =
                    new string[] { "이길동" };
                for (int i = 0; i < arrStr1.Length; i++)
                {
                    for (int j = 0; j < arrStr1[i].Length; j++)
                    {
                        Console.WriteLine(arrStr1[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                // 2차우너 배열 초기화4
                int[][] arrInt2_4 = new int[3][];
                for (int i = 0; i < arrInt2_4.Length; i++)
                {
                    for (int j  = 0;  j  < arrInt2_4.Length;  j ++)
                    {
                        arrInt2_4[i][j] = 10 + j;
                        Console.WriteLine(arrInt2_4[i][j]+"");
                    }
                    Console.WriteLine();
                }
                // foreach (향상된 for문) 1차원
                int[] arrEach1 = { 1, 2, 3, 4, 5 };
                foreach (int i in arrEach1)
                {
                    Console.WriteLine(  i);
                }
                // foreach 2차원
                string[,] arrEach2 =
                 {
                   { "홍길동", "김길동},
                   { "hong", "kim"};
                };
            }    
            
        }                              
    }
}
