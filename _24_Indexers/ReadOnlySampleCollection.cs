
namespace _24_Indexers 
{
    public class ReadOnlySampleCollection<T>(params IEnumerable<T> items) 
    {
        private T[] arr = [.. items];
        public T this[int i] => arr[i];
    }
}