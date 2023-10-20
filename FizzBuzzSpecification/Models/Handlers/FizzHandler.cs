using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Handlers
{
    public class FizzHandler : SpecificationHandler<int>
    {
        private readonly ISwitchable printer;
        public FizzHandler(ISwitchable printer)
        {
            this.printer = printer;
            MessageToSwitch = "Fizz";
        }
        public override string ExecuteAction(int @object)
        {
            if (Specification.IsSatisfiedBy(@object))
            {
                printer.AddToSwitch(MessageToSwitch);
            }
            if (Handler != null)
            {
                return Handler.ExecuteAction(@object);
            }
            else
            {
                if (printer.IsSwitchEmpty())
                {
                    printer.AddToSwitch(@object);
                }
                string print = printer.GetMessage();
                printer.ClearSwitch();
                return print;
            }
        }
    }
}
