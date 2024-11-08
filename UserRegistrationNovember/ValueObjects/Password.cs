namespace UserRegistrationNovember.ValueObjects;

public class Password
{
    public string Value { get; }

    private Password(string value)
    {
        this.Value = value;
    }

    public static Password Create(string value)
    {
        if (value.Length < 8)
        {
            throw new ArgumentException("Password must be at least 8 characters long");
        }
        if (!value.Contains('_'))
        {
            throw new ArgumentException("Password must contain underscore character");
        }
        return new Password(value);
    }
}