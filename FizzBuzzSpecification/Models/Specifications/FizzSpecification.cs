using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Specifications
{
    public class FizzSpecification : ISpecification<int>
    {
        public bool IsSatisfiedBy(int @object) => @object % 3 == 0;
    }
}
