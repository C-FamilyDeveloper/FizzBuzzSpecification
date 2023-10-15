namespace FizzBuzzSpecification.Models.Abstractions
{
    public interface IPrintable
    {
        void AddToPrint<T>(T value);
        void ClearPrint();
        void Print();
        bool IsPrintEmpty();
    }
}
