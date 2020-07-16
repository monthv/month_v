using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10
{
    public class cut: Operation
    {
        public double AddMethod(double a, double b)
        {
            double cut = a * b;
            return cut;
        }
    }
}