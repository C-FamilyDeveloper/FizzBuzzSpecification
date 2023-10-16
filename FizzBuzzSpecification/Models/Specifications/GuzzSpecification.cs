using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Specifications
{
    public class GuzzSpecification : ISpecification<int>
    {
        public bool IsSatisfiedBy(int @object) => @object % 7 == 0;
    }
}
