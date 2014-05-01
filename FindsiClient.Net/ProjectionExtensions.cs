using System;
using System.Collections.Generic;
using Findsi.Domain;
using HalClient.Net.Parser;

namespace Findsi
{
    public static class ProjectionExtensions
    {
        public static Identifier AsIdentifier(this IResourceObject resource)
        {
            try
            {
                return new Identifier
                {
                    Classification = resource.State["classification"].Value,
                    Id = resource.State["id"].Value
                };
            }
            catch (KeyNotFoundException ex)
            {
                throw new ProjectionException(resource.GetType(), typeof(Identifier), ex);
            }
        }

        public static RankedIdentifier AsRankedIdentifier(this IResourceObject resource)
        {
            try
            {
                return new RankedIdentifier
                {
                    Classification = resource.State["classification"].Value,
                    Id = resource.State["id"].Value,
                    Rank = int.Parse(resource.State["rank"].Value)
                };
            }
            catch (FormatException ex)
            {
                throw new ProjectionException(resource.GetType(), typeof(RankedIdentifier), ex);
            }
            catch (OverflowException ex)
            {
                throw new ProjectionException(resource.GetType(), typeof(RankedIdentifier), ex);
            }
            catch (KeyNotFoundException ex)
            {
                throw new ProjectionException(resource.GetType(), typeof(RankedIdentifier), ex);
            }
        }
    }
}