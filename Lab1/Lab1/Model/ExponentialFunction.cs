using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    internal class ExponentialFunction : Function
    {
        private double BaseDegree { get; set; }

        public ExponentialFunction()
        {
            BaseDegree = 0;
        }

        public ExponentialFunction(double baseDegree)
        {
            BaseDegree = baseDegree;
        }

        public override dynamic Calculate(double x)
        {
            if (BaseDegree <= 0 || BaseDegree == 1)
            {
                return "Cannot be determined. Change the value.";
            }
            return Math.Pow(BaseDegree, x);
        }

        public override string Derivative()
        {
            if (BaseDegree <= 0 || BaseDegree == 1)
            {
                return "y'= 0";
            }
            return $"y'= {BaseDegree}^x*{Math.Round(Math.Log(BaseDegree), 2)}";
        }

        public override bool Equals(object obj)
        {
            if (obj is not ExponentialFunction other)
            {
                return false;
            }
            return BaseDegree == other.BaseDegree;
        }
        public override string ToString()
        {
            return $"y = {BaseDegree}^x";
        }

        public override int GetHashCode()
        {
            return BaseDegree.GetHashCode();
        }
    }
}
