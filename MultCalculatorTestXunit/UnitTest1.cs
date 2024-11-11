namespace MultCalculatorTestXunit;

public class UnitTest1
{
    // Arrange
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 7, 9)]
    [InlineData(9, 11, 20)]

    public void testMultAdd(double addValue1, double addValue2, double expectedResult)
    {
        MultOperacoes opAdd = new MultOperacoes();

        // Act 
        var AddResult = opAdd.MultAdd(addValue1, addValue2);

        // Assert
        Assert.Equal(expectedResult, AddResult);
    }

    //Arrange
    [Theory]
    [InlineData(6, 4, 24)]
    [InlineData(8, 5, 40)]
    [InlineData(8, 7, 56)]
    public void testMultMultiply(double timesValue1, double timesValue2, double expectedResult)
    {
        MultOperacoes opMultiply = new MultOperacoes();
        var TimesResult = opMultiply.MultMultiply(timesValue1, timesValue2);
        Assert.Equal(expectedResult, TimesResult);
    }

    // Arrange
    [Theory]
    [InlineData(13, 6, 7)]
    [InlineData(33, 6, 27)]
    [InlineData(53, 13, 40)]
    public void testMultSubtract(double subtractValue1, double subtractValue2, double expectedResult)
    {

        MultOperacoes opSubtract = new MultOperacoes();
        var SubtractResult = opSubtract.MultSubtract(subtractValue1, subtractValue2);
        Assert.Equal(expectedResult, SubtractResult);
    }

    //Arrange
    [Theory]
    [InlineData(25, 5, 5)]
    [InlineData(60, 3, 20)]
    [InlineData(50, 5, 10)]

    public void testMultDivide(double divideValue1, double divideValue2, double expectedResult)
    {
        MultOperacoes opDivide = new MultOperacoes();
        var DivideResult = opDivide.MultDivision(divideValue1, divideValue2);
        Assert.Equal(expectedResult, DivideResult);
    }

}