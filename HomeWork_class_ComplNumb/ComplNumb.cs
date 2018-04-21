using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_class_ComplNumb
{
    class ComplNumb
    {
        public double r;       // r - real number
        public double i;       // i - imaginary number

        public ComplNumb()
        {
            this.r = 0.0;
            this.i = 0.0;
        }
        public static ComplNumb Sum(ComplNumb a, ComplNumb b)
        {
            ComplNumb res = new ComplNumb();
            res.r = a.r + b.r;
            res.i = a.i + b.i;
            return res;
        }
        public static ComplNumb Subtract(ComplNumb a, ComplNumb b)
        {
            ComplNumb res = new ComplNumb
            {
                r = a.r - b.r,
                i = a.i - b.i
            };
            return res;
        }
        public static ComplNumb Multiplication(ComplNumb a, ComplNumb b)
        {
            ComplNumb res = new ComplNumb();
            res.r = a.r * b.r - a.i * b.i;
            res.i = a.i * b.r + a.r * b.i;
            return res;
        }
        public static ComplNumb Division(ComplNumb a, ComplNumb b)
        {
            ComplNumb res = new ComplNumb();
            res.r = a.r / b.r - a.i / b.i;
            res.i = a.i / b.r + a.r / b.i;
            return res;
        }

        public static ComplNumb operator +(ComplNumb a, ComplNumb b)
        {
            return ComplNumb.Sum(a, b);
        }
        public static ComplNumb operator -(ComplNumb a, ComplNumb b)
        {
            return ComplNumb.Subtract(a, b);
        }
        public static ComplNumb operator *(ComplNumb a, ComplNumb b)
        {
            return ComplNumb.Multiplication(a, b);
        }
        public static ComplNumb operator /(ComplNumb a, ComplNumb b)
        {
            return ComplNumb.Division(a, b);
        }
        public override string ToString()
        {
            return String.Format("{0} + i{1}", this.r, this.i);
        }
    }
}
