using System;

namespace LineComparision
{
    class Distance
    {
        public int X1 , X2 , Y1 , Y2;  

        public void LineCompare()
        {
            double[] Cordination = new double[5];
            for (int i = 1; i < 2; i++)
            {
                Console.WriteLine("Enter coordinate X1 : ");
                this.X1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate Y1 : ");
                this.Y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate X2 : ");
                this.X2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate Y2 : ");
                this.Y2 = int.Parse(Console.ReadLine());
            }
        }
        public double  distance()
        {
            //formula
            double Result = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

            //Round method() used for rounding decimal value up to 2 digits
            double length = Math.Round(Result, 2);
            return length;
        }

        //method to check equality of two lines 
        public void LineEq(string line1, string line2)
        {
            
            if (double.Equals(line1, line2))
            {
                Console.WriteLine(line1 + "is equals to" + line2);
            }
            else
            {
                Console.WriteLine(line1 + "{0} is not equal to {1}" + line2);
            }
        }

        //Method to compare two lines
        public void CompareLines(String Len1 , String Len2)
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

            Distance distance = new Distance();
            double line1 = distance.distance();

            Distance obj2 = new Distance();
            double line2 = obj2.distance();

            Console.WriteLine("Length of the first line " + line1);
            Console.WriteLine("Length of the secod line " + line2);
            
            distance.LineEq(line1.ToString(), line2.ToString());

            distance.CompareLines(line1.ToString(), line2.ToString());
            Console.ReadLine();
;

           
        }
    }
}
