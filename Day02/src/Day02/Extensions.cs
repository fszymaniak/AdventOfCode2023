using System.Text.RegularExpressions;

public static class Extensions
{
    public static int FilterAndSumGames(this string game, Regex regex)
    {
        var filteredGameWithNumberForColor = regex.Matches(game);
        var sum = filteredGameWithNumberForColor.Select(x => Int32.Parse(x.Groups[1].Value)).Sum();
        return sum;
    }

    public static int ValidateFewerNumberForSet(this int sumFromPreviousSet, int actualSum)
    {
        return actualSum >= sumFromPreviousSet ? actualSum : sumFromPreviousSet;
    }
    
    public static int SumValidGames(this IList<string> games, IList<Regex> regexesList)
    {
        int sum = 0;
    
        for(int i = 0; i < games.Count; i++)
        {
            var splitedSets = games[i].Split(";");
            int setsSum = 0;
    
            foreach (var set in splitedSets)
            {
                var redSum = set.FilterAndSumGames(regexesList[0]);
                var greenSum = set.FilterAndSumGames(regexesList[1]);
                var blueSum = set.FilterAndSumGames(regexesList[2]);
                
                if ((redSum >= 0 && redSum <= 12) && (greenSum >= 0 && greenSum <= 13) && (blueSum >= 0 && blueSum <= 14))
                {
                    setsSum++;
                }
            }
    
            if (setsSum.Equals(splitedSets.Length))
            {
                int id = i + 1;
                sum += id;
            }
        }
    
        return sum;
    }
    
    public static int SumMultiplicationOfFewestCubesInEachSetValidGames(this IList<string> games, IList<Regex> regexesList)
    {
        int sum = 0;
    
        foreach(var game in games)
        {
            var splitedSets = game.Split(";");
            int redFewestNumber = 0;
            int greenFewestNumber = 0;
            int blueFewestNumber = 0;
    
            foreach (var set in splitedSets)
            {
                var redSum = set.FilterAndSumGames(regexesList[0]);
                var greenSum = set.FilterAndSumGames(regexesList[1]);
                var blueSum = set.FilterAndSumGames(regexesList[2]);
                
                redFewestNumber = redFewestNumber.ValidateFewerNumberForSet(redSum);
                greenFewestNumber = greenFewestNumber.ValidateFewerNumberForSet(greenSum);
                blueFewestNumber = blueFewestNumber.ValidateFewerNumberForSet(blueSum);
            }
    
            sum += redFewestNumber * greenFewestNumber * blueFewestNumber;
        }
    
        return sum;
    }
}