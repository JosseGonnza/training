using FluentAssertions;
using UserRegistrationNovember.ValueObjects;

namespace UserRegistration.Unit.Tests;

public class PasswordTest
{
    [Fact(DisplayName = "Should be valid password")]
    public void Should_be_valid_password()
    {
        var password = "1234567_";

        var result = Password.Create(password);

        result.Value.Should().Be(password);
    }
    
    [Fact(DisplayName = "Should throw exception when no contains at least 8 characters")]
    public void should_throw_exception_when_no_contains_at_least_8_characters()
    {
        var password = "12345_";

        var result = () => Password.Create(password);

        result.Should().Throw<ArgumentException>().WithMessage("Password must be at least 8 characters long");
    }
    
    [Fact(DisplayName = "Should throw exception when no contains one underscore character")]
    public void should_throw_exception_when_no_contains_one_underscore_character()
    {
        var password = "12345678";
    
        var result = () => Password.Create(password);

        result.Should().Throw<ArgumentException>().WithMessage("Password must contain underscore character");
    }
}