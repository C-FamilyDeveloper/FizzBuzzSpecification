using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Extensions
{
    public static class ListExtensions
    {
        public static void PrintWithSpecifications<T>(this List<T> source, SpecificationHandler<T> specificationHandler)
        {
            foreach (var element in source)
            {
                specificationHandler.ExecuteAction(element);
            }
        }
    }
}
