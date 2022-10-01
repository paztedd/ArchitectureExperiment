public interface IInputManager
{
    void Subscribe(IRawInputProvider provider);
    void Unsubscribe(IRawInputProvider provider);
}