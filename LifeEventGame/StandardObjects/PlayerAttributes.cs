namespace LifeEventGame.StandardObjects
{
    public class PlayerAttributes
    {        
        public List<PlayerAttribute> ToList()
        {
            return new List<PlayerAttribute>
            {
                Fitness,
                Education,
                Promiscuity,
                Addiction,
                Authenticity,
                Attractiveness,
                Creativity
            };
        }
        public PlayerAttribute Fitness = new PlayerAttribute(5);
        public PlayerAttribute Education = new PlayerAttribute(5);
        public PlayerAttribute Promiscuity = new PlayerAttribute(5);
        public PlayerAttribute Addiction = new PlayerAttribute(5);
        public PlayerAttribute Authenticity = new PlayerAttribute(5);
        public PlayerAttribute Attractiveness = new PlayerAttribute(5);
        public PlayerAttribute Creativity = new PlayerAttribute(5);
    }
}
