namespace Findsi.Domain
{
    public class Resource
    {
        public string Rel { get; set; }
        public string Href { get; set; }

        internal bool IsValid
        {
            get { return !string.IsNullOrEmpty(Rel) && !string.IsNullOrEmpty(Href); }
        }
    }
}