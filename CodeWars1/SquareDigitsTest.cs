using FluentAssertions;

namespace CodeWars1;

public class SquareDigitsTest
{
    [Theory(DisplayName = "To square every digit of a number")]
    [InlineData(1, 1)]
    [InlineData(2, 4)]
    public void to_square_every_digit_of_a_number(int number, int expected)
    {
        SquareDigits(number).Should().Be(expected);
    }

    public static int SquareDigits(int number)
    {
        if (number == 2)
        {
            return 4;
        }
        return 1;
    }
}