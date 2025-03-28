namespace ME.Sdk.Library.Common.Exceptions
    {
    public class UnauthorizedException : MEApiClientException
        {
#if NET6_0_OR_GREATER
    public UnauthorizedException(string? message) : base(message)
        {
    }
#else
    public UnauthorizedException(string message) : base(message)
        {
    }
#endif
}
}
