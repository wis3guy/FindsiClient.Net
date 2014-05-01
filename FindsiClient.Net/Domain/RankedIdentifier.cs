using HalClient.Net.Parser;

namespace Findsi.Domain
{
    public class RankedIdentifier : Identifier
    {
        public int Rank { get; set; }

        public static RankedIdentifier FromEmbeddedResource(IEmbeddedResourceObject embedded)
        {
            return new RankedIdentifier
            {
                Classification = embedded.State["Classification"].Value,
                Id = embedded.State["Id"].Value,
                Rank = int.Parse(embedded.State["Rank"].Value)
            };
        }
    }
}