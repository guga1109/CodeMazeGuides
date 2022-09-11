using FuncAndActionDelegatesInCsharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests;

[TestClass]
public class Tests
{
    [TestMethod]
    public void WhenFilteringAListWithExtensionMethod_ThenTheResultShouldBeTheSameAsLinqWhereMethod()
    {
        List<int> list = new List<int> {1, 2, 0, 5, 6, 99, 100, 102, 0};
        CollectionAssert.AreEqual(list.Where(x => x == 0).ToList(), list.NewWhere(x => x == 0));
        CollectionAssert.AreEqual(list.Where(x => x > 0).ToList(), list.NewWhere(x => x > 0));
    }

    [TestMethod]
    public void WhenCallMethodWithConsoleWrite_ThenPrintStringInUppercase()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        "Test".ConvertToUppercaseAndDoAction(Console.Write);
        
        Assert.AreEqual("TEST", stringWriter.ToString());
    }
}