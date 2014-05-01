namespace Findsi.Domain
{
    public class Log
    {
        public Actor Actor { get; set; }
        public string Action { get; set; }
        public Target Target { get; set; }

        public bool IsValid {
            get
            {
                return (Actor != null) &&
                       Actor.IsValid &&
                       (Target != null) &&
                       Target.IsValid &&
                       !string.IsNullOrEmpty(Action);
            }
        }
    }
}