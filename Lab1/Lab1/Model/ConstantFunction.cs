using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    internal class ConstantFunction : Function
    {
        private double C { get; set; }

        public ConstantFunction()
        {
            C = 0;
        }

        public ConstantFunction(double c)
        {
            C = c;
        }

        public override dynamic Calculate(double value)
        {
            return $"y = {C}";
        }

        public override string Derivative()
        {
            return "y' = 0";
        }

        public override bool Equals(object obj)
        {
            if (obj is not ConstantFunction other)
            {
                return false;
            }
            return C == other.C;
        }

        public override string ToString()
        {
            return $"y = {C}";
        } 

        public override int GetHashCode()
        {
            return C.GetHashCode();
        }


    }
}

