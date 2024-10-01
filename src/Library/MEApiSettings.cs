namespace ME.Sdk.Library;

public class MEApiSettings
{
    public string BaseAddress { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public int Retries { get; set; } = 5;
    public int TimeoutInSeconds { get; set; } = 60;
    public int SleepDurationInSeconds { get; set; } = 1;
}