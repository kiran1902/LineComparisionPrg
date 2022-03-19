using System;

namespace LineComparision
{
    class Distance
    {
        public static double distance(double X1, double Y1, double X2, double Y2)
        {
            //formula
            var temp1 = Math.Pow((X2 - X1), 2);
            var temp2 = Math.Pow((Y2 - Y1), 2);
            double Result = Math.Sqrt(temp1 + temp2);

            return Result;
        }

        //logic to compare two lines
        public static void CompareLines(String Len1 , String Len2)
        {

            if(Len1.CompareTo(Len2) > 0)
            {
                Console.WriteLine("Line1 is greater than Line2");
            } 
            else if(Len1.CompareTo(Len2) < 0) 
            {
                Console.WriteLine("Line1 is less than line2");
            }
            else
            {
                Console.WriteLine("Line1 is equal to line2");
            }
        }

        static void Main(string[] args)
        {

            //user input
            Console.WriteLine("Enter the  X1 , X2 , Y1 , Y2 Coordinates of Line1 : ");
            var X1 = Convert.ToDouble(Console.ReadLine());
            var X2 = Convert.ToDouble(Console.ReadLine());
            var Y1 = Convert.ToDouble(Console.ReadLine());
            var Y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the A1 , A2 , B1 , B2 Coordinates of Line2 : ");
            var A1 = Convert.ToDouble(Console.ReadLine());
            var A2 = Convert.ToDouble(Console.ReadLine());
            var B1 = Convert.ToDouble(Console.ReadLine());
            var B2 = Convert.ToDouble(Console.ReadLine());

            //storing X & Y , A & B variable in Line1 and Line2
            double Line1 = Distance.distance(X1, X2, Y1, Y2);
            double Line2 = Distance.distance(A1, A2, B1, B2);
           
            //compare method
            Distance.CompareLines(Line1.ToString(), Line2.ToString());
            Console.ReadLine();

           
        }
    }
}
