using FluentAssertions;

namespace RoadmapGPT.Tests;

public class ReverseNumber
{
    [Theory(DisplayName = "should be the same number when contains only one digit")]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    public void should_be_the_same_number_when_contains_only_one_digit(int number, int expected)
    {
        InvertNumber(number).Should().Be(expected);
    }

    [Fact(DisplayName = "should invert the number when contains several digits")]
    public void should_invert_the_number_when_contains_several_digits()
    {
        var number = 1234;

        var result = InvertNumber(number);

        result.Should().Be(4321);
    }

    private int InvertNumber(int number)
    {
        var reverse = 0;
        while (number > 0)
        {
            var digit = number % 10;
            reverse = reverse * 10 + digit;
            number /= 10;
        }

        return reverse;
    }
}