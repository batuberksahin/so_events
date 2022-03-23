public interface IEventListener<TType>
{
    void RaiseEvent(TType parameter);
}