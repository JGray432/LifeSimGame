using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeEventGame
{
    internal class EventStorage
    {
        public List<LifeEvent> Events = new List<LifeEvent>();
        public EventStorage()
        {
            PopulateEvents();            
        }

        public void PopulateEvents()
        {
            Events.Add(new LifeEvent("Find Treasure", "You discover a hidden cache of gold."));
            Events.Add(new LifeEvent("Lose Job", "You are laid off from your job."));
            Events.Add(new LifeEvent("New Friendship", "You meet a new friend."));
            Events.Add(new LifeEvent("Promotion", "You receive a promotion at work."));
            Events.Add(new LifeEvent("Sickness", "You fall ill and must rest."));
            Events.Add(new LifeEvent("Lucky Windfall", "A distant relative leaves you an inheritance."));
        }
    }
}
