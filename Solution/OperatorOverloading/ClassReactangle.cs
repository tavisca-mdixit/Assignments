using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ClassRectangle
    {

        public double Breadth { get; set; }
        public double Length { get; set; }
    
        private double Area;
        public void setArea() {
            try { this.Area = this.Length * this.Breadth;
            if (double.IsInfinity(Area))
            {
                throw new System.OverflowException("OverFlow");
            }
            }
            catch (OverflowException E)
            { Console.WriteLine("The Value Entered is Incorrect " );
            Console.Error.WriteLine(E.StackTrace);
            }
        }

        public double getArea() { return Area; }
  


    public static ClassRectangle operator +(ClassRectangle rectangleOne, ClassRectangle rectangleTwo)
    {
        ClassRectangle NewReactangle = new ClassRectangle();
        try
        {
            NewReactangle.Length = rectangleOne.Length + rectangleTwo.Length;
            NewReactangle.Breadth = rectangleOne.Breadth + rectangleTwo.Breadth;
            if (double.IsInfinity(NewReactangle.Length) || double.IsInfinity(NewReactangle.Breadth))
            {
                throw new System.OverflowException("OverFlow");
            }
        }
        catch (OverflowException E)
        {
            Console.WriteLine("The Value Entered is Incorrect ");
            Console.Error.WriteLine(E.StackTrace);
       
        }
       
        return NewReactangle;
    }
       

      

        

    }
}
