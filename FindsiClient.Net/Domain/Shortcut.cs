namespace Findsi.Domain
{
    public class Shortcut
    {
        public string Filter { get; set; }
        public string Rel { get; set; }
        public Identifier Actor { get; set; }
        public Identifier Target { get; set; }
    }
}