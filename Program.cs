using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TheReturnKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling methods with a return type
            Console.WriteLine(cube(5));
            //this wont give anything to console
            cube(5);

            //freezing the console
            Console.ReadLine();
        }
        //Declare a method with a return type
        static int cube(int number)
        {
            int results = number * number * number;
            return results;
        }
    }
}
