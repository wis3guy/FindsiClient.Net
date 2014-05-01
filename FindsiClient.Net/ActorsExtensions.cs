using System;
using System.Linq;
using System.Threading.Tasks;
using Findsi.Domain;
using HalClient.Net;
using HalClient.Net.Parser;

namespace Findsi
{
    public static class ActorsExtensions
    {
        public static Task<IRootResourceObject> ActorList(
            this IHalHttpClientWithRoot client,
            string filter = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            var uri = client.Root.Links[LinkRelations.Findsi.ActorList].Single().Href;

            if (!string.IsNullOrEmpty(filter))
            {
                uri = uri.ToString().Contains("?")
                    ? new Uri(string.Format("{0}&filter={1}", uri, filter))
                    : new Uri(string.Format("{0}?filter={1}", uri, filter));
            }

            return client.GetAsync(uri);
        }
    }
}