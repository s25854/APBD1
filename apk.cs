using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        double average = CalculateAverage(numbers);
        Console.WriteLine("Average: " + average);
        int max = FindMaxValue(numbers);
        Console.WriteLine("Max value: " + max);
    }


    public static double CalculateAverage(int[] numbers){
        if (numbers == null || numbers.Length == 0){
            throw new ArgumentException("Array cannot be null or empty.");
        }

        int sum = 0;
        foreach (int num in TabNumber){
            sum += num;
        }

        return (double)sum / TabNumber.Length;
    }
    
    public static int FindMaxValue(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }
    
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
    
            return max;
        }
}
