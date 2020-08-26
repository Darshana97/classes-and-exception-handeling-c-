using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_exception_handeling
{
    class Worker
    {
        public void Print()
        {
            
            Console.WriteLine("Hello Darshana Senevirathna");
            Console.ReadLine();
        }

        public int Add(int x,int y)
        {
            int result = 0;

            try {
               result = x + y;
            }
            catch { }
            return result;

        }
    }
}
