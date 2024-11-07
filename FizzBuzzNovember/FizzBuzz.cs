using FluentAssertions;
using Xunit;

namespace FizzBuzzNovember;

public class FizzBuzzTests
{
    private readonly FizzBuzz fizzBuzz;

    public FizzBuzzTests()
    {
        fizzBuzz = new FizzBuzz();
    }
    
    [Fact(DisplayName = "FizzBuzz should return 1 to 1")]
    public void FizzBuzz_should_return_1_to_1()
    {
        var result = fizzBuzz.Execute(1);

        result.Should().Be("1");
    }

    [Fact(DisplayName = "FizzBuzz should return Fizz when number is 3")]
    public void FizzBuzz_should_be_Fizz_when_number_is_3()
    {
        var result = fizzBuzz.Execute(3);

        result.Should().Be("Fizz");
    }

    [Xunit.Theory(DisplayName = "FizzBuzz should return Fizz when number is multiple of 3")]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    [InlineData(9, "Fizz")]
    [InlineData(12, "Fizz")]
    public void FizzBuzz_should_be_return_Fizz_when_number_is_multiple_of_3(int number, string expected)
    {
        var result = fizzBuzz.Execute(number);

        result.Should().Be(expected);
    }
    
    [Xunit.Theory(DisplayName = "FizzBuzz should return Buzz when number is multiple of 5")]
    [InlineData(5, "Buzz")]
    [InlineData(10, "Buzz")]
    [InlineData(20, "Buzz")]
    [InlineData(25, "Buzz")]
    public void FizzBuzz_should_be_return_Buzz_when_number_is_multiple_of_5(int number, string expected)
    {
        var result = fizzBuzz.Execute(number);

        result.Should().Be(expected);
    }
    
    [Xunit.Theory(DisplayName = "FizzBuzz should return FizzBuzz when number is multiple of 3 and 5")]
    [InlineData(15, "FizzBuzz")]
    [InlineData(30, "FizzBuzz")]
    [InlineData(45, "FizzBuzz")]
    [InlineData(60, "FizzBuzz")]
    public void FizzBuzz_should_be_return_FizzBuzz_when_number_is_multiple_of_3_and_5(int number, string expected)
    {
        var result = fizzBuzz.Execute(number);

        result.Should().Be(expected);
    }

}

public class FizzBuzz
{
    public string Execute(int number)
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