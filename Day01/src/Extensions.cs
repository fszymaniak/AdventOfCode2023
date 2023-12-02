namespace Day01;

public static class Extensions
{
    public static int FilterCalibrationDigits(this string calibration)
    {
        string calibrationResult;
        int length = calibration.Length;
    
        if (length == 1)
        {
            calibrationResult = calibration + calibration;
        }
        else if (length == 2)
        {
            calibrationResult = calibration;
        }
        else
        {
            calibrationResult = String.Concat(calibration[0], calibration[length - 1]);
        }
    
        return int.Parse(calibrationResult);
    }


    public static string SwitchDigitName(this string rawCalibration)
    {
        var calibrationWithDigitsFixed = Dictionaries.DigitNamesEdgeCases.Aggregate(rawCalibration, (current, value) => 
            current.Replace(value.Key, value.Value));
    
        var calibrationWithDigits = Dictionaries.DigitNames.Aggregate(calibrationWithDigitsFixed, (current, value) => 
            current.Replace(value.Key, value.Value));

        var result =  String.Join("", calibrationWithDigits.AsEnumerable().Where(char.IsDigit));
        return result;
    }
}