using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10
{
    public class except: Operation
    {
        public double AddMethod(double a, double b)
        {
            double except= a * b;
            return except;
        }
    }
}