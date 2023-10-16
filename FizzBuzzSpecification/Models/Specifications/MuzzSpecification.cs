using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Specifications
{
    public class MuzzSpecification : ISpecification<int>
    {
        public bool IsSatisfiedBy(int @object) => @object % 4 == 0;
    }
}
