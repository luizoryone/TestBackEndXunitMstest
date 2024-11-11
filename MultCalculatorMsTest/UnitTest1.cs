namespace MultCalculatorMsTest;

[TestClass]
public class UnitTest1
{
    // Arrang
    [DataTestMethod]
    [DataRow(70, 15, 85)]
    [DataRow(70, 25, 95)]
    [DataRow(40, 50, 90)]

    public void MultAddMsTest(double msTestAddValue1, double msTestAddValue2, double expectValue)
    {
        OperacoesMsTest MsTestOpAdd = new OperacoesMsTest();

        //Act
        var addResult = MsTestOpAdd.AddMsTest(msTestAddValue1, msTestAddValue2);
        //Assert
        Assert.AreEqual(expectValue, addResult);
    }
    // Arrang
    [DataTestMethod]
    [DataRow(70, 15, 55)]
    [DataRow(70, 25, 45)]
    [DataRow(90, 10, 80)]
    public void MultSubtractTest(double msTestDivideValue1, double msTestDivideValue2, double expectValue)
    {
        OperacoesMsTest MsTestOpSubtract = new OperacoesMsTest();
        var subtractResult = MsTestOpSubtract.SubtractMsTest(msTestDivideValue1, msTestDivideValue2);
        Assert.AreEqual(expectValue, subtractResult);
    }


    // Arrang
    [DataTestMethod]
    [DataRow(90, 15, 6)]
    [DataRow(120, 10, 12)]
    [DataRow(300, 5, 60)]
    public void MultDivideTest(double msTestDivideValue1, double msTestDivideValue2, double expectValue)
    {
        OperacoesMsTest MsTestOpDivide = new OperacoesMsTest();
        var divideResult = MsTestOpDivide.DivideMsTest(msTestDivideValue1, msTestDivideValue2);
        Assert.AreEqual(expectValue, divideResult);
    }

    // Arrang
    [DataTestMethod]
    [DataRow(70, 5, 350)]
    [DataRow(45, 4, 180)]
    [DataRow(30, 7, 210)]
    public void MultMultiplyTest(double msTestMultiplyValue1, double msTestMultiplyValue2, double expectValue)
    {
        OperacoesMsTest MsTestMultiply = new OperacoesMsTest();
        var multiplyResult = MsTestMultiply.MultiplyMsTest(msTestMultiplyValue1, msTestMultiplyValue2);
        Assert.AreEqual(expectValue, multiplyResult);
    }
}
