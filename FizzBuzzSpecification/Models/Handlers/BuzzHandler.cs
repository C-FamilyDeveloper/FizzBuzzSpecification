using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Handlers
{
    public class BuzzHandler : SpecificationHandler<int>
    {
        private readonly IPrintable printer;
        public BuzzHandler(IPrintable printer)
        {
            this.printer = printer;
            MessageToSwitch = "Buzz";
        }
        public override void ExecuteAction(int @object)
        {
            if (Specification.IsSatisfiedBy(@object))
            {
                printer.AddToPrint(MessageToSwitch);
            }
            if (Handler != null)
            {
                Handler.ExecuteAction(@object);
            }
            else
            {
                if (printer.IsPrintEmpty())
                {
                    printer.AddToPrint(@object);
                }
                printer.Print();
                printer.ClearPrint();
            }
        }
    }
}
