using UserRegistrationNovember.Controllers;
using FluentAssertions;

namespace UserRegistration.Unit.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var password = "12345678";

        var result = Password.Create(password);
        
        result.value.Should().Be(password);
    }
}