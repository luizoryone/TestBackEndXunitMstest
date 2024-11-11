namespace CalculadoraXunit;
public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        // Arrange
        double fNumAdd = 10;
        double sNumAdd = 20;
        double resultFplusS;
        Operacoes opAdd = new Operacoes();

        // Act
        resultFplusS = opAdd.TestAdd(fNumAdd, sNumAdd);

        // Assert - Verifica se o resultado previsto é igual ao resultado obtido
        Assert.Equal(30, resultFplusS);
    }
    [Fact]
    public void TestMultiply()
    {
        // Arrange
        double fNumAdd = 10;
        double sNumAdd = 20;
        double resultFplusS;
        Operacoes opMultiply = new Operacoes();

        // Act
        resultFplusS = opMultiply.TestMultiply(fNumAdd, sNumAdd);

        // Assert - Verifica se o resultado previsto é igual ao resultado obtido
        Assert.Equal(200, resultFplusS);
    }
}


// Luiz Oryone - luiz.o.lira@aluno.senai.br