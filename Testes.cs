using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraXunit
{
    public class Testes
    {
        public double TestAdd(double fNumAdd, double sNumAdd)
        {
            return fNumAdd + sNumAdd;

            // Arrange
            double fNumAdd = 10;
            double sNumAdd = 20;
            double resultFplusS;
            Operacoes opAdd = new Operacoes();

            // Act
            resultFplusS = opAdd.TestAdd(fNumAdd, sNumAdd);

            // Assert
            Assert.AreEqual(30, resultFplusS);
        }
        public double TestMultiply(double fNumAdd, double sNumAdd)
        {
            return fNumAdd + sNumAdd;

            // Arrange
            double fNumAdd = 10;
            double sNumAdd = 20;
            double resultFplusS;
            Operacoes opAdd = new Operacoes();

            // Act
            resultFplusS = opAdd.TestMultiply(fNumAdd, sNumAdd);

            // Assert
            Assert.AreEqual(30, resultFplusS);
        }

    }
}

// Luiz Oryone - luiz.o.lira@aluno.senai.br
