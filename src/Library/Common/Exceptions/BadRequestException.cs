namespace ME.Sdk.Library.Common.Exceptions;

public class BadRequestException : MEApiClientException
{
    public BadRequestException(string? message) : base(message)
    {
    }
}