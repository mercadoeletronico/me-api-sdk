namespace ME.Sdk.Library.Common.Model
{

#if NET6_0_OR_GREATER
public record MultiPartUpload(Stream Stream, string FileName, string Name = "File");
#else
public class MultiPartUpload
{
    public Stream Stream { get; }
    public string FileName { get; }
    public string Name { get; }

    public MultiPartUpload(Stream stream, string fileName, string name = "File")
    {
        Stream = stream;
        FileName = fileName;
        Name = name;
    }
}
#endif
}
