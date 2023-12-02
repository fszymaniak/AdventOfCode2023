using Day01;

// Part 1
var inputPath = Path.Combine(Directory.GetCurrentDirectory(), "Input\\RawCalibrationValues.txt");

IList<string> rawCalibrationValues = File.ReadLines(inputPath).ToList();

var filteredCalibrationValues = rawCalibrationValues.Select(x => String.Join("", x.AsEnumerable().Where(char.IsDigit)));

var firstAndLastCalibrationDigits = filteredCalibrationValues.Select(x => x.FilterCalibrationDigits());

var sumOfFilteredCalibrationValues = firstAndLastCalibrationDigits.Sum();

Console.WriteLine($"Sum of the filtered calibration values: {sumOfFilteredCalibrationValues}");

// Part 2
var filteredCalibrationValuesWithDigitStringNames = rawCalibrationValues.Select(x => x.SwitchDigitName());

var firstAndLastCalibrationDigitsWithDigitStringNames = filteredCalibrationValuesWithDigitStringNames.Select(x => x.FilterCalibrationDigits());

var sumOfFilteredCalibrationValuesWithDigitStringNames = firstAndLastCalibrationDigitsWithDigitStringNames.Sum();

Console.WriteLine($"Sum of the filtered calibration values including digit string names: {sumOfFilteredCalibrationValuesWithDigitStringNames}");
