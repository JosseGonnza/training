using FluentAssertions;

namespace StringCalculatorNovember;

public class StringCalculatorTest
{
    [Fact(DisplayName = "Should be 0 when text is empty")]
    public void Should_be_0_when_text_is_empty()
    {
        var result = StringCalculator.Add("");

        result.Should().Be(0);
    }

    [Theory(DisplayName = "Should be that number into text when is only one")]
    [InlineData("1", 1)]
    [InlineData("12", 12)]
    [InlineData("41", 41)]
    [InlineData("1000", 1000)]
    public void Should_be_that_number_into_text_when_is_only_one(string text, int expected)
    {
        StringCalculator.Add(text).Should().Be(expected);
    }

    [Fact(DisplayName = "Should be the sum of numbers into the text those be split by comma")]
    public void Should_be_the_sum_of_numbers_into_the_text_those_be_split_by_comma()
    {
        StringCalculator.Add("1,2").Should().Be(3);
    }
}

public class StringCalculator
{
    public static int Add(string text)
    {
        if (text.Length == 0)
        {
            return 0;
        }
        if (text.Contains(","))
        {
            return text //"1,2"
                .Split(",").ToList() //["1", "2"]
                .Aggregate(0, (current, next) => current + Convert.ToInt32(next)); //3 
        }
        return Convert.ToInt32(text);
    }
}