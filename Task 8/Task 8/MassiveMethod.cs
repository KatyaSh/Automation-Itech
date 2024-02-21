using System;

public class MassiveMethod

{
    public MassiveMethod()
    {
    }

    public static void ShowMassiveElements()
    {
        try
        {
            int[] massive = { 8, 7, 1, 4, 2 };
            Console.WriteLine("Input index of element in massive:");
            string? inputedValue = Console.ReadLine();
            string? checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;
            int inputtedNumber = Int32.Parse(checkedValue);
            int massiveElement = massive[inputtedNumber];
            Console.WriteLine($"Massive element that has index {inputedValue} has value {massiveElement}");
        }

        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Возникло исключение : {ex.Message}");
            Console.WriteLine(ex);
        }

        catch (FormatException ex)
        {
            Console.WriteLine($"Возникло исключение : {ex.Message}");
            Console.WriteLine(ex);
        }

        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Возникло исключение IndexOutOfRangeException");
            Console.WriteLine(ex);
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Исключение: {ex.Message}");
            Console.WriteLine(ex);
        }

    }

}