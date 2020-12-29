using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcHelperDesktop.Calcs
{
    public class TransitionCurves
    {
        public static double ShiftForStraightToArc(double Length, double Radius)
        {
            double asin = Math.Asin(Length / (2 * Radius));
            double kappa = 1 / Math.Cos(asin);
            double result = (kappa * Math.Pow(Length, 2) / (6 * Radius)) - (Radius * (1 - Math.Cos(asin)));
            return Math.Round(result, 2);
        }

        public static double ShiftForArcToArc(double Length, double FirstRadius, double SecondRadius)
        {
            double result = (Math.Pow(Length, 2) / (6 * SecondRadius) - SecondRadius * (1 - Math.Cos(Length / (2 * SecondRadius))))
                - ((Math.Pow(Length, 2) / (6 * FirstRadius)) - (FirstRadius * (1 - Math.Cos(Length / (2 * FirstRadius)))));

            return Math.Round(result, 2);
        }
    }
}
