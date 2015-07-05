using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace ConsoleApplication10
{
        
    class Money
            {

        private int inr;
        private string currency;
        private int usd;


        public Money(int money, String currency)
        {
            this.inr = money;
            this.currency = currency;
        }

        public void setInr(int inr)
        {
            this.inr = inr;
        }

        public void setUsd(int usd)
        {
            this.usd = usd;
        }

        public void setCurrency(string currency)
        {
            this.currency = currency;
        }

        public int getInr()
        {
            return inr;
        }
        public int getUsd()
        {
            return inr;
        }
        public string getCurrency()
        {
            return currency;
        }


        [SampleAttributes]
          public void calUSD()
        {
          usd=  inr * 60 ;
        }

        [SampleAttributes()]
        public void toString()
        {
              Console.WriteLine("{0} INR is equal to {1} USD ", inr,usd);
        }
        public void calInr()
        {
            inr = usd / 60;
        }

               
        
    }
}
