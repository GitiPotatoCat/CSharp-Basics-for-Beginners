
namespace _24_Indexers 
{
    public class SampleCollection<T> 
    {
        private T[] arr = new T[100];

        public T this[int i] 
        {
            get => arr[i];
            set => arr[i] = value;
        }
    }
}