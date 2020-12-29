using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CalcHelperDesktop.Calcs;

namespace CalcHelperDesktop.Tests
{
    [TestFixture]
    public class TransitionCurvesTests
    {
        [TestCase(90, 975, 0.35)]
        [TestCase(23.564, 904.53, 0.03)]
        [TestCase(80, 450, 0.60)]
        public void TestShiftForTransitionCurveBetweenStraightAndArc(double Length, double Radius, double Expected)
        {
            double Result = TransitionCurves.ShiftForStraightToArc(Length, Radius);

            Assert.AreEqual(Expected, Result);
        }

        [TestCase(30, 800, 400, 0.05)]
        [TestCase(30, 250, 410, -0.06)]
        public void TestShiftForTransitionCurveBetweenTwoArcs(double Length, double FirstRadius, double SecondRadius, double Expected)
        {
            double Result = TransitionCurves.ShiftForArcToArc(Length, FirstRadius, SecondRadius);

            Assert.AreEqual(Expected, Result);
        }
    }
}
