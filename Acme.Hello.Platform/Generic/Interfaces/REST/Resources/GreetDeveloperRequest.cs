namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// This is a request to greet a developer.
/// Contains the first and last name of the developer, used as input for the greeting request.
/// </summary>
/// <param name="FirstName">The first name of the developer. Can be null.</param>
/// <param name="LastName">The last name of the developer. Can be null.</param>
public record GreetDeveloperRequest(string? FirstName, string? LastName);