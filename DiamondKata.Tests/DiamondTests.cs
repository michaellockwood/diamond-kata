using System.Text;

namespace DiamondKata.Tests;

public class DiamondTests
{
    [Fact]
    public void Generate_A_ReturnsA()
    {
        const string expected = "A\n";
        var actual = Diamond.Generate('A');
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Generate_B_ReturnsABWithCorrectSpacing()
    {
        var expectedBuilder = new StringBuilder();
        expectedBuilder.AppendLine("-A-");
        expectedBuilder.AppendLine("B-B");
        expectedBuilder.AppendLine("-A-");
        var actual = Diamond.Generate('B');
        Assert.Equal(expectedBuilder.ToString(), actual);
    }
    
    [Fact]
    public void Generate_D_ReturnsABWithCorrectSpacing()
    {
        var expectedBuilder = new StringBuilder();
        expectedBuilder.AppendLine("---A---");
        expectedBuilder.AppendLine("--B-B--");
        expectedBuilder.AppendLine("-C---C-");
        expectedBuilder.AppendLine("D-----D");
        expectedBuilder.AppendLine("-C---C-");
        expectedBuilder.AppendLine("--B-B--");
        expectedBuilder.AppendLine("---A---");
        var actual = Diamond.Generate('D');
        Assert.Equal(expectedBuilder.ToString(), actual);
    }
    
    [Fact]
    public void Generate_NonAlphaCharacter_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Diamond.Generate('1'));
    }
    
    [Fact]
    public void Generate_LowercaseC_ReturnsABCWithCorrectSpacing()
    {
        var expectedBuilder = new StringBuilder();
        expectedBuilder.AppendLine("--A--");
        expectedBuilder.AppendLine("-B-B-");
        expectedBuilder.AppendLine("C---C");
        expectedBuilder.AppendLine("-B-B-");
        expectedBuilder.AppendLine("--A--");
        var actual = Diamond.Generate('c');
        Assert.Equal(expectedBuilder.ToString(), actual);
    }
}