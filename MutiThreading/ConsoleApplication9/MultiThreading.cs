using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class MutltiThreading
    {
        static void Main(string[] args)
         { 
            CalCulate obj=new CalCulate();
            
            System.Threading.ThreadPool.QueueUserWorkItem(
        new System.Threading.WaitCallback(obj.genRandom));
        System.Threading.ThreadPool.QueueUserWorkItem(
        new System.Threading.WaitCallback(obj.checkEven));
        System.Threading.ThreadPool.QueueUserWorkItem(
        new System.Threading.WaitCallback(obj.printEven));
        System.Threading.ThreadPool.QueueUserWorkItem(
   new System.Threading.WaitCallback(obj.newThread));


        Console.ReadKey();
    
         }

    }

}
