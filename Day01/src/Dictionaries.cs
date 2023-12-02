namespace Day01;

public static class Dictionaries
{
    public static readonly Dictionary<string, string> DigitNames = new ()
    {
        { "one", "1" },
        { "two", "2" },
        { "three", "3" },
        { "four", "4" },
        { "five", "5" },
        { "six", "6" },
        { "seven", "7" },
        { "eight", "8" },
        { "nine", "9" },
    };

// found some hints on subreddit: https://www.reddit.com/r/adventofcode/
    public static readonly Dictionary<string, string> DigitNamesEdgeCases = new ()
    {
        { "oneight", "18"},
        { "twone", "21"},
        { "eightwo", "82"},
    };
}