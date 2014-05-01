using System;
using HalClient.Net;
using HalClient.Net.Parser;

namespace Findsi.Client
{
    public class FindsiHalHttpClientFactory : HalHttpClientFactory
    {
        private readonly IFindsiClientSettings _settings;
        
        public FindsiHalHttpClientFactory(IHalJsonParser parser, IFindsiClientSettings settings) : base(parser)
        {
            if (settings == null) 
                throw new ArgumentNullException("settings");

            if (settings.BaseAddress == null) 
                throw new ArgumentException("Invalid api base address uri provided");

            if (string.IsNullOrEmpty(settings.Key))
                throw new ArgumentException("Invalid api key provided");
            
            _settings = settings;
        }

        protected override void Configure(IHalHttpClientConfiguration client)
        {
            if (_settings.Timeout != default(TimeSpan))
                client.Timeout = _settings.Timeout;
            
            if (_settings.MaxResponseContentBufferSize != default(long))
                client.MaxResponseContentBufferSize = _settings.MaxResponseContentBufferSize;
            
            client.BaseAddress = _settings.BaseAddress;
            client.Headers.Add("Authorization", string.Format("findsi_api_key apikey=\"{0}\"", _settings.Key));
        }
    }
}