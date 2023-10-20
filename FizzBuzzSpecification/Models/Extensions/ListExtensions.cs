using FizzBuzzSpecification.Models.Abstractions;

namespace FizzBuzzSpecification.Models.Extensions
{
    public static class ListExtensions
    {
        public static IEnumerable<string> ReplaceWithSpecifications(this List<int> source, SpecificationHandler<int> specificationHandler)
        {
            for (int i = 0; i <source.Count; i++)
            {
                yield return specificationHandler.ExecuteAction(source[i]);
            }
        }
    }
}
