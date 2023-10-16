using FizzBuzzSpecification.Models.Abstractions;
using FizzBuzzSpecification.Models.Specifications.CompositeSpecifications;

namespace FizzBuzzSpecification.Models.Extensions
{
    public static class SpecificationExtensions
    {
        public static ISpecification<T> And<T>(this ISpecification<T> specification, ISpecification<T> otherSpecification)
        {
            return new AndSpecification<T>(specification, otherSpecification);
        }
        public static ISpecification<T> Or<T>(this ISpecification<T> specification, ISpecification<T> otherSpecification)
        {
            return new OrSpecification<T>(specification, otherSpecification);
        }
        public static ISpecification<T> Not<T>(this ISpecification<T> specification)
        {
            return new NotSpecification<T>(specification);
        }
    }
}
