using System.IO;

namespace ME.Sdk.Library.Common.Model
{
    public class MultiPartUpload
    {
        public Stream Stream { get; set; }
        public string FileName { get; set; }
        public string Name { get; set; }

        public MultiPartUpload(Stream stream, string fileName, string name = "File")
        {
            Stream = stream;
            FileName = fileName;
            Name = name;
        }
    }
}
