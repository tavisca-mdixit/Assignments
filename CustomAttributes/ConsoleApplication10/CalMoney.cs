using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Threading;


namespace ConsoleApplication10
{
    class CalMoney
    {
      
        public static void Main(string[] args)
        {
           
            Money obj = new Money(100, "USD");
            

            obj.calUSD();
          
            obj.toString();
            customDisplay();

            obj.calUSD();
           
            obj.toString();
            customDisplay();
         
         

           
   
            Console.ReadKey();
        }

        public static void customDisplay()
        {
            Type type = typeof(Money);
           
                

                Thread.Sleep(1000);

                foreach (MethodInfo m in type.GetRuntimeMethods())
                {
                    foreach (Attribute a in m.GetCustomAttributes(true))
                    {
                        SampleAttributes obj1 = (a as SampleAttributes);

                        if (null != obj1)
                        {

                            Console.WriteLine("The Function called is : {0} ,, Time of function call is {1} ", m.Name, obj1.getTime());

                        }
                    }
                }
            



        }

    }
}
