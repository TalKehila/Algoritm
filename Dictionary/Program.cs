internal class Program
{
    private static void Main() => _ = new Program();

    public Program()
    {

    }

    void MyList()
    {
        List<int> list = new List<int>();
        list.Add(1);
        list.Contains(1);
        list.ForEach(x => System.Console.WriteLine(x));

        var a = list.Where(x => x == 1).ToList();
        var b = list.FirstOrDefault(x => x == 1);
        var c = list.Select(a => a * a).ToArray();
    }

    void MyLinkedList()
    {

        LinkedList<int>? list = new LinkedList<int>();
        var node1 = list.AddLast(1);
        list.AddFirst(2);
        // node1.Value;

    }
    void MyStack()
    {
        Stack<int>? stack = new Stack<int>();
        stack.Push(2);
    }
    void MyQueue()
    {
        var q = new Queue<int>();
        q.Enqueue(1);
        var a1 = q.Dequeue();
    }


    void MyHash()
    {
        var d = new Dictionary<string, int>();
        d.Add("dvir", 123456);
        d.Add("tal", 987564);
        if (d.ContainsKey("dvir"))
        {
            int a = d["dvir"];
        }

    }
    void MyTree()
    {

        SortedSet

        SortedDictionary<int, string> a = new SortedDictionary<int, string>();
        SortedDictionary<int, SortedDictionary<int, object>> b = new();
    }


}