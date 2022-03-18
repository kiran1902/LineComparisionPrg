using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    public class Distance
    {
        public void Main(String[] args)
        {
            //user input
            Console.WriteLine("Enter the length of Point X1 and X2: ");
            var X1 = Convert.ToDouble(Console.ReadLine());
            var X2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Length of Point Y1 and Y2 : ");
            var Y1 = Convert.ToDouble(Console.ReadLine());
            var Y2 = Convert.ToDouble(Console.ReadLine());


            //Initial Formula to calculate the Distane of the Line
            var temp1 = Math.Pow((X2 - X1), 2);
            var temp2 = Math.Pow((Y2 - Y1), 2);

            //Final formula
            double Result = Math.Sqrt(temp1 + temp2);

            Console.WriteLine(" The Length of Line is : " + Result);


        }
    }
    
}
