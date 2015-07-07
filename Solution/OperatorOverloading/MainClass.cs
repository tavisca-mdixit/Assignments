using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace ConsoleApplication3
{
    class MainClass
    {

        static void Main(string[] args)
        {
            ClassRectangle RectangleOne = new ClassRectangle();
            ClassRectangle RectangleTwo = new ClassRectangle();
            ClassRectangle RectangleThree = new ClassRectangle();
            
            RectangleOne.Breadth = 6;
            RectangleOne.Length = 6;
            RectangleTwo.Breadth = double.MaxValue;
            RectangleTwo.Length = double.MaxValue;



            RectangleOne.setArea();
            RectangleTwo.setArea();
            Console.WriteLine("The Length and Breadth of Rectangle 1 is:{0}   ,,  {1}  and the Area is :{2}",RectangleOne.Length,RectangleOne.Breadth,RectangleOne.getArea());
         
            Console.WriteLine("The Length and Breadth of Rectangle 2 is {0}  ,,   {1}  and the Area is {2}", RectangleTwo.Length, RectangleTwo.Breadth, RectangleOne.getArea());
         
            RectangleThree = RectangleOne + RectangleTwo;
            RectangleThree.setArea();
            Console.WriteLine("The Length and Breadth of Rectangle 2 is {0}  ,,   {1}  and the Area is {2}", RectangleThree.Length, RectangleThree.Breadth, RectangleThree.getArea());
       
            
            Console.ReadKey();
        }
    }
}
