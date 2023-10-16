using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Specifications.CompositeSpecifications
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        private ISpecification<T> specification;
        public NotSpecification(ISpecification<T> specification)
        {
            this.specification = specification;
        }

        public override bool IsSatisfiedBy(T @object)
        {
            return !specification.IsSatisfiedBy(@object);
        }
    }
}
