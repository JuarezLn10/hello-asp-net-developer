namespace Acme.Hello.Platform.Generic.Interfaces.REST.Resources;

/// <summary>
/// This is a response to greet a developer.
/// Contains the developer's ID, full name, and a message.
/// It is used as output for the greeting request.
/// </summary>
/// <param name="Id">The unique identifier of the developer. Can be null.</param>
/// <param name="FullName">The full name of the developer. Can be null.</param>
/// <param name="Message">The greeting message. This is a required field.</param>
public record GreetDeveloperResponse(Guid? Id, string? FullName, string Message)
{
    /// <summary>
    /// This constructor is used to create a GreetDeveloperResponse with only the message.
    /// </summary>
    /// <param name="Message">The greeting message. This is a required field.</param>
    public GreetDeveloperResponse(string Message) : this(null, null, Message)
    { }
}