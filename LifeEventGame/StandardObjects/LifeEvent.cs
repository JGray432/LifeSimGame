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
        public PlayerAttributeChanges AttributeChanges { get; set; } // Value = change to player attribute;

        public PlayerAttributes UpdatePlayerAttributes(PlayerAttributes currentPlayer)
        {
            var attributeChangesList = AttributeChanges.ToList();
            var currentPlayerList = currentPlayer.ToList();
            for (int i = 0; i < attributeChangesList.Count; i++)
            {
                var change = attributeChangesList[i];
                var currentAttribute = currentPlayerList[i];

                if (currentAttribute != null)
                {
                    currentAttribute.Value += change.Value;
                    currentAttribute.Value = Math.Clamp(currentAttribute.Value, 0, _maxAttributeValue);
                }
            }
            currentPlayer.Day++;
            return currentPlayer;
        }
    }
}
