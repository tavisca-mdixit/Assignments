using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    [AttributeUsage(AttributeTargets.Class |
   AttributeTargets.Constructor |
   AttributeTargets.Field |
   AttributeTargets.Method |
   AttributeTargets.Property,
   AllowMultiple = true)]
    class SampleAttributes:Attribute
    {

        static string time;
        
                         
        public SampleAttributes()
        {
            
            time = DateTime.UtcNow.ToString("hh:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            //Console.WriteLine("TIME :{0}", DateTime.UtcNow.ToString("hh:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo));
       
               
        }
    
        public void setTime(string t)
        { 
            time=t;
        }
       
        public string getTime()
        {
            return time;
        }
       
        
    }
}
