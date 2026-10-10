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
        // Attributes are: Addiction, Attractiveness, Authenticity, Creativity, Education, Fitness, PoliticalInterest, Promiscuity

        /// <summary>
        /// Populates the Events list with predefined LifeEvent instances.
        /// Longer term will be replaced by a database population.
        /// LifeEvent arguments are: Title, Description, Attributes for event to appear, and AttributeChanges to apply to the player when the event occurs.
        /// </summary>
        public void PopulateEvents()
        {
            Events.Add(new LifeEvent()
            {
                Title = "Start an OnlyFans",
                Description = "Let's hope Mum doesn't find out...",
                Attributes = new PlayerAttributes() { Addiction = 6, Attractiveness = 8, Authenticity = 4, Creativity = 3, Education = 3, Fitness = 7, PoliticalInterest = 2, Promiscuity = 8 },
                AttributeChanges = new PlayerAttributeChanges() { Attractiveness = 1, Creativity = -1, Education = -1, Promiscuity = 2 }
            });

            Events.Add(new LifeEvent()
            {
                Title = "Go to the gym",
                Description = "#gains",
                Attributes = new PlayerAttributes() { Addiction = false, Attractiveness = 6, Authenticity = 4, Creativity = 3, Education = 4, Fitness = 5, PoliticalInterest = false, Promiscuity = 6 },
                AttributeChanges = new PlayerAttributeChanges() { Attractiveness = 1, Fitness = 1 }
            });

            Events.Add(new LifeEvent()
            {
                Title = "Dating App",
                Description = "You hooked up with a stranger online.",
                Attributes = new PlayerAttributes(),
                AttributeChanges = new PlayerAttributeChanges()
            });

            Events.Add(new LifeEvent()
            {
                Title = "Tweet about civil rights",
                Description = "You rant into the void.",
                Attributes = new PlayerAttributes(),
                AttributeChanges = new PlayerAttributeChanges()
            });

            Events.Add(new LifeEvent()
            {
                Title = "Post a racy photo.",
                Description = "Rawr",
                Attributes = new PlayerAttributes(),
                AttributeChanges = new PlayerAttributeChanges()
            });

            Events.Add(new LifeEvent()
            {
                Title = "Get a cat",
                Description = "Meow!",
                Attributes = new PlayerAttributes() { Addiction = 7, Attractiveness = 2, Authenticity = false, Creativity = false, Education = false, Fitness = false, PoliticalInterest = 2, Promiscuity = false },
                AttributeChanges = new PlayerAttributeChanges() { Attractiveness = -1, Promiscuity = -2 }
            });


            Events.Add(new LifeEvent()
            {
                Title = "Get another cat",
                Description = "Meoww!",
                Attributes = new PlayerAttributes() { Addiction = 8, Attractiveness = 2, Authenticity = false, Creativity = false, Education = false, Fitness = false, PoliticalInterest = 2, Promiscuity = false },
                AttributeChanges = new PlayerAttributeChanges() { Attractiveness = -1, Promiscuity = -2, Addiction = +1 }
            });


            Events.Add(new LifeEvent()
            {
                Title = "Get another cat",
                Description = "Meowww!",
                Attributes = new PlayerAttributes() { Addiction = 10, Attractiveness = 2, Authenticity = false, Creativity = false, Education = false, Fitness = false, PoliticalInterest = 2, Promiscuity = false },
                AttributeChanges = new PlayerAttributeChanges() { Attractiveness = -1, Promiscuity = -2, Addiction = +2 }
            });

            Events.Add(new LifeEvent()
            {
                Title = "Get into kreatine",
                Description = "Get those gains",
                Attributes = new PlayerAttributes() { Addiction = 6, Attractiveness = 8, Authenticity = 2, Creativity = false, Education = 2, Fitness = false, PoliticalInterest = 2, Promiscuity = false },
                AttributeChanges = new PlayerAttributeChanges() { Attractiveness = 1, Promiscuity = 1, Addiction = 1 }
            });


            Events.Add(new LifeEvent()
            {
                Title = "Tweet an unoriginal sports opinion",
                Description = "Go Sports!",
                Attributes = new PlayerAttributes(),
                AttributeChanges = new PlayerAttributeChanges()
            });
        }
    }
}
