using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Operatoren
    {
        public static int Add(int n1, int n2)
        {
            return n1+n2;
        }
        public static Double Add(Double n1,Double n2)
        {
            return n1 + n2;
        }
        public static int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public static Double Sub(Double n1, Double n2)
        {
            return n1 - n2;
        }
        public static int Div(int n1, int n2)
        {
            return n1 / n2;
        }
        public static Double Div(Double n1, Double n2)
        {
            return n1 / n2;
        }
        public static int Multi(int n1, int n2)
        {
            return n1 * n2;
        }
        public static Double Multi(Double n1, Double n2)
        {
            return n1 * n2;
        }
        public static Double Wurzel(int n1)
        {
            return Math.Sqrt(n1);
        }
        public static Double Wurzel(Double n1)
        {
            return Math.Sqrt(n1);
        }
    }
}
