internal class Program
{
    private static void Main(string[] args)
    {
        #region question1

        #region 1-Array
        /* 
        Access : O(1)

        Search : O(n)

        Insertion : O(n)

        Deletion : O(n)
         
         Business Case : Arrays are suitable for scenarios where random access to elements is frequent 
         
   
         
         */
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(arr[2]);

        #endregion

        #region 2-List
        /*
         Access : O(1)
         Search : O(n)
         Insertion : O(1)
         Deletion : O(n)
         Business Case: in applications where elements need to be added or removed frequently
         
         */

        List<int> lst = new List<int> { 1, 2, 3, 4, 5 };
        lst.Add(6); 
        lst.Remove(2);
        #endregion

        #region 3-LinkedList
        /*
         Access : O(n)
         Search : O(n)
         Insertion : O(1)
         Deletion : O(1)
         Business Case: in applications where elements need to be added or removed frequently
         
         */
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);

        #endregion

        #region 4-Dictionary
        /*
         Search : O(1)
         Insertion : O(1)
         Deletion : O(1)
         Business Case : Dictionaries are ideal for applications where fast data retrieval is essential
         
         */

        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(1, "one");
        dictionary.Add(2, "two");
        dictionary.Remove(1);
        #endregion

        #region 5-HashSet
        /*
         Search : O(1)
         Insertion : O(1)
         Deletion : O(1)
         Business Case : Used for eliminating duplicates and performing set operations like union, intersection, and difference
         
         */

        HashSet<int> hashSet = new HashSet<int>();
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Remove(1);
        #endregion

        #region 6-Stack
        /*
         Access : O(n)
         Search : O(n)
         Insertion : O(1)
         Deletion : O(1)
         Business Case : Used in applications where elements are added and removed in a last-in-first-out (LIFO) manner
         
         */

        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Pop();
        #endregion

        #region 7-Queue
        /*
         Access : O(n)
         Search : O(n)
         Insertion : O(1)
         Deletion : O(1)
         Business Case : Used in applications where elements are added and removed in a first-in-first-out (FIFO) manner
         
         */

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Dequeue();


        #endregion

        #endregion
    }
}