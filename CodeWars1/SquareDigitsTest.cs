using FluentAssertions;

namespace CodeWars1;

public class SquareDigitsTest
{
    [Theory(DisplayName = "To square one digit")]
    [InlineData(1, 1)]
    [InlineData(2, 4)]
    [InlineData(3, 9)]
    public void to_square_one_digit(int number, int expected)
    {
        SquareDigits(number).Should().Be(expected);
    }

    [Fact(DisplayName = "To square every digit of a number")]
    public void to_square_every_digit_of_a_number()
    {
        int number = 11;
        SquareDigits(number).Should().Be(11);
    }

    public static int SquareDigits(int number)
    {
        var numbers = number.ToString().ToCharArray();
        
        for (int i = 0; i < numbers.Length; i++)
        {
            var square = numbers[i] *= numbers[i];
                        
        }
        var result = number *= number;
        return result;
    }
}