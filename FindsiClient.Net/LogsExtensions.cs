using System;
using System.Linq;
using System.Threading.Tasks;
using Findsi.Domain;
using HalClient.Net;
using HalClient.Net.Parser;

namespace Findsi
{
    public static class LogsExtensions
    {
        public static Task<IRootResourceObject> Log(this IHalHttpClientWithRoot client, Actor actor, string action, Target target)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (actor == null) throw new ArgumentNullException("actor");
            if (action == null) throw new ArgumentNullException("action");
            if (target == null) throw new ArgumentNullException("target");

            var log = new Log
            {
                Action = action,
                Actor = actor,
                Target = target
            };

            return Log(client, log);
        }

        private static Task<IRootResourceObject> Log(IHalHttpClientWithRoot client, Log log)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (log == null) throw new ArgumentNullException("log");
            if (!log.IsValid) throw new ArgumentException("Invalid log", "log");

            var uri = client.Root.Links[LinkRelations.Findsi.Logs].Single().Href;
            return client.PostAsync(uri, log);
        }
    }
}