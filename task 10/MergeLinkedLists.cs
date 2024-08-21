using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

public class MergeLinkedLists
{
    public static LinkedList<int> MergedLists(LinkedList<int> list1, LinkedList<int> list2)
    {
        LinkedList<int> result = new LinkedList<int>();
        var currentNode1 = list1.First;
        
        while (currentNode1 != null)
        {
            var currentNode2 = list2.First;
            while (currentNode2 != null)
            {
                if (currentNode1.Value == currentNode2.Value)
                {
                    result.AddLast(currentNode2.Value);                   
                }

                currentNode2 = currentNode2.Next;
            }

            currentNode1 = currentNode1.Next;
        }

        return result;
    }
}



