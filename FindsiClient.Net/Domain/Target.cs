namespace Findsi.Domain
{
    public class Target : Identifier
    {
        public Resource Resource { get; set; }

        public override bool IsValid
        {
            get { return base.IsValid && (Resource != null) && Resource.IsValid; }
        }
    }
}