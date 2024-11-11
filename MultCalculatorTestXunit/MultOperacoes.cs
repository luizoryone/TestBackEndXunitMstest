using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultCalculatorTestXunit
{
    public class MultOperacoes
    {
        public double MultAdd(double addValue1, double addValue2)
        {
            return addValue1 + addValue2;
        }
        public double MultMultiply(double MultMultiply1, double MultMultiply2)
        {
            return MultMultiply1 * MultMultiply2;
        }
        public double MultDivision(double divisionValue1, double divisionValue2)
        {
            return divisionValue1 / divisionValue2;
        }
        public double MultSubtract(double subtractValue1, double subtractValue2)
        {
            return subtractValue1 - subtractValue2;
        }



    }
}