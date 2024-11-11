namespace CalculatorMsTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void MsTestAdd()
    {
        // Arrange
        double fNumAdd = 37;
        double sNumAdd = 13;
        double resultFplusS;
        Operacoes opAdd = new Operacoes();

        // Act
        resultFplusS = opAdd.MsTestAdd(fNumAdd, sNumAdd);

        // Assert - Verifica se o resultado previsto é igual ao resultado obtido
        Assert.AreEqual(50, resultFplusS);
    }

    [TestMethod]
    public void MsTestMultiply()
    {
        // Arrange
        double fNumAdd = 12;
        double sNumAdd = 12;
        double resultFplusS;
        Operacoes opMultiply = new Operacoes();

        // Act
        resultFplusS = opMultiply.MsTestMultiply(fNumAdd, sNumAdd);

        // Assert - Verifica se o resultado previsto é igual ao resultado obtido
        Assert.AreEqual(144, resultFplusS);
    }
}