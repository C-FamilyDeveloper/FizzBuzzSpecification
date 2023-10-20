using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Handlers
{
    public class BuzzHandler : SpecificationHandler<int>
    {
        private readonly ISwitchable printer;
        public BuzzHandler(ISwitchable printer)
        {
            this.printer = printer;
            MessageToSwitch = "Buzz";
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
                string print =  printer.GetMessage();
                printer.ClearSwitch();
                return print;
            }
        }
    }
}
