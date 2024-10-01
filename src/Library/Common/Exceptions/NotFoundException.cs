namespace ME.Sdk.Library.Common.Exceptions;

public class NotFoundException : MEApiClientException
{
    public NotFoundException(string? message) : base(message)
    {
    }
}