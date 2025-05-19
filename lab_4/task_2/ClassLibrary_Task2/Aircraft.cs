namespace DesignPatterns.Mediator
{
    public class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }

        public Aircraft(string name)
        {
            Name = name;
        }
    }
}