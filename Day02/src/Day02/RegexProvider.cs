using System.Text.RegularExpressions;

namespace Day02;

public static class RegexProvider
{
    public static IList<Regex> GetRegexes()
    {
        var regexForRedNumber = new Regex("([0-9]+)\\W*(red)", RegexOptions.IgnoreCase);
        var regexForGreenNumber = new Regex("([0-9]+)\\W*(green)", RegexOptions.IgnoreCase);
        var regexForBlueNumber = new Regex("([0-9]+)\\W*(blue)", RegexOptions.IgnoreCase);

        IList<Regex> regexesList = new List<Regex>() { regexForRedNumber, regexForGreenNumber, regexForBlueNumber };
        return regexesList;
    }
}