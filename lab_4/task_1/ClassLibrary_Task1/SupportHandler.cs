namespace ClassLibrary_Task1
{
    public abstract class SupportHandler
    {
        public SupportHandler next;

        public void SetNext(SupportHandler next)
        {
            this.next = next;
        }

        public abstract bool Handle(string input);
    }
}
