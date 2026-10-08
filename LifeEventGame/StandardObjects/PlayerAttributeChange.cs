namespace LifeEventGame.StandardObjects
{
    // Represents a change to a player attribute when an event occurs.
    public class PlayerAttributeChange
    {
        public int Value { get; set; }

        public PlayerAttributeChange() { }

        public PlayerAttributeChange(int delta)
        {
            Value = delta;
        }

        public static implicit operator PlayerAttributeChange(int d) => new PlayerAttributeChange(d);
    }
}
