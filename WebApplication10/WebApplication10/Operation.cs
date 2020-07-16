using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10
{
    public class Operation
    {
        private double a;
        private double b;

        public double A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public virtual double GetResult(double a,double b,double c)
        {
                     
            return c;
                      
        }
        
    }
}