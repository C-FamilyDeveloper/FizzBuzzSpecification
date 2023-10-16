using FizzBuzzSpecification.Models.Specifications.CompositeSpecifications;

namespace FizzBuzzSpecification.Models.Abstractions
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }
        public abstract bool IsSatisfiedBy(T @object);
        public ISpecification<T> Not()
        {
            return new NotSpecification<T>(this);
        }

        public ISpecification<T> Or(ISpecification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
    }
}
