using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Specifications.CompositeSpecifications
{
    public class NotSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> specification;
        public NotSpecification(ISpecification<T> specification)
        {
            this.specification = specification;
        }

        public bool IsSatisfiedBy(T @object)
        {
            return !specification.IsSatisfiedBy(@object);
        }
    }
}
