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
        public void TestTransitionCurveBetweenStraightAndCurve(double Length, double Radius, double Expected)
        {
            double Result = TransitionCurves.StraightArc(Length, Radius);

            Assert.AreEqual(Expected, Result);
        }
    }
}
