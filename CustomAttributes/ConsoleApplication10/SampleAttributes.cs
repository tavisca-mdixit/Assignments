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

        String time;
                         
        public SampleAttributes()
        {
            
            this.time = DateTime.UtcNow.ToString("hh:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }
    
        public void setTime(string time)
        {
            this.time=time;
        }
       
        public string getTime()
        {
            return time;
        }
    }
}
