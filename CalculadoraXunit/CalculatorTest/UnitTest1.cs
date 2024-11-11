namespace CalculatorMsTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void MsTestAdd()
    {
        // Arrange
        double fNumAdd = 10;
        double sNumAdd = 20;
        double resultFplusS;
        Operacoes opAdd = new Operacoes();

        // Act
        resultFplusS = opAdd.MsTestAdd(fNumAdd, sNumAdd);

        // Assert - Verifica se o resultado previsto é igual ao resultado obtido
        Assert.Equal(30, resultFplusS);
    }

    [TestMethod]
    public void MsTestMultiply()
    {
        // Arrange
        double fNumAdd = 10;
        double sNumAdd = 20;
        double resultFplusS;
        Operacoes opMultiply = new Operacoes();

        // Act
        resultFplusS = opMultiply.MsTestMultiply(fNumAdd, sNumAdd);

        // Assert - Verifica se o resultado previsto é igual ao resultado obtido
        Assert.Equal(200, resultFplusS);
    }
}