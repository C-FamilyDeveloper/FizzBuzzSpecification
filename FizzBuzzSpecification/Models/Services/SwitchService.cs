using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Services
{
    public class SwitchService : ISwitchable
    {
        private string separator;
        private List<string> strings = new();
        public SwitchService(string separator)
        {
            this.separator = separator;
        }
        public void AddToSwitch<T>(T value)
        {
            strings.Add(value!.ToString());
        }

        public void ClearSwitch()
        {
            strings.Clear();
        }

        public bool IsSwitchEmpty()
        {
            return !strings.Any();
        }

        public string GetMessage()
        {
            return string.Join(separator, strings);
        }
    }
}
