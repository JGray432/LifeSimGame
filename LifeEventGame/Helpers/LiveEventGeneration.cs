using LifeEventGame.DataAccess;
using LifeEventGame.StandardObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeEventGame.Helpers
{
    public class LiveEventGeneration
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
                AssignEventProbs(copy, playerAttributes); // need to re-assign probs at the start of each loop to account for removed events
                var orderedEvents = copy.OrderByDescending(e => e.Probability).ToList();

                decimal rand = _random.Next(0, 10000)/10000m;
                int idx = GetEventIndexFromProb(orderedEvents, rand);

                result.Add(copy[idx]);
                copy.RemoveAt(idx);
            }
            return result;
        }

        private List<LifeEvent> FilterEvents(List<LifeEvent> events, PlayerAttributes playerAttributes)
        {
            // Placeholder for filtering logic based on player attributes
            // For now, return all events without filtering
            return events;
        }

        private void AssignEventProbs(List<LifeEvent> events, PlayerAttributes playerAttributes)
        {
            // Placeholder for probability assignment logic based on player attributes
            // For now, set a default probability for all events
            decimal weightSum = 0;
            foreach (var ev in events)
            {
                var prob = AssignEventProbToCurrentPlayer(ev, playerAttributes); 
                ev.Weight = prob;
                weightSum += prob;
            }

            foreach (var ev in events)
            {
                ev.Probability = ev.Weight / weightSum;
            }
        }

        private decimal AssignEventProbToCurrentPlayer(LifeEvent lifeEvent, PlayerAttributes playerAttributes)
        {
            // Need higher prob awarded to closer value attributes
            // Skip attributes assigned -1 (not applicable)
            return 0.5m;
        }

        private int GetEventIndexFromProb(List<LifeEvent> events, decimal rand)
        {
            decimal cumulative = 0;
            for (int i = 0; i < events.Count; i++)
            {
                cumulative += events[i].Probability;
                if (rand <= cumulative)
                {
                    return i;
                }
            }
            return events.Count - 1; // Fallback in case of rounding errors
        }
    }
}
