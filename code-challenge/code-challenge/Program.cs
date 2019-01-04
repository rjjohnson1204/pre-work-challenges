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
}
