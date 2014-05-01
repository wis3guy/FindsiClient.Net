using System;
using System.Threading.Tasks;
using Findsi.Client;
using Findsi.Domain;
using HalClient.Net;
using HalClient.Net.Parser;
using Xunit;

namespace Findsi
{
    public class FindsiClientTests
    {
        private const string Key = "API_KEY_GOES_HERE"; 
        
        private readonly Uri _apiUri = new Uri("FINDSI_API_URI_GOES_HERE");
        private readonly IHalHttpClientWithRootFactory _factory;

        public FindsiClientTests()
        {
            var settings = new FindsiClientSettings {Key = Key, BaseAddress = _apiUri};
            _factory = new FindsiHalHttpClientFactory(new HalJsonParser(), settings);
        }

        [Fact]
        public async Task CanPostLog()
        {
            var actor = new Actor
            {
                Id = "123",
                Classification = "user",
                Resources = new[]
                {
                    new Resource {Rel = "email", Href = "geoffrey@braaf.nl"}
                }
            };

            var target = new Target
            {
                Id = "3717492",
                Classification = "article",
                Resource = new Resource
                {
                    Rel = "url",
                    Href = "http://www.example.com/foo/bar/baz.html"
                }
            };
            
            const string action = "read";

            using (var client = _factory.CreateClientWithRoot())
            {
                var resource = await client.Log(actor, action, target);
                
                Assert.NotNull(resource);
            }
        }

        [Fact]
        public async Task CanPostShortcurtForTargetDetail()
        {
            var target = new Identifier { Id = "3717492", Classification = "article" };

            using (var client = _factory.CreateClientWithRoot())
            {
                var resource = await client.TargetDetail(target);
                
                Assert.NotNull(resource);
            }
        }

        [Fact]
        public async Task CanPostShortcurtForTargetSimilars()
        {
            var actor = new Identifier { Id = "123", Classification = "user" };
            var target = new Identifier { Id = "3717492", Classification = "article" };

            using (var client = _factory.CreateClientWithRoot())
            {
                var resource = await client.TargetRecommendations(actor, target);

                Assert.NotNull(resource);
            }
        }

        [Fact]
        public async Task CanPostShortcurtForTargetRecommendations()
        {
            var actor = new Identifier {Id = "123", Classification = "user"};
            var target = new Identifier { Id = "3717492", Classification = "article" };
        
            using (var client = _factory.CreateClientWithRoot())
            {
                var resource = await client.TargetRecommendations(actor, target);

                Assert.NotNull(resource);
            }
        }

        [Fact]
        public async Task CanPostShortcurtForActorDetail()
        {
            var actor = new Identifier {Id = "123", Classification = "user"};

            using (var client = _factory.CreateClientWithRoot())
            {
                var resource = await client.ActorDetail(actor);

                Assert.NotNull(resource);
            }
        }

        [Fact]
        public async Task CanPostShortcurtForActorSimilars()
        {
            var actor = new Identifier { Id = "123", Classification = "user" };

            using (var client = _factory.CreateClientWithRoot())
            {
                var resource = await client.ActorSimilars(actor);

                Assert.NotNull(resource);
            }
        }

        [Fact]
        public async Task CanPostShortcurtForActorTargets()
        {
            var actor = new Identifier { Id = "123", Classification = "user" };

            using (var client = _factory.CreateClientWithRoot())
            {
                var resource = await client.ActorTargets(actor);
                
                Assert.NotNull(resource);
            }
        }
    }
}