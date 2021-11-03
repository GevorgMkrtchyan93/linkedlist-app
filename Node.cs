
namespace LinkedListApp
{
    public class Node<T>
    {
        public T _data;
        public Node<T> _next;
        public Node(T data)
        {
            _data = data;
            _next = null;
        }
    }
}
