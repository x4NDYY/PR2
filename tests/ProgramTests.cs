using Xunit;

public class ProgramTests
{
    [Fact]
    public void ReplaceSpaces_SimpleCase()
    {
        string input = "a b a";
        string result = Program.ReplaceSpacesWithMostFrequent(input);

        Assert.Equal("aabaa", result);
    }

    [Fact]
    public void ReplaceSpaces_MultipleFrequent_FirstWins()
    {
        string input = "a b c";
        string result = Program.ReplaceSpacesWithMostFrequent(input);

        Assert.Equal("aabac", result);
    }

    [Fact]
    public void ReplaceSpaces_AllSpaces()
    {
        string input = "     ";
        string result = Program.ReplaceSpacesWithMostFrequent(input);

        Assert.Equal("В строке только пробелы.", result);
    }

    [Fact]
    public void ReplaceSpaces_NoSpaces()
    {
        string input = "abc";
        string result = Program.ReplaceSpacesWithMostFrequent(input);

        Assert.Equal("abc", result);
    }
}

