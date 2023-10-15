using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Services
{
    public class PrintService : IPrintable
    {
        private string printString = string.Empty;
        public void AddToPrint<T>(T value)
        {
            printString += value!.ToString();
        }

        public void ClearPrint()
        {
            printString = string.Empty;
        }

        public bool IsPrintEmpty()
        {
            return string.IsNullOrWhiteSpace(printString);
        }

        public void Print()
        {
            Console.WriteLine(printString);
        }
    }
}
