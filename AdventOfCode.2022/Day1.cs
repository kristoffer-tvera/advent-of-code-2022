namespace AdventOfCode._2022;
public class Day1
{
    public static string Part1(string input)
    {
        var elfs = input.Split("\n\n");

        var highscore = 0;

        foreach (var elf in elfs)
        {
            var calorieLines = elf.Trim().Split("\n").Select(Int32.Parse);
            var sum = calorieLines.Sum();
            if (sum > highscore)
            {
                highscore = sum;
            }
        }


        return highscore.ToString();
    }

    public static string Part2(string input)
    {
        var elfs = input.Split("\n\n");

        var highscores = new List<int>();

        foreach (var elf in elfs)
        {
            var calorieLines = elf.Trim().Split("\n").Select(Int32.Parse);
            var sum = calorieLines.Sum();

            highscores.Add(sum);
        }

        var topThree = highscores.OrderDescending().Take(3).Sum();

        return topThree.ToString();
    }
}
