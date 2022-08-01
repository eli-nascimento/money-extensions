namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtesionTests
{
    [TestMethod]
    public void SholdConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();

        Assert.AreEqual(27998,cents);
    }
}