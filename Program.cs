namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<string> singleLinkedList = new SingleLinkedList<string>();
            singleLinkedList.InsertLast("A");
            singleLinkedList.InsertLast("R");
            singleLinkedList.InsertLast("M");
            singleLinkedList.InsertLast("A");
            singleLinkedList.InsertLast("N");
            //var someNode = singleLinkedList.head._next;
            //singleLinkedList.InsertAfter(someNode, "g");
            //singleLinkedList.DeleteNodebyKey("M");
            singleLinkedList.Revers();

            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.InsertLast(1);
            doubleLinkedList.InsertLast(2);
            doubleLinkedList.InsertLast(3);
            doubleLinkedList.InsertLast(4);
            doubleLinkedList.InsertLast(5);
            //var someNode = doubleLinkedList.head._next;
            //doubleLinkedList.InsertAfter(someNode, 6);
            //doubleLinkedList.DeleteNodebyKey(3);
            doubleLinkedList.Revers();
        }
    }
}
