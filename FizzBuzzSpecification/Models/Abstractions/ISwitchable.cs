namespace FizzBuzzSpecification.Models.Abstractions
{
    public interface ISwitchable
    {
        void AddToSwitch<T>(T value);
        void ClearSwitch();
        string GetMessage();
        bool IsSwitchEmpty();
    }
}
