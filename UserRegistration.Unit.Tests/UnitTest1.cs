using FluentAssertions;
using UserRegistrationNovember.Controllers;
using UserRegistrationNovember.Models;
using UserRegistrationNovember.Repositories;
using UserRegistrationNovember.ValueObjects;

namespace UserRegistration.Unit.Tests;

public class UnitTest1
{
    [Fact(DisplayName = "Password should be more long than 8 characters")]
    public void Password_should_be_more_long_than_8_characters()
    {
        var password = "12345678";

        var result = Password.Create(password);

        result.Value.Should().Be(password);
    }

    [Fact(DisplayName = "List should be increment in one when save one user")]
    public void List_should_be_increment_in_one_when_save_one_user()
    {
        var user = new User("test", Password.Create("12345678"));
        var repository = new UserRepository();
        repository.Save(user);

        var result = repository.users;
        
        result.Count.Should().Be(1);
    }
}