public class Person
{
public int ID { get; set; }
public string FirstName { get; set; } = string.Empty;
public string LastName { get; set; } = string.Empty;
public int Age { get; set; }

public float Grade { get; set; }

public DateOnly DateOfBirth { get; set; }   

public string Nationality { get; set; } = string.Empty;
}
