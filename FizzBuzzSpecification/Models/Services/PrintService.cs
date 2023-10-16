using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Services
{
    public class PrintService : IPrintable
    {
        private string separator;
        private List<string> strings = new();
        public PrintService(string separator)
        {
            this.separator = separator;
        }
        public void AddToPrint<T>(T value)
        {
            strings.Add(value!.ToString());
        }

        public void ClearPrint()
        {
            strings.Clear();
        }

        public bool IsPrintEmpty()
        {
            return !strings.Any();
        }

        public void Print()
        {
            Console.WriteLine(string.Join(separator, strings));
        }
    }
}
