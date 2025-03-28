using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
namespace ME.Sdk.Library
    {
    public class MEApiSettings
    {
#if NET6_0_OR_GREATER
    public string? BaseAddress { get; set; }
    public string? ClientId { get; set; }
    public string? ClientSecret { get; set; }
#else
    public string BaseAddress { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
#endif
    public int Retries { get; set; } = 5;
    public int TimeoutInSeconds { get; set; } = 60;
    public int SleepDurationInSeconds { get; set; } = 1;
}
}
