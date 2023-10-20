using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Handlers
{
    public class GoodBoyHandler : SpecificationHandler<int>
    {
        private readonly ISwitchable printer;
        public GoodBoyHandler(ISwitchable printer)
        {
            this.printer = printer;
            MessageToSwitch = "Good-Boy";
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
