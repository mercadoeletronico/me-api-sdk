namespace ME.Sdk.Library.Common.Model;

public record MultiPartUpload(Stream Stream, string FileName, string Name = "File");