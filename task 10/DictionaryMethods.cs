using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DictionaryMethods
{
    public static Dictionary<int, string> SortAndMergeLists(List<int> intList, List<string> stringList)
    {
        intList.Sort();
        stringList.Sort();
        stringList.Reverse();
        Dictionary<int, string> mergedDictionary = new Dictionary<int, string>();
       
        for (int i = 0; i < intList.Count; i++)
        {
            mergedDictionary.Add(intList[i], stringList[i]);
        }

        return mergedDictionary;
    }

}

