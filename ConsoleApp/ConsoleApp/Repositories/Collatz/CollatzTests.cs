using Moq;
using NUnit.Framework;

namespace ConsoleApp.Repositories.Collatz;

[TestFixture]
public class CollatzTests
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

    private readonly List<string> _outLines = new();
    private Mock<TextWriter>? _consoleWriteMock;

    private static Collatz CreateCollatz()
    {
        return new Collatz();
    }

    [Test]
    public void Should_LogTheBigNumber_WithBiggestSequence()
    {
        // Arrange
        var collatz = CreateCollatz();

        // Act
        collatz.Execute();

        Assert.AreEqual("Biggest sequence of 1 million is 77031 with 350 steps", _outLines[0]);
    }
}