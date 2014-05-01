using System;

namespace Findsi.Client
{
    public class FindsiClientSettings : IFindsiClientSettings
    {
        public Uri BaseAddress { get; set; }
        public string Key { get; set; }
        public long MaxResponseContentBufferSize { get; set; }
        public TimeSpan Timeout { get; set; }
    }
}