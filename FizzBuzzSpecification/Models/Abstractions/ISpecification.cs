namespace FizzBuzzSpecification.Models.Abstractions
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T @object);
    }
}
