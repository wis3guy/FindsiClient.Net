using System.Linq;

namespace Findsi.Domain
{
    public class Actor : Identifier
    {
        public Resource[] Resources { get; set; }

        public override bool IsValid
        {
            get { return base.IsValid && (Resources != null) && Resources.Any() && Resources.All(x => x.IsValid); }
        }
    }
}