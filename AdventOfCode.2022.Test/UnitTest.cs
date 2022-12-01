using System.Reflection;
using Xunit.Abstractions;

namespace AdventOfCode._2022.Test;

public class UnitTest
{
    private readonly ITestOutputHelper _output;
    public UnitTest(ITestOutputHelper output)
    {
        _output = output;
    }

    private string GetFilePath(string filePath)
    {
        string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, filePath);
        return path;
    }

    [Fact]
    public async Task Day1_part1()
    {
        // Arrange
        var input = await System.IO.File.ReadAllTextAsync(GetFilePath(@"..\..\..\input\day1.txt"));

        // Act
        var solution = AdventOfCode._2022.Day1.Part1(input);

        // Assert
        Assert.Null(solution);
    }

    [Fact]
    public async Task Day1_part2()
    {
        // Arrange
        var input = await System.IO.File.ReadAllTextAsync(GetFilePath(@"..\..\..\input\day1.txt"));

        // Act
        var solution = AdventOfCode._2022.Day1.Part2(input);

        // Assert
        Assert.Null(solution);
    }
}