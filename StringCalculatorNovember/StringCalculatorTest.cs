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
        StringCalculator.Add("1,2,3,4,5,6,7,8,9").Should().Be(45);
    }
    
    [Fact(DisplayName = "Should be the sum of numbers into the text those be split by comma and new line character")]
    public void Should_be_the_sum_of_numbers_into_the_text_those_be_split_by_comma_and_new_line_character()
    {
        StringCalculator.Add("1\n2,3").Should().Be(6);
    }
    
    [Fact(DisplayName = "Should be the sum of numbers into the text those be split by comma or another separator character")]
    public void Should_be_the_sum_of_numbers_into_the_text_those_be_split_by_comma_or_another_separator_character()
    {
        StringCalculator.Add("//;\n1;2").Should().Be(3);
    }
}

public class StringCalculator
{
    private static char separator = ',';

    public static int Add(string text)
    {
        if (text.Length == 0)
        {
            return 0;
        }
        if (text.StartsWith("//"))
        {
            separator = text.ToCharArray()[2];
            text = text.Substring(4);
        }
        text = text.Replace('\n', separator);
        if (text.Contains(separator))
        {
            return text //"1,2"
                .Split(separator).ToList() //["1", "2"]
                .Aggregate(0, (current, next) => current + Convert.ToInt32(next)); //3 
        }
        return Convert.ToInt32(text);
    }
}