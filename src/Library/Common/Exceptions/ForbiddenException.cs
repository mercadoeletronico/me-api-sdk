namespace ME.Sdk.Library.Common.Exceptions;

public class ForbiddenException : MEApiClientException
{
    public ForbiddenException(string? message) : base(message)
    {
    }
}