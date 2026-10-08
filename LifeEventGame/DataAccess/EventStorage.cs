using LifeEventGame.StandardObjects;

namespace LifeEventGame.DataAccess
{
    internal class EventStorage
    {
        public List<LifeEvent> Events = new List<LifeEvent>();
        public EventStorage()
        {
            PopulateEvents();            
        }

        /// <summary>
        /// Populates the Events list with predefined LifeEvent instances.
        /// Longer term will be replaced by a database population.
        /// LifeEvent arguments are: Title, Description, Attributes for event to appear, and AttributeChanges to apply to the player when the event occurs.
        /// </summary>
        public void PopulateEvents()
        {
            Events.Add(new LifeEvent("Find Treasure", "You discover a hidden cache of gold.", 
                new PlayerAttributes() { Fitness = new PlayerAttribute(6)}, 
                new PlayerAttributes()));
            Events.Add(new LifeEvent("Lose Job", "You are laid off from your job.", 
                new PlayerAttributes(), 
                new PlayerAttributes()));
            Events.Add(new LifeEvent("New Friendship", "You meet a new friend.", 
                new PlayerAttributes(), new PlayerAttributes()));
            Events.Add(new LifeEvent("Promotion", "You receive a promotion at work.", new PlayerAttributes(), new PlayerAttributes()));
            Events.Add(new LifeEvent("Sickness", "You fall ill and must rest.", new PlayerAttributes(), new PlayerAttributes()));
            Events.Add(new LifeEvent("Lucky Windfall", "A distant relative leaves you an inheritance.", new PlayerAttributes(), new PlayerAttributes()));
        }
    }
}
