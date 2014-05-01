namespace Findsi.Domain
{
    public static class LinkRelations
    {
        //
        // IANA

        public const string Self = "self";
        public const string First = "first";
        public const string Last = "last";
        public const string Next = "next";
        public const string Previous = "previous";
        
        //
        // HAL

        public const string Curies = "curies";

        //
        // FINDSI

        public static class Findsi
        {
            private const string Prefix = "findsi:";

            public const string Root = Prefix + "root";
            public const string Logs = Prefix + "logs";
            public const string Shortcuts = Prefix+ "shortcuts";
            public const string TargetList = Prefix + "targets";
            public const string TargetDetail = Prefix + "target";
            public const string TargetSimilars = Prefix + "target-similars";
            public const string TargetSimilar = Prefix + "similar-target";
            public const string TargetRecommendations = Prefix + "target-recommendations";
            public const string TargetRecommendation = Prefix + "recommended-actor";
            public const string ActorList = Prefix + "actors";
            public const string ActorDetail = Prefix + "actor";
            public const string ActorTargets = Prefix + "actor-targets";
            public const string ActorTarget = Prefix + "actor-target";
            public const string ActorSimilars = Prefix + "actor-similars";
            public const string ActorSimilar = Prefix + "similar-actor";
        }
    }
}