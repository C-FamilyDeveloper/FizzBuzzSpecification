using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Handlers
{
    public class GuzzHandler : SpecificationHandler<int>
    {
        private readonly IPrintable printer;
        public GuzzHandler(IPrintable printer)
        {
            this.printer = printer;
            MessageToSwitch = "Guzz";
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
