using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeEventGame
{
    public class GameEngine
    {
        private readonly Random _random = new Random();
        private readonly List<LifeEvent> _events = new();

        public GameEngine()
        {
            // Populate placeholder events. User can replace or extend this list.
            _events.Add(new LifeEvent("Find Treasure", "You discover a hidden cache of gold."));
            _events.Add(new LifeEvent("Lose Job", "You are laid off from your job."));
            _events.Add(new LifeEvent("New Friendship", "You meet a new friend."));
            _events.Add(new LifeEvent("Promotion", "You receive a promotion at work."));
            _events.Add(new LifeEvent("Sickness", "You fall ill and must rest."));
            _events.Add(new LifeEvent("Lucky Windfall", "A distant relative leaves you an inheritance."));
        }

        public IReadOnlyList<LifeEvent> AllEvents => _events.AsReadOnly();

        public List<LifeEvent> GetRandomEvents(int count)
        {
            if (count <= 0) return new List<LifeEvent>();
            var copy = _events.ToList();
            var result = new List<LifeEvent>();
            int take = Math.Min(count, copy.Count);
            for (int i = 0; i < take; i++)
            {
                int idx = _random.Next(copy.Count);
                result.Add(copy[idx]);
                copy.RemoveAt(idx);
            }
            return result;
        }

        // Allow user code to add custom events
        public void AddEvent(LifeEvent ev) => _events.Add(ev);
    }
}
