namespace Day01.Unit.Tests;

public class SwitchDigitNameTests
{
    [Theory]
    [InlineData("18cfour", "184")]
    [InlineData("xjtctnllkp57seven2jgbjmjbxnpfgone", "57721")]
    [InlineData("eight5gmbzbqtxrr27dtgfdbmtc7", "85277")]
    [InlineData("twoggvcnfmtrseven4dx", "274")]
    [InlineData("ssevenhcltwoseven2cxrmxxcr", "7272")]
    public void SwitchDigitName_Should_OnlyStringDigits(string input, string expectedOutput)
    {
        // Arrange 
        string calibrationWithOneDigit = input;

        // Act
        string result = calibrationWithOneDigit.SwitchDigitName();

        // Assert
        result.ShouldBe(expectedOutput);
    }
    
    [Theory]
    [InlineData("18cfouroneight", "18418")]
    [InlineData("xjtctnllkp57seven2jgbjmjbxnpfgonetwonetwone", "577212121")]
    [InlineData("eight5gmbzbqeightwotxrr27dtgfdbmtc7", "8582277")]
    public void SwitchDigitNameWithEdgeCases_Should_OnlyStringDigits(string input, string expectedOutput)
    {
        // Arrange 
        string calibrationWithOneDigit = input;

        // Act
        string result = calibrationWithOneDigit.SwitchDigitName();

        // Assert
        result.ShouldBe(expectedOutput);
    }
}