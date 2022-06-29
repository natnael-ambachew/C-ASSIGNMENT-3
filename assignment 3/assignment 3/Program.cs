using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{ abstract class shape {
        public abstract double Area();
        public abstract double perimetr();
    }

    class circle : shape
    {
        static readonly double pi = 3.14;
        double r;
        public double radius { get { return r; } set { r = value; }}
        public override double Area()
        {
            return pi * (r*r);
        }

        public override double perimetr()
        {
           return 2*pi*r;
        }
    }
    class Rectangle : shape
    {
        double l;
        double wd;
        public double length { get { return l; } set { l = value; } }
        public double width { get { return wd; } set { wd = value; }}

        public override double Area()
        {
            return l * wd;
        }

        public override double perimetr()
        {
            return 2*(l+wd);
        }
    }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

