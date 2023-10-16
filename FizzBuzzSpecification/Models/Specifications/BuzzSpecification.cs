using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Specifications
{
    public class BuzzSpecification : ISpecification<int>
    {
        public bool IsSatisfiedBy(int @object) => @object % 5 == 0;
    }
}
