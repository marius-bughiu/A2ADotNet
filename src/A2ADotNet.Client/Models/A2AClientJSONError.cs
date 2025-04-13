namespace A2ADotNet.Client;

public class A2AClientJSONError(string message, Exception? inner = null) : Exception(message, inner)
{
}
