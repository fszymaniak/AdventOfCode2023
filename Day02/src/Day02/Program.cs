using Day02;

// Part 1
var inputPath = Path.Combine(Directory.GetCurrentDirectory(), "Input\\Games.txt");
var regexesList = RegexProvider.GetRegexes();

IList<string> rawGames = File.ReadLines(inputPath).ToList();
int sum = rawGames.SumValidGames(regexesList);
Console.WriteLine($"Number of possible games to play: {sum}");

// Part 2
int sumMultiplicationOfFewestCubes = rawGames.SumMultiplicationOfFewestCubesInEachSetValidGames(regexesList);
Console.WriteLine($"The power of a set of cubes: {sumMultiplicationOfFewestCubes}");