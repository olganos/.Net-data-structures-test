using System.Diagnostics;

var array = new int[1000000];
for (var index = 0; index < 1000000; index++)
{
    array[index] = index;
}

Console.WriteLine("1,000,000 items array");
Console.WriteLine();

var dataStructureExamples = new DataStructureExamples();

var stopWatch = new Stopwatch();
stopWatch.Start();
dataStructureExamples.CreateStack(array);
stopWatch.Stop();

Console.WriteLine($"Stack was created in {stopWatch.Elapsed.TotalMilliseconds} miliseconds");

stopWatch.Reset();
stopWatch.Start();
dataStructureExamples.CleanStack();
stopWatch.Stop();

Console.WriteLine($"Stack was cleaned in {stopWatch.Elapsed.TotalMilliseconds} miliseconds");
Console.WriteLine();

stopWatch.Reset();
stopWatch.Start();
dataStructureExamples.CreateQueue(array);
stopWatch.Stop();

Console.WriteLine($"Queue was created in {stopWatch.Elapsed.TotalMilliseconds} miliseconds");

stopWatch.Reset();
stopWatch.Start();
dataStructureExamples.CleanQueue();
stopWatch.Stop();

Console.WriteLine($"Queue was cleaned in {stopWatch.Elapsed.TotalMilliseconds} miliseconds");
Console.WriteLine();

stopWatch.Reset();
stopWatch.Start();
dataStructureExamples.CreateLinkedList(array);
stopWatch.Stop();

Console.WriteLine($"Linked list was created in {stopWatch.Elapsed.TotalMilliseconds} miliseconds");

stopWatch.Reset();
stopWatch.Start();
dataStructureExamples.CleanLinkeList();
stopWatch.Stop();

Console.WriteLine($"Linked list was cleaned in {stopWatch.Elapsed.TotalMilliseconds} miliseconds");
Console.WriteLine();

stopWatch.Reset();
stopWatch.Start();
dataStructureExamples.CreateDictionary(array);
stopWatch.Stop();

Console.WriteLine($"Dictionary was created in {stopWatch.Elapsed.TotalMilliseconds} miliseconds");

public class DataStructureExamples
{
    private Stack<int> _stack = new Stack<int>();
    private Queue<int> _queue = new Queue<int>();
    private LinkedList<int> _linkedList = new LinkedList<int>();
    private Dictionary<int, int> _dictionary = new Dictionary<int, int>();

    public void CreateStack(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            _stack.Push(array[index]);
        }
    }

    public void CleanStack()
    {
        while (_stack.Count != 0)
        {
            _stack.Pop();
        }
    }

    public void CreateQueue(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            _queue.Enqueue(array[index]);
        }
    }

    internal void CleanQueue()
    {
        while (_queue.Count != 0)
        {
            _queue.Dequeue();
        }
    }

    internal void CreateLinkedList(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            _linkedList.AddLast(array[index]);
        }
    }

    internal void CleanLinkeList()
    {
        while (_linkedList.Count != 0)
        {
            _linkedList.RemoveLast();
        }
    }

    internal void CreateDictionary(int[] array)
    {
        for (int index = 0; index < array.Length; index++)
        {
            _dictionary[index] = array[index];
        };
    }
}
