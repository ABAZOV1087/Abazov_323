using Microsoft.VisualStudio.TestTools.UnitTesting;
using Abazov_323;
using System;

namespace TestProject1
{
    [TestClass]
    public class MathTests
    {
        private MathLibrary math = new MathLibrary();

        // --- PAGE 1: 5 тестов ---
        [TestMethod]
        public void P1_Complex_ValidData_ReturnsValue() => Assert.AreEqual(0, math.CalculateComplexExpression(0, 0, 1), 0.001);

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void P1_Complex_XEqualsTwo_ThrowsException() => math.CalculateComplexExpression(2, 0, 1);

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void P1_Complex_ZZero_ThrowsException() => math.CalculateComplexExpression(0, 0, 0);

        [TestMethod]
        public void P1_Complex_NegativeX_ReturnsValue() => Assert.IsNotNull(math.CalculateComplexExpression(-5, 2, 0.5));

        [TestMethod]
        public void P1_Complex_LargeValues_ReturnsValue() => Assert.IsNotNull(math.CalculateComplexExpression(10, 10, 10));

        // --- PAGE 2: 6 тестов ---
        [TestMethod]
        public void P2_Cond_XMoreY_Sinh_ReturnsValue() => Assert.IsNotNull(math.CalculateConditional(5, 2, 1));

        [TestMethod]
        public void P2_Cond_YMoreX_Sqr_ReturnsValue() => Assert.IsNotNull(math.CalculateConditional(2, 5, 2));

        [TestMethod]
        public void P2_Cond_XEqualY_Exp_ReturnsValue() => Assert.IsNotNull(math.CalculateConditional(1, 1, 3));

        [TestMethod]
        public void P2_Cond_ZeroValues_ReturnsValue() => Assert.IsNotNull(math.CalculateConditional(0, 0, 2));

        [TestMethod]
        public void P2_Cond_NegativeX_ReturnsValue() => Assert.IsNotNull(math.CalculateConditional(-1, 2, 1));

        [TestMethod]
        public void P2_Cond_ModeDefault_UsesExp() => Assert.IsNotNull(math.CalculateConditional(1, 2, 99));

        // --- PAGE 3: 5 тестов ---
        [TestMethod]
        public void P3_Tab_ValidData_ReturnsValue() => Assert.IsNotNull(math.CalculateTabulation(2, 1));

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void P3_Tab_NegativeX_ThrowsException() => math.CalculateTabulation(-1, 1);

        [TestMethod]
        public void P3_Tab_XZero_ReturnsValue() => Assert.AreEqual(-1 * Math.Log(12.7), math.CalculateTabulation(0, 1), 0.001);

        [TestMethod]
        public void P3_Tab_BZero_ReturnsValue() => Assert.IsNotNull(math.CalculateTabulation(1, 0));

        [TestMethod]
        public void P3_Tab_LargeX_ReturnsValue() => Assert.IsNotNull(math.CalculateTabulation(100, 5));
    }
}