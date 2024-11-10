using FluentAssertions;

namespace RoadmapGPT.Tests;

public class VerifyPrimeNumbers
{
    [Theory(DisplayName = "should be not prime when is 1 or less")]
    [InlineData(1, false)]
    [InlineData(0, false)]
    public void should_be_not_prime_when_is_1_or_less(int number, bool expected)
    {
        IsPrime(number).Should().BeFalse();
    }

    [Theory(DisplayName = "should be prime when is correct number")]
    [InlineData(2)]
    [InlineData(7)]
    [InlineData(43)]
    public void should_be_prime_when_is_correct_number(int number)
    {
        IsPrime(number).Should().BeTrue();
    }
    
    [Theory(DisplayName = "should be not prime when is incorrect number")]
    [InlineData(4)]
    [InlineData(12)]
    [InlineData(33)]
    public void should_be_not_prime_when_is_incorrect_number(int number)
    {
        IsPrime(number).Should().BeFalse();
    }

    private bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}