namespace LifeEventGame.StandardObjects
{
    public class PlayerAttributes
    {
        public List<Attribute> ToList()
        {
            return new List<Attribute>
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
        public Attribute Fitness = new Attribute("Fitness", 5);
        public Attribute Education = new Attribute("Education", 5);
        public Attribute Promiscuity = new Attribute("Promiscuity", 5);
        public Attribute Addiction = new Attribute("Addiction", 5);
        public Attribute Authenticity = new Attribute("Authenticity", 5);
        public Attribute Attractiveness = new Attribute("Attractiveness", 5);
        public Attribute Creativity = new Attribute("Creativity", 5);
    }
}
