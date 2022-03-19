using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Nissan";
            myCar.Model = "Versa";
            myCar.Year = "2017";
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model); 
            Console.WriteLine(myCar.Year);
            
        }
    }
}
