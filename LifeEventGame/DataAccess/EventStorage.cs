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
        // Attributes are Fitness, Education, Promiscuity, Addiction, Authenticity, Attractiveness, Creativity, PoliticalInterest

        /// <summary>
        /// Populates the Events list with predefined LifeEvent instances.
        /// Longer term will be replaced by a database population.
        /// LifeEvent arguments are: Title, Description, Attributes for event to appear, and AttributeChanges to apply to the player when the event occurs.
        /// </summary>
        public void PopulateEvents()
        {
            Events.Add(new LifeEvent(){Title = "Start an OnlyFans", Description = "Let's hope Mum doesn't find out...", 
                Attributes = new PlayerAttributes() { Fitness = 7, Education = 3, Promiscuity = 8, Addiction = 6, Authenticity = 4, Attractiveness = 8, Creativity = 3, PoliticalInterest = 2}, 
                AttributeChanges = new PlayerAttributeChanges(){Education = -1, Promiscuity = 2, Attractiveness = 1, Creativity = -1}});

            Events.Add(new LifeEvent(){Title = "Go to the gym", Description = "#gains", 
                Attributes = new PlayerAttributes() { Fitness = 5, Education = 4, Promiscuity = 6, Addiction = false, Authenticity = 4, Attractiveness = 6, Creativity = 3, PoliticalInterest = false}, 
                AttributeChanges = new PlayerAttributeChanges() { Fitness = 1});

            Events.Add(new LifeEvent(){Title = "Dating App", Description = "You hooked up with a stranger online.", 
                Attributes = new PlayerAttributes(), 
                AttributeChanges = new PlayerAttributeChanges()});

            Events.Add(new LifeEvent(){Title = "Tweet about civil rights", Description = "You rant into the void.", 
                Attributes = new PlayerAttributes(), 
                AttributeChanges = new PlayerAttributeChanges()});

            Events.Add(new LifeEvent(){Title = "Post a racy photo.", Description = "Rawr", 
                Attributes = new PlayerAttributes(), 
                AttributeChanges = new PlayerAttributeChanges()});

            Events.Add(new LifeEvent(){Title = "Tweet an unoriginal sports opinion", Description = "Go Sports!", 
                Attributes = new PlayerAttributes(), 
                AttributeChanges = new PlayerAttributeChanges()});
        }
    }
}
