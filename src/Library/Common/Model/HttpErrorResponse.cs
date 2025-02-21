namespace ME.Sdk.Library.Common.Model
{
    public class HttpErrorResponse
    {
        public string Title { get; set; }
        public string? Detail { get; set; }

        public HttpErrorResponse(string title, string? detail)
        {
            Title = title;
            Detail = detail;
        }
    }
}
