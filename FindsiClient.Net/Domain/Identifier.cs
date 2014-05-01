namespace Findsi.Domain
{
    public class Identifier
    {
        public string Id { get; set; }
        public string Classification { get; set; }

        public virtual bool IsValid
        {
            get { return !string.IsNullOrEmpty(Id) && !string.IsNullOrEmpty(Classification); }
        }
    }
}