namespace Day01.Unit.Tests;

public class FilterCalibrationDigitsTests
{
    [Theory]
    [InlineData("1", 11)]
    [InlineData("2", 22)]
    [InlineData("9", 99)]
    public void FilterCalibrationDigitsWithOneStringDigit_Should_ReturnIntValueCreatedFromTwoSignleDigits(string input, int expectedOutput)
    {
        // Arrange 
        string calibrationWithOneDigit = input;

        // Act
        int result = calibrationWithOneDigit.FilterCalibrationDigits();

        // Assert
        result.ShouldBePositive();
        result.ShouldBe(expectedOutput);
    }
    
    [Theory]
    [InlineData("44", 44)]
    [InlineData("98", 98)]
    [InlineData("85", 85)]
    public void FilterCalibrationDigitsWithTwoStringDigit_Should_ReturnIntValue(string input, int expectedOutput)
    {
        // Arrange 
        string calibrationWithOneDigit = input;

        // Act
        int result = calibrationWithOneDigit.FilterCalibrationDigits();

        // Assert
        result.ShouldBePositive();
        result.ShouldBe(expectedOutput);
    }
    
    [Theory]
    [InlineData("123456", 16)]
    [InlineData("789531", 71)]
    [InlineData("6733812132", 62)]
    public void FilterCalibrationDigitsWithMoreThenTwoStringDigit_Should_ReturnIntValueWithFirstAndLastDigit(string input, int expectedOutput)
    {
        // Arrange 
        string calibrationWithOneDigit = input;

        // Act
        int result = calibrationWithOneDigit.FilterCalibrationDigits();

        // Assert
        result.ShouldBePositive();
        result.ShouldBe(expectedOutput);
    }
}