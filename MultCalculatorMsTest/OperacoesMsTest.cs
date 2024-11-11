using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultCalculatorMsTest
{
    public class OperacoesMsTest
    {
        public double AddMsTest(double addMsTestValue1, double addMsTestValue2)
        {

            return addMsTestValue1 + addMsTestValue2;
        }

        public double SubtractMsTest(double subtractMsTestValue1, double subtractMsTestValue2)
        {
            return subtractMsTestValue1 - subtractMsTestValue2;
        }
        public double MultiplyMsTest(double multiplyMsTestValue1, double multiplyMsTestValue2)
        {
            return multiplyMsTestValue1 * multiplyMsTestValue2;
        }
        public double DivideMsTest(double divideMsTestValue1, double divideMsTestValue2)
        {
            return divideMsTestValue1 / divideMsTestValue2;

        }
    }
}