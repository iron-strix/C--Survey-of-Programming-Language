//Nigel Little
//CITP 3310 v03
//Assignment 7
//04/10/2022

using System;

namespace Assign7
{
    class Program
    {
        static void Main(string[] args)
        {
            //main for loop to go thru the lines to be drawn, 1 thru 10
           for (int i = 1; i <= 10; i++)
            {
                //int j is used for "*"
                //int k is used for " "

                //draw line of first triangle
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 10; k > i; k--)
                {
                    Console.Write(" ");
                }

                //to create buffer between triangles
                Console.Write(" ");

                //draw line of second triangle
                for (int j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }

                for (int k = 1; k < i; k++)
                {
                    Console.Write(" ");
                }

                //to create buffer between triangles
                Console.Write(" ");

                //draw line of third triangle
                for (int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }

                //to create buffer between triangles
                Console.Write(" ");

                //draw line of fourth triangle
                for (int k = 10; k > i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                //new line
                Console.Write("\n");
            }
        }

        static void TriangleA()
        {
            for(int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void TriangleB()
        {
            for (int i = 10; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void TriangleC()
        {
            for (int i = 0; i <= 10; i++)
            {
                for(int k = 0; k < i; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 10; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void TriangleD()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 10; k > i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
