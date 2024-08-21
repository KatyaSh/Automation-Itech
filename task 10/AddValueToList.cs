using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AddValueToList
{
    public static LinkedList<int> AddedValuesToList(LinkedList<int> initialValuesList)
    {

        int firstItem = 2;
        int secondItem = 10;
        var currentNode = initialValuesList.First;
        while (currentNode != null)
        {
            if (currentNode.Value == firstItem)
            {
                initialValuesList.AddAfter(currentNode, secondItem);
            }

            currentNode = currentNode.Next;
        }
        return initialValuesList;
    }
}


