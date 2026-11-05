using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddUserSecrets<Program>(optional: true, reloadOnChange: true);

var appsettings = builder.Configuration.GetSection("AppSettings").Get<AppSettings>();

Console.WriteLine($"Environment: {appsettings?.EnvironmentName}");
Console.WriteLine($"Greeting: {appsettings?.Greeting}");
Console.WriteLine($"Password: {appsettings?.Password}");

public sealed class AppSettings
{
public string EnvironmentName { get; set; } = string.Empty;
public string Greeting { get; set; } = string.Empty;
public string Password { get; set; } = string.Empty;
}

