using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcHelperDesktop.Calcs
{
    public static class TransitionCurves
    {
        public static double StraightArc(double Length, double Radius)
        {
            double asin = Math.Asin(Length / (2 * Radius));
            double kappa = 1 / Math.Cos(asin);
            double result = (kappa * Math.Pow(Length, 2) / (6 * Radius)) - (Radius * (1 - Math.Cos(asin)));
            return Math.Round(result, 2);
        }
    }
}
