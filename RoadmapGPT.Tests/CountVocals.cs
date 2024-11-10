using FluentAssertions;

namespace RoadmapGPT.Tests;

public class CountVocals
{
    [Theory(DisplayName = "should be 0 when text is empty or not contains vocals")]
    [InlineData("", 0)]
    [InlineData("fgh", 0)]
    public void should_be_0_when_text_is_empty_or_not_contains_vocals(string text, int expected)
    {
        CalculateNumberOfVocals(text).Should().Be(expected);
    }

    [Fact(DisplayName = "should be the correct count of vocals for that word")]
    public void should_be_the_correct_count_of_vocals_for_that_word()
    {
        var text = "Hola Mundo!";

        var result = CalculateNumberOfVocals(text);

        result.Should().Be(4);
    }

    public int CalculateNumberOfVocals(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }
        var vocals = "aeiouAEIOU";
        var count = 0;
        foreach (var c in text)
        {
            if (vocals.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}