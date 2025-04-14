namespace A2ADotNet.Client;

public class A2AClientError : Exception
{
    public A2AClientError(string message) : base(message)
    {
    }

    public A2AClientError(string message, Exception innerException) : base(message, innerException)
    {
    }
}
