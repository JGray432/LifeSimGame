using System.Collections.Generic;

namespace LifeEventGame.StandardObjects
{
    // Mirror of PlayerAttributes but storing PlayerAttributeChange values.
    public class PlayerAttributeChanges
    {
        public List<PlayerAttributeChange> ToList()
        {
            return new List<PlayerAttributeChange>
            {
                Fitness,
                Education,
                Promiscuity,
                Addiction,
                Authenticity,
                Attractiveness,
                Creativity,
                PoliticalInterest
            };
        }

        public PlayerAttributeChange Fitness = new PlayerAttributeChange(0);
        public PlayerAttributeChange Education = new PlayerAttributeChange(0);
        public PlayerAttributeChange Promiscuity = new PlayerAttributeChange(0);
        public PlayerAttributeChange Addiction = new PlayerAttributeChange(0);
        public PlayerAttributeChange Authenticity = new PlayerAttributeChange(0);
        public PlayerAttributeChange Attractiveness = new PlayerAttributeChange(0);
        public PlayerAttributeChange Creativity = new PlayerAttributeChange(0);
        public PlayerAttributeChange PoliticalInterest = new PlayerAttributeChange(0);
    }
}
