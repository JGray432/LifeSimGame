using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeEventGame
{
    public class GameEngine
    {
        private readonly Random _random = new Random();
        private readonly EventStorage _eventStorage = new EventStorage();

        public List<LifeEvent> GetRandomEvents(int count, PlayerAttributes playerAttributes)
        {
            if (count <= 0) 
                return new List<LifeEvent>();

            var copy = _eventStorage.Events.ToList();
            copy = FilterEvents(copy, playerAttributes);
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

        public List<LifeEvent> FilterEvents(List<LifeEvent> events, PlayerAttributes playerAttributes)
        {
            // Placeholder for filtering logic based on player attributes
            // For now, return all events without filtering
            return events;
        }
    }
}
