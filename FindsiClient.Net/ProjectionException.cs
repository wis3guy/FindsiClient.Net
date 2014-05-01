using System;

namespace Findsi
{
    public class ProjectionException : Exception
    {
        public ProjectionException(Type sourceType, Type destinationType, Exception inner) 
            : base("Could not project the source type into the destination type", inner)
        {
            SourceType = sourceType;
            DestinationType = destinationType;
        }

        public Type SourceType { get; private set; }
        public Type DestinationType { get; private set; }
    }
}