using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    internal class LogarithmFunction : Function
    {
        private double BaseLog { get; set; }

        public LogarithmFunction()
        {
            BaseLog = 0;
        }

        public LogarithmFunction(double baseLog)
        {
            BaseLog = baseLog;
        }

        public override dynamic Calculate(double x)
        {
            if (x <= 0 || BaseLog <= 0 || BaseLog == 1)
            {
                return "Cannot be determined. Change the value.";
            }
            return Math.Log(x, BaseLog);
        }

        public override string Derivative()
        {
            if (BaseLog <= 0 || BaseLog == 1)
            {
                return "Cannot be determined. Change the value.";
            }
            return $"y' = {Math.Round((1 / Math.Log(BaseLog)),2)}*x^-1";
        }

        public override bool Equals(Object obj)
        {
            if (obj is not LogarithmFunction other)
            {
                return false;
            }
            return BaseLog == other.BaseLog;
        }

        public override string ToString()
        {
            return $"y = log_{BaseLog}x";
        }

        public override int GetHashCode()
        {
            return BaseLog.GetHashCode();
        }
        
    }
    
}

