using Moq;
using NUnit.Framework;

namespace ConsoleApp.Repositories.OnlyOdd;

[TestFixture]
public class OnlyOddTests
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


    private OnlyOdd CreateOnlyOdd()
    {
        return new OnlyOdd();
    }

    [Test(Description = "Should write odd numbers", TestOf = typeof(OnlyOdd))]
    public void Should_ReturnOddsNumber()
    {
        // Arrange
        var onlyOdd = CreateOnlyOdd();
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        onlyOdd.Execute(numbers);

        // Assert
        Assert.AreEqual("The odd numbers in the list are: 1, 3, 5, 7, 9", _outLines[0]);
    }

    [Test(Description = "Should write odd numbers", TestOf = typeof(OnlyOdd))]
    public void Should_NotReturn_CaseNoHaveOdds()
    {
        // Arrange
        var onlyOdd = CreateOnlyOdd();
        List<int> numbers = new() { 2, 4, 6, 8, 10 };

        // Act
        onlyOdd.Execute(numbers);

        // Assert
        Assert.AreEqual("There are no odd numbers in the list.", _outLines[0]);
    }
}