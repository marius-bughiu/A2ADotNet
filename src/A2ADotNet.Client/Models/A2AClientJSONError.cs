namespace A2ADotNet.Client;

public class A2AClientJsonError : A2AClientError
{
    public A2AClientJsonError(string message) 
        : base($"JSON Error: {message}")
    {
    }

    public A2AClientJsonError(string message, Exception innerException)
        : base($"JSON Error: {message}", innerException)
    {
    }
}
