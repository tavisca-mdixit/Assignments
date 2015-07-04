using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace ConsoleApplication3
{
    class Class1
    {

        static void main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name="Thread";
            Console.WriteLine("This is {0}",th.Name);
            Console.ReadKey();
        }
    }
}
