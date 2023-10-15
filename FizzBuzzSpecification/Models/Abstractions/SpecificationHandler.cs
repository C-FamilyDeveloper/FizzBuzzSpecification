namespace FizzBuzzSpecification.Models.Abstractions
{
    public abstract class SpecificationHandler<T> : ISpecification<T>
    {
        public SpecificationHandler<T> Specification { get; set; }
        public abstract void ExecuteAction(T @object);
        public abstract bool IsSatisfiedBy(T @object);
    }
}
