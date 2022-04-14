namespace ConsoleApplication1
{
    public class ListNode<T>
    {
        public ListNode(T obj)
        {
            Obj = obj;
        }

        


        public T Obj { get; set; }
        public ListNode<T> Previous {get; set;}
        public ListNode<T> Next {get; set;}
    }
}