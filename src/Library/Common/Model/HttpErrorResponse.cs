namespace ME.Sdk.Library.Common.Model
{

#if NET6_0_OR_GREATER
    public record HttpErrorResponse(string Title, string? Detail);
#else
    public class HttpErrorResponse
{
    public string Title { get; set; }
    public string Detail { get; set; }

    public HttpErrorResponse(string title, string detail)
    {
        Title = title;
        Detail = detail;
    }
}
#endif
}
}
