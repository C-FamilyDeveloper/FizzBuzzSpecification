namespace FizzBuzzSpecification.Models.Services
{
    public class ListMockService
    {
        public List<int> Mock(int startNumber, int endNumber) => Enumerable.Range(startNumber, endNumber - startNumber + 1).ToList();

    }
}
