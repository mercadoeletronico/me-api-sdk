namespace ME.Sdk.Library.Common.Exceptions
{
    public class BadRequestException : MEApiClientException
    {
#if NET6_0_OR_GREATER
    public BadRequestException(string? message) : base(message)
#else
    public BadRequestException(string message) : base(message)
#endif
    {
    }
}
