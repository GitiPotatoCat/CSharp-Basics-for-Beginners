

namespace _08_DesignStack 
{
    public class MyStack 
    {
        private readonly List<object> _items;



        public MyStack() 
        {
            _items = new List<object>();
        }


        public void Push(object obj) 
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot push null onto the stack.");

            _items.Add(obj);
        }


        public object Pop() 
        {
            if (_items.Count == 0)
                throw new InvalidOperationException("Cannot pop from an empty stack.");

            int lastIndex = _items.Count - 1;
            object item = _items[lastIndex];
            _items.RemoveAt(lastIndex);

            return item; 
        }


        public void Clear() 
        {
            _items.Clear();
        }

    }
}
