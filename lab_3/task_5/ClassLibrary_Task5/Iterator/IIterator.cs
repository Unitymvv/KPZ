namespace ClassLibrary_Task5.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        LightNode Next();
    }
}