﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    internal class PowerFunction : Function
    {
        private double Сoefficient { get; set; }

        private double Degree { get; set; }

        public PowerFunction()
        {
            Сoefficient = 0;
            Degree = 0;
        }

        public PowerFunction(double coefficient, double degree)
        {
            Сoefficient = coefficient;
            Degree = degree;
        }

        public override dynamic Calculate(double x)
        {
            return Сoefficient * Math.Pow(x, Degree);
        }

        public override string Derivative()
        {
            if (Degree == 0 || Сoefficient == 0)
            {
                return "y' = 0";
            }
            if (Degree == 1)
            {
                return $"y' = {Сoefficient * Degree}";
            }
            return $"y' = {Сoefficient * Degree}x^{Degree - 1}";
        }

        public override bool Equals(Object obj)
        {
            if (obj is not PowerFunction other)
            {
                return false;
            }
            return (Сoefficient == other.Сoefficient) && (Degree == other.Degree);
        }

        public override string ToString()
        {
            if (Сoefficient == 0)
            {
                return $"y = 0";
            }
            if (Сoefficient == 1 && Degree != 0)
            {
                return $"y = x^{Degree}";
            }
            if (Degree == 0)
            {
                return $"y = {Сoefficient}";
            }
            return $"y = {Сoefficient}x^{Degree}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Сoefficient, Degree);
        }
    }
}
