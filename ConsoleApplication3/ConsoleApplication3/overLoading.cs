using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class overLoading
    {
public 
        int breadth;
        int length;
        int area;

        static void Main(string[] args)
        {
            overLoading input = new overLoading();
            overLoading input1 = new overLoading();
            overLoading input2 = new overLoading();
          
            input.set(5, 6);
            input1.set(7, 8);
         input.cal();
            input1.cal();
           input.get();
           input1.get();
           input2 = input + input1;
           input2.cal();
           input2.get();

        }

        public void set(int l, int b)
        {
            this.length = l;
            this.breadth = b;
        //    Console.WriteLine("Length:{0}", length, "Breadth:{0}", breadth, "Area :{0}", area);
         //   Console.ReadKey();
        }

        public void get()
        {
            Console.WriteLine(" ");
            //Console.WriteLine("Length:{0}", length, "Breadth:{1}", breadth, "Area :{2}", area);
            Console.WriteLine("Length:{0}  Breadth:{1}  Area :{2}", length, breadth, area);
         //   Console.WriteLine("Breadth:{0}", breadth);
           // Console.WriteLine( "Area :{0}", area);
           
            Console.ReadKey();
        }

        public static overLoading operator+(overLoading a,overLoading b)
        {
            overLoading input = new overLoading();
            input.length = a.length + b.length;
            input.breadth = a.breadth + b.breadth;
            return input;
        }
        public void cal()
        {
            area = this.length * this.breadth;
        }

        

    }
}
