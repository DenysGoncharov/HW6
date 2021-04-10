using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoncharovHomeWork6
{
    static class Clalculator
    {
        public static double Add(double operand1, double operand2)
        {
            return operand1 + operand2;
        }

        public static double Sub(double operand1, double operand2)
        {
            return operand1 - operand2;
        }

        public static double Mul(double operand1, double operand2)
        {
            return operand1 * operand2;
        }

        public static double? Div(double operand1, double operand2)
        { if (operand2 == 0)
            { 
                return null;
            }
            else
                return operand1 / operand2;
        }
    }
}
