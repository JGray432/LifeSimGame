namespace LifeEventGame.StandardObjects
{
    public class LifeEvent
    {
        public const int _maxAttributeValue = 10;
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal Probability { get; set; }

        public PlayerAttributes Attributes { get; set; } // Value = prob is maximised when player attribute is equal; Min/Max = required settings to have non-zero prob
        public PlayerAttributes AttributeChanges { get; set; } // Value = change to player attribute;

        public LifeEvent(string title, string description, PlayerAttributes attributes, PlayerAttributes attributeChanges)
        {
            Title = title;
            Description = description;
            Attributes = attributes;
            AttributeChanges = attributeChanges;
        }

        public PlayerAttributes UpdatePlayerAttributes(PlayerAttributes currentPlayer)
        {
            var attributeChangesList = AttributeChanges.ToList();
            var currentPlayerList = currentPlayer.ToList();
            for (int i = 0; i < attributeChangesList.Count; i++)
            {
                var attribute = attributeChangesList[i];
                var currentAttribute = currentPlayerList[i];

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
