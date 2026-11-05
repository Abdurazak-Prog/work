using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddUserSecrets<Program>(optional: true, reloadOnChange: true);

var appsettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>();

Console.WriteLine($"Environment: {appsettings?.EnvironmentName}");
Console.WriteLine($"Greeting: {appsettings?.Greeting}");
Console.WriteLine($"Password: {appsettings?.Password}");

Person person1 = new Person();

person1.ID = 1;
person1.FirstName = "Ahmad";
person1.LastName = "Ali";
person1.Age = 22;
person1.DateOfBirth = DateOnly.FromDateTime(new DateTime(2000, 1, 1));
Console.WriteLine($"ID: {person1.ID}");
Console.WriteLine($"Name: {person1.FirstName} {person1.LastName}");
Console.WriteLine($"Age: {person1.Age}");
Console.WriteLine($"Date of Birth: {person1.DateOfBirth}");

public sealed class AppSettings
{
public string EnvironmentName { get; set; } = string.Empty;
public string Greeting { get; set; } = string.Empty;
public string Password { get; set; } = string.Empty;
}

