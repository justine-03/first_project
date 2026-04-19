using System.ComponentModel.DataAnnotations;

namespace Lesson_20练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for循环练习题");
            #region 练习题一
            //输出1到100之间的整数
            Console.WriteLine("练习题一");
            for(int i=1;i<=100;i++)
            {
                Console.Write(i);
                Console.Write(" ");

            }
            Console.WriteLine();
            #endregion

            #region 练习题二
            //求1~100之间所有偶数的和
            Console.WriteLine("练习题二");
            int sum = 0;
            for(int i=1;i<=100;i++)
            {
                //判断是否是偶数 是否能整除2
                if(i %2== 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine(sum);
            #endregion


            #region 练习题三
            //找到100~999之间的水仙花数
            //例如：153=1*1*1+5*5*5+3*3*3这个数就是水仙花数
            Console.WriteLine("练习题三");
            for (int i=100;i<=999; i++)
            {
                //判断 每一位 的立方加起来 是不是等于自己
                //得到每一位 百位 十位 个位
                int bai = i / 100;
                int shi = i % 100 / 10;
                int ge = i % 10;
                if(bai*bai*bai+shi*shi*shi+ge*ge*ge==i)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region 练习题四
            //在控制台上输出九九乘法表
            Console.WriteLine("练习题四");
            for(int i=1;i<=9;i++)
            {
                for(int j=i;j<=9;j++)
                {
                    Console.Write("{0}x{1}={2} ", j, i, i * j);
                }
                Console.WriteLine() ;
            }
            #endregion

            #region 练习题五
            Console.WriteLine("练习题五");
            //在控制台上输出如下10*10的空心星型方阵
            //**********
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //*        *
            //**********
            for(int j=0;j<10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (j == 0 || j == 9)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        if (i == 0 || i == 9)

                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

            #endregion

            #region 练习题六
            Console.WriteLine("练习题六");
            //在控制台上输出如下10*10的三角形方阵
            //*
            //**
            //***
            //****
            //*****
            //******
            //*******
            //********
            //*********
            //**********

            //行
            for(int i=0;i<10; i++)
            {
                //列
                for(int j=1;j<=i;j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            #region 练习题七
            Console.WriteLine("练习题七");
            //在控制台上输出如下10行的三角形方阵
            //         *
            //        ***
            //       *****       
            //      *******
            //     *********
            //    ***********
            //   *************
            //  ***************
            // *****************
            //*******************
            for(int i=1;i<=10;i++)
            {
                for(int k=1;k<=10-i;k++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=2*i-1;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
