using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class QueueMethods
{
    public static Queue<int> SwapFirstAndLastMethod(Queue<int> queue)
    {
        var first = queue.Dequeue();
        List<int> elements = new List<int>();
        while (queue.Count > 1)
        {
            elements.Add(queue.Dequeue());
        }

        var last = queue.Dequeue();
        queue.Enqueue(last);

        foreach (var item in elements)
        {
            queue.Enqueue(item);
        }

        queue.Enqueue(first);

        return queue;
    }

    public static Queue<int>  ReverseQueue(Queue<int> queue)
    {
        
        int count = queue.Count;
        for (int i = 0; i < count; i++)
        {            
            var item = queue.Last();
            
        }

       // queue.Enqueue(first);

        return queue;
    }
}