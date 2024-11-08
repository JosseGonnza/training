using FluentAssertions;

namespace CodeWars1;

public class SquareDigitsTest
{
    [Fact(DisplayName = "To square every digit of a number")]
    public void to_square_every_digit_of_a_number()
    {
        var number = 1;

        SquareDigits(number).Should().Be(1);
    }

    public static int SquareDigits(int number)
    {
        return 1;
    }
}