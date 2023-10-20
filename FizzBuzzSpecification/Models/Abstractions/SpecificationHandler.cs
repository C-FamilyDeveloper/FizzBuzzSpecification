namespace FizzBuzzSpecification.Models.Abstractions
{
    public abstract class SpecificationHandler<T>
    {
        public ISpecification<T> Specification { get; set; }
        public string MessageToSwitch { get; set; }
        public SpecificationHandler<T> Handler { get; set; }
        public abstract string ExecuteAction(T value);

    }
}
