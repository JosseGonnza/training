using FluentAssertions;
using UserRegistrationNovember.Models;
using UserRegistrationNovember.Repositories;
using UserRegistrationNovember.ValueObjects;

namespace UserRegistration.Unit.Tests;

public class UserTest
{
    [Fact(DisplayName = "List should be increment in one when save one user")]
    public void List_should_be_increment_in_one_when_save_one_user()
    {
        var repository = new UserRepository();
        var user = new User("test", Password.Create("1234567_"));

        repository.Save(user);

        repository.users.Count.Should().Be(1);
    }
}