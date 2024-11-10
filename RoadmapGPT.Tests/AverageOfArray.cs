using FluentAssertions;

namespace RoadmapGPT.Tests;

public class AverageOfArray
{
    [Fact(DisplayName = "should be the same number when the arrray have only one number")]
    public void should_be_the_same_number_when_is_only_one()
    {
        int[] array = new int[]{1};

        CalculateAverage(array).Should().Be(1);
    }

    [Fact(DisplayName = "should be 0 when array is empty")]
    public void should_be_0_when_array_is_empty()
    {
        int[] array = new int[]{};

        CalculateAverage(array).Should().Be(0);
    }

    [Theory(DisplayName = "should be correct when the array has several numbers")]
    [InlineData(new []{5, 10, 15}, 10)]
    [InlineData(new []{3, -7, 5, 13, -2}, 2.4)]
    public void should_be_correct_when_the_array_has_several_positive_numbers(int[] array, double average)
    {
        CalculateAverage(array).Should().Be(average);
    }

    private double CalculateAverage(int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        var sum = 0;
        foreach (var num in array)
        {
            sum += num;
        }
        var average = (double)sum / array.Length;
        return Math.Round(average, 1);
    }
}