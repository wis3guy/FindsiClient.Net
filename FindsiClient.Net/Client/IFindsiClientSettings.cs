using System;

namespace Findsi.Client
{
    public interface IFindsiClientSettings
    {
        Uri BaseAddress { get; set; }
        string Key { get; set; }
        long MaxResponseContentBufferSize { get; set; }
        TimeSpan Timeout { get; set; }
    }
}