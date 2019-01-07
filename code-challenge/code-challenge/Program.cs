using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_challenge
{
   class Leapyear
    {
        static void Main(string[] args)
        {
            Leapyear obj = new Leapyear();
            obj.readdata();
            obj.leap();
        }
        int year;
        public void readdata()
        {
            Console.WriteLine("Enter the Year in Four Digits : ");
            year = Convert.ToInt32(Console.ReadLine());
        }
        public void leap()
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }
            Console.ReadLine();
        }

    }

    class matrix
    {
        public static void Main()
        {
            int i, column, row;
            int[,] array1 = new int[10, 10];
            int[] rowSum = new int[10];
            int[] columnSum = new int[10];

            Console.Write("\n\nFind sum of row an column of a Matrix:\n ");
            Console.Write("-------------------------------------------\n");

            /* Ask for size of matrix*/
            Console.Write("Input the size of the square matrix : ");
            row = Convert.ToInt32(Console.ReadLine());

             /*input values for rows and columns*/
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < row; i++)
            {
                for (column = 0; column < row; column++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, column);
                    array1[i, column] = Convert.ToInt32(Console.ReadLine());
                }
            }

            /* Displays what has been populated in the matrix */
            Console.Write("The matrix is :\n");
            for (i = 0; i < row; i++)
            {
                for (column = 0; column < row; column++)
                    Console.Write("{0}  ", array1[i, column]);
                Console.Write("\n");
            }

            /* Sum of rows */
            for (i = 0; i < row; i++)
            {
                rowSum[i] = 0;
                for (column = 0; column < row; column++)
                    rowSum[i] = rowSum[i] + array1[i, column];
            }

            /* Sum of Column */
            for (i = 0; i < row; i++)
            {
                columnSum[i] = 0;
                for (column = 0; column < row; column++)
                    columnSum[i] = columnSum[i] + array1[column, i];
            }

            /* shows the resultls if the sum of rows and columns */
            Console.Write("The sum of rows and columns of the matrix is :\n");
            for (i = 0; i < row; i++)
            {
                for (column = 0; column < row; column++)
                    Console.Write("{0}    ", array1[i, column]);
                Console.Write("{0}    ", rowSum[i]);
                Console.Write("\n");
            }
            Console.Write("\n");
            for (column = 0; column < row; column++)
            {
                Console.Write("{0}   ", columnSum[column]);
            }
            Console.Write("\n\n");
        }
    }

}
