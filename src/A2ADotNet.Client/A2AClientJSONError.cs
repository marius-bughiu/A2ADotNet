namespace A2ADotNet.Client;

public class A2AClientJSONError : A2AClientError
{
    public A2AClientJSONError(string message) 
        : base($"JSON Error: {message}")
    {
    }

    public A2AClientJSONError(string message, Exception innerException)
        : base($"JSON Error: {message}", innerException)
    {
    }
}
