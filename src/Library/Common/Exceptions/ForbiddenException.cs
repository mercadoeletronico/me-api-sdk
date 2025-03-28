namespace ME.Sdk.Library.Common.Exceptions
    {
    public class ForbiddenException : MEApiClientException
        {
#if NET6_0_OR_GREATER
    public ForbiddenException(string? message) : base(message)
#else
    public ForbiddenException(string message) : base(message)
#endif
        {
    }
}
}
