using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_exception_handeling
{
    class Program
    {
        static Worker worker1 = new Worker();
        static void Main(string[] args)
        {
            Console.WriteLine(worker1.Add(10, 20));
            worker1.Print();
            Console.ReadLine();
        }
    }
} 
