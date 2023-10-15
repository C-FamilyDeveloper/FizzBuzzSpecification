using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Specifications
{
    public class FizzSpecification : SpecificationHandler<int>
    {
        private readonly IPrintable printer;

        public FizzSpecification(IPrintable printer)
        {
            this.printer = printer;
        }
        public override void ExecuteAction(int @object)
        {
            if (IsSatisfiedBy(@object))
            {
                printer.AddToPrint("Fizz");
            }
            if (Specification != null)
            {
                Specification.ExecuteAction(@object);
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
        public override bool IsSatisfiedBy(int @object) => @object % 3 == 0;
    }
}
