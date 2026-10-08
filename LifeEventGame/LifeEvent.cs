namespace LifeEventGame
{
    public class LifeEvent
    {
        public const int _maxAttributeValue = 10;
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal Probability { get; set; }

        public PlayerAttributes RequiredAttributes { get; set; }
        public PlayerAttributes AttributeChanges { get; set; }

        public LifeEvent(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public PlayerAttributes UpdatePlayerAttributes(PlayerAttributes currentPlayer)
        {
            foreach (var attribute in AttributeChanges.ToList())
            {
                var currentAttribute = currentPlayer.ToList().Find(a => a.Name == attribute.Name);
                if (currentAttribute != null)
                {
                    currentAttribute.Value += attribute.Value;
                    currentAttribute.Value = Math.Clamp(currentAttribute.Value, 0, _maxAttributeValue);
                }
            }
            return currentPlayer;
        }
    }
}
