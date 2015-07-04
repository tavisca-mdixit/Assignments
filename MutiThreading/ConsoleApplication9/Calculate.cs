using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;


namespace ConsoleApplication9
{
    class CalCulate
    {
        ConcurrentQueue<int> rnNumber = new ConcurrentQueue<int>();

        ConcurrentQueue<int> evenNumber = new ConcurrentQueue<int>();
        Random rn = new Random();
        static int upperCount = 5;
        public void genRandom(object state)
        {

            while (true)
            {
                rnNumber.Enqueue(rn.Next(100));
       //         Thread.Sleep(10);
            }

        }


        public void checkEven(object state)
        {
            int del;
                while(true)
                {
                    if (rnNumber.TryDequeue(out del))
                    {
                        if (del % 2 == 0)
                        {
                            evenNumber.Enqueue(del);
                        }
                    }
           //         Thread.Sleep(100);
                }
                

        }

        public void printEven(object state)
        {int del;
            while (true)
            {
                if (evenNumber.TryDequeue(out del))
                {
                    Console.WriteLine("This is Even : {0}", del);
                }
                Thread.Sleep(10);
            }
        }

        public void newThread(object state)
         {
             if (rnNumber.Count > upperCount)
             {
                 Console.WriteLine("New Thread Creatred:");
                 System.Threading.ThreadPool.QueueUserWorkItem(
new System.Threading.WaitCallback(printEven1));
             }
             Thread.Sleep(1000);
        }

        public void printEven1(object state)
        {
            int del;
            while (true)
            {
                if (evenNumber.TryDequeue(out del))
                {
                    Console.WriteLine("This is Even : {0}", del);
                }
                //Thread.Sleep(10);
            }
        }
    }
}
