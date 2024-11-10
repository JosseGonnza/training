using FluentAssertions;

namespace RoadmapGPT.Tests;

public class ConvertStringToTitle
{
    [Theory(DisplayName = "should be to upper case the first letter of word")]
    [InlineData("viento", "Viento")]
    [InlineData("", "")]
    [InlineData("Hola", "Hola")]
    [InlineData("lo que el viento se llevo", "Lo Que El Viento Se Llevo")]
    [InlineData("a la luz de la luna", "A La Luz De La Luna")]
    public void should_be_to_upper_case_the_first_letter_of_word(string input, string expected)
    {
        ConvertString(input).Should().Be(expected);
    }

    private string ConvertString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        var words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }
        }
        return string.Join(" ", words);
    }
}