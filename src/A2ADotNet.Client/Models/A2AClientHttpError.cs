namespace A2ADotNet.Client;

public class A2AClientHttpError : Exception
{
    public int StatusCode { get; }

    public A2AClientHttpError(int statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
    }
}
