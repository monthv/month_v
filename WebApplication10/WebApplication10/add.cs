using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10
{
    public class add : Operation
    {
        public double AddMethod(double a, double b)
        {
            double add = a * b;
            return add;
        }
    }
}