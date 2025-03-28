namespace ME.Sdk.Library.Common.Exceptions
    {
    public class MEApiClientException : Exception
    {
#if NET6_0_OR_GREATER
    public MEApiClientException(string? message) : base(message)
        {
    }
#else
    public MEApiClientException(string message) : base(message)
        {
    }
#endif
}
}
