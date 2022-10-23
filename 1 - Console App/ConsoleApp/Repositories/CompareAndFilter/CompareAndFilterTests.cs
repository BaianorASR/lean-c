using Moq;
using NUnit.Framework;

namespace ConsoleApp.Repositories.CompareAndFilter;

[TestFixture]
public class CompareAndFilterTests
{
    [SetUp]
    public void SetUp()
    {
        _consoleWriteMock = new Mock<TextWriter>(MockBehavior.Strict);
        _consoleWriteMock
            .Setup(x => x.WriteLine(It.IsAny<string>()))
            .Callback<string>(x => _outLines.Add(x));
        Console.SetOut(_consoleWriteMock.Object);
    }

    [TearDown]
    public void TearDown()
    {
        _outLines.Clear();
    }

    private readonly List<string> _outLines = new();
    private Mock<TextWriter>? _consoleWriteMock;


    private CompareAndFilter CreateCompareAndFilter()
    {
        return new CompareAndFilter();
    }

    [Test]
    public void Should_LogCase_ListsAreEquals()
    {
        var firstList = new List<int> { 1, 2, 3 };
        var secondList = new List<int> { 1, 2, 3 };
        var compareAndFilter = CreateCompareAndFilter();

        // Act
        compareAndFilter.Execute(firstList, secondList);

        // Assert
        Assert.AreEqual("All numbers in the first list are in the second list.", _outLines[0]);
    }

    [Test]
    public void Should_LogNotEqualNumber()
    {
        var firstList = new List<int> { 1, 2, 3 };
        var secondList = new List<int> { 1, 2, 3 };
        var compareAndFilter = CreateCompareAndFilter();

        // Act
        compareAndFilter.Execute(firstList, secondList);

        // Assert
        Assert.AreEqual("All numbers in the first list are in the second list.", _outLines[0]);
    }
}