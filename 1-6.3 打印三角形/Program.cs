using System;

namespace _1_6._3_打印三角形
{
    class Program
    {

        // 1.打印正方形
        /*  ******
         *  ******
         *  ******
         *  ******
         *  ******
         *  ******
         */
        static void Square()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /* 2.打印正向的三角形（第一行有一列，第二行有两列，第三行有三列）
         * j不能大于行号(这边是为了美观到6列，所以
         */
        /*  *
         *  **
         *  ***
         *  ****
         *  *****
         *  ******
         */
        static void Triangle_1()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /* 3.打印反方向的三角形
         *      *           j小于5的时候打空格，大于等于5的时候打星号
         *     **           j小于4的时候打空格，大于等于4的时候打星号
         *    ***
         *   ****
         *  *****
         * ******
         */
        /* 思路就是打印列的时候转化成空格
         * 先试，然后再看
         */
        static void Triangle_2()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if(j < 5-i)  
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 4.打印等腰三角形
        /* *
         * **
         * ***
         * ****
         * *****
         * ******
         * *****
         * ****
         * ***
         * **
         * *
         */
        // 上半部分（抄Triangle_1)
        static void Triangle_3()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // 下半部分(抄Triangle_2）把空格和星号的位置互换
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j < 5 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        // 4.2 写法2（下半部分直接打印星号即可）
        static void Triangle_4()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
          
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5-i; j++)
                {
                    {
                        Console.Write("*");
                    }
                
                }
                Console.WriteLine();
            }
        }

        // 5.打印等腰三角形
        /*    *
         *   ***
         *  *****
         * ******* 
         */
        static void Triangle_5()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5-i; j++)  // 第一行空了6个空格
                {
                    Console.Write(" ");
                }  
                for (int j = 0; j < 2 * i + 1;j++) // 这个j可以先尝试打印一个for (int j = 0; j < 1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Square();

            Triangle_1();

            Triangle_2();

            Triangle_3();

            Triangle_4();

            Triangle_5();

            Console.ReadKey();
        }
    }
}
