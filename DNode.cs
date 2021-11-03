namespace LinkedListApp
{
    public class DNode<T>
    {
        public T _data;
        public DNode<T> _next;
        public DNode<T> _prev;
        public DNode(T data)
        {
            _data = data;
            _next = null;
            _prev = null;
        }
    }
}
