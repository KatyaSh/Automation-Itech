﻿public class EvenNumbersSum
{
    public static int Sum(List<int> numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
                       
        }

        return sum;
    }
}