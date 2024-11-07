using FluentAssertions;

namespace FizzBuzzNovember;

public class FizzBuzzTests
{
    [Fact(DisplayName = "Should be 1 to 1")]
    public void Should_be_1_to_1()
    {
        FizzBuzz.Execute(1).Should().Be("1");
    }

    [Fact(DisplayName = "Should be Fizz when number is 3")]
    public void Should_be_Fizz_when_number_is_3()
    {
        FizzBuzz.Execute(3).Should().Be("Fizz");
    }

    [Theory(DisplayName = "Should be Fizz when number is multiple of 3")]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    [InlineData(9, "Fizz")]
    [InlineData(12, "Fizz")]
    public void Should_be_Fizz_when_number_is_multiple_of_3(int number, string expected)
    {
        FizzBuzz.Execute(number).Should().Be(expected);
    }
    
    [Theory(DisplayName = "Should be Buzz when number is multiple of 5")]
    [InlineData(5, "Buzz")]
    [InlineData(10, "Buzz")]
    [InlineData(20, "Buzz")]
    [InlineData(25, "Buzz")]
    public void Should_be_Buzz_when_number_is_multiple_of_5(int number, string expected)
    {
        FizzBuzz.Execute(number).Should().Be(expected);
    }
    
    [Theory(DisplayName = "Should be FizzBuzz when number is multiple of 3 and 5")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(30, "FizzBuzz")]
    [InlineData(45, "FizzBuzz")]
    [InlineData(60, "FizzBuzz")]
    public void Should_be_FizzBuzz_when_number_is_multiple_of_3_and_5(int number, string expected)
    {
        FizzBuzz.Execute(number).Should().Be(expected);
    }
}

public class FizzBuzz
{
    public static string Execute(int number)
    {
        if (number % 15 == 0)
        {
            return "FizzBuzz"; 
        }
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        return number.ToString();
    }
}