namespace BankSolution.Core;

public class Person
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime DateOfBirth { get; init; }

    public string FullName => $"{LastName} {FirstName}";

    public Person()
    {
    }

    public Person(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }

    public override string ToString()
    {
        return $"{FullName}, {DateOfBirth:d}";
    }
}