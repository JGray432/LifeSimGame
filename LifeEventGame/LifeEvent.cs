namespace LifeEventGame
{
    public class LifeEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }

        // Add other custom properties as needed
        public LifeEvent(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public override string ToString() => Title;
    }
}
