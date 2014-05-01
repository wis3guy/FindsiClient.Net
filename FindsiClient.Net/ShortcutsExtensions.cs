using System;
using System.Linq;
using System.Threading.Tasks;
using Findsi.Domain;
using HalClient.Net;
using HalClient.Net.Parser;

namespace Findsi
{
    public static class ShortcutsExtensions
    {
        public static Task<IRootResourceObject> ActorDetail(
            this IHalHttpClientWithRoot client,
            string classification,
            string id)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (classification == null) throw new ArgumentNullException("classification");
            if (id == null) throw new ArgumentNullException("id");

            var actor = new Identifier
            {
                Classification = classification,
                Id = id
            };

            return ActorDetail(client, actor);
        }

        public static Task<IRootResourceObject> ActorDetail(
            this IHalHttpClientWithRoot client,
            Identifier actor)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (actor == null) throw new ArgumentNullException("actor");
            if (!actor.IsValid) throw new ArgumentException("Invalid actor", "actor");

            var shortcut = new Shortcut
            {
                Actor = actor,
                Rel = LinkRelations.Findsi.ActorDetail
            };

            return Shortcut(client, shortcut);
        }

        public static Task<IRootResourceObject> ActorTargets(
            this IHalHttpClientWithRoot client,
            string classification,
            string id,
            string filter = null)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (classification == null) throw new ArgumentNullException("classification");
            if (id == null) throw new ArgumentNullException("id");

            var actor = new Identifier
            {
                Classification = classification,
                Id = id
            };

            return ActorTargets(client, actor, filter);
        }

        public static Task<IRootResourceObject> ActorTargets(
            this IHalHttpClientWithRoot client,
            Identifier actor,
            string filter = null)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (actor == null) throw new ArgumentNullException("actor");
            if (!actor.IsValid) throw new ArgumentException("Invalid actor", "actor");

            var shortcut = new Shortcut
            {
                Actor = actor,
                Rel = LinkRelations.Findsi.ActorTargets,
                Filter = filter
            };

            return Shortcut(client, shortcut);
        }

        public static Task<IRootResourceObject> ActorSimilars(
            this IHalHttpClientWithRoot client,
            string classification,
            string id,
            string filter = null)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (classification == null) throw new ArgumentNullException("classification");
            if (id == null) throw new ArgumentNullException("id");

            var actor = new Identifier
            {
                Classification = classification,
                Id = id
            };

            return ActorSimilars(client, actor, filter);
        }

        public static Task<IRootResourceObject> ActorSimilars(
            this IHalHttpClientWithRoot client,
            Identifier actor,
            string filter = null)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (actor == null) throw new ArgumentNullException("actor");
            if (!actor.IsValid) throw new ArgumentException("Invalid actor", "actor");

            var shortcut = new Shortcut
            {
                Actor = actor,
                Rel = LinkRelations.Findsi.ActorSimilars,
                Filter = filter
            };

            return Shortcut(client, shortcut);
        }

        public static Task<IRootResourceObject> TargetDetail(
            this IHalHttpClientWithRoot client,
            string classification,
            string id)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (classification == null) throw new ArgumentNullException("classification");
            if (id == null) throw new ArgumentNullException("id");

            var target = new Identifier
            {
                Classification = classification,
                Id = id
            };

            return TargetDetail(client, target);
        }

        public static Task<IRootResourceObject> TargetDetail(
            this IHalHttpClientWithRoot client,
            Identifier target)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (target == null) throw new ArgumentNullException("target");
            if (!target.IsValid) throw new ArgumentException("Invalid target", "target");

            var shortcut = new Shortcut
            {
                Target = target,
                Rel = LinkRelations.Findsi.TargetDetail
            };

            return Shortcut(client, shortcut);
        }

        public static Task<IRootResourceObject> TargetSimilars(
            this IHalHttpClientWithRoot client,
            string actorClassification,
            string actorId,
            string targetClassification,
            string targetId,
            string filter = null)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (actorClassification == null) throw new ArgumentNullException("actorClassification");
            if (actorId == null) throw new ArgumentNullException("actorId");
            if (targetClassification == null) throw new ArgumentNullException("targetClassification");
            if (targetId == null) throw new ArgumentNullException("targetId");

            var actor = new Identifier
            {
                Classification = actorClassification,
                Id = actorId
            };

            var target = new Identifier
            {
                Classification = targetClassification,
                Id = targetId
            };

            return TargetSimilars(client, actor, target, filter);
        }

        public static Task<IRootResourceObject> TargetSimilars(
            this IHalHttpClientWithRoot client,
            Identifier actor,
            Identifier target,
            string filter = null)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (actor == null) throw new ArgumentNullException("actor");
            if (target == null) throw new ArgumentNullException("target");
            if (!target.IsValid) throw new ArgumentException("Invalid target", "target");
            if (!actor.IsValid) throw new ArgumentException("Invalid actor", "actor");

            var shortcut = new Shortcut
            {
                Actor = actor,
                Target = target,
                Rel = LinkRelations.Findsi.TargetSimilars,
                Filter = filter
            };

            return Shortcut(client, shortcut);
        }

        public static Task<IRootResourceObject> TargetRecommendations(
            this IHalHttpClientWithRoot client,
            string actorClassification,
            string actorId,
            string targetClassification,
            string targetId,
            string filter = null)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (actorClassification == null) throw new ArgumentNullException("actorClassification");
            if (actorId == null) throw new ArgumentNullException("actorId");
            if (targetClassification == null) throw new ArgumentNullException("targetClassification");
            if (targetId == null) throw new ArgumentNullException("targetId");

            var actor = new Identifier
            {
                Classification = actorClassification,
                Id = actorId
            };

            var target = new Identifier
            {
                Classification = targetClassification,
                Id = targetId
            };

            return TargetRecommendations(client, actor, target, filter);
        }

        public static Task<IRootResourceObject> TargetRecommendations(
            this IHalHttpClientWithRoot client,
            Identifier actor,
            Identifier target,
            string filter = null)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (actor == null) throw new ArgumentNullException("actor");
            if (target == null) throw new ArgumentNullException("target");
            if (!target.IsValid) throw new ArgumentException("Invalid target", "target");
            if (!actor.IsValid) throw new ArgumentException("Invalid actor", "actor");

            var shortcut = new Shortcut
            {
                Actor = actor,
                Target = target,
                Rel = LinkRelations.Findsi.TargetRecommendations,
                Filter = filter
            };

            return Shortcut(client, shortcut);
        }

        public static Task<IRootResourceObject> Shortcut(this IHalHttpClientWithRoot client, Shortcut shortcut)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (shortcut == null) throw new ArgumentNullException("shortcut");

            var uri = client.Root.Links[LinkRelations.Findsi.Shortcuts].Single().Href;
            
            return client.PostAsync(uri, shortcut);
        }
    }
}