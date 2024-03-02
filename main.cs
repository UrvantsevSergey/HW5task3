              using System;

class Program 
{
  public static void Main (string[] args)
  {
    int[,] numbers = new int[,] {
        {1, 20, 3},
        {3, 4, 5},
        {6, 7, 8},
        {9, 10, 11}
    };
    int[] SumRows(int[,] array)
    {
      int[] mas = new int[array.GetLength(0)];
      for (int i = 0; i < array.GetLength(0); i++)
      {
        
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum = sum + array[i, j];
          mas[i] = sum;
        }
      }
      return mas;
    }

    
    
    int MinIndex(int[] array)
    {
      int minIndex = 0;
      int minValue = array[0];

      for (int i = 1; i < array.Length; i++)
      {
        if (array[i] < minValue)
        {
          minValue = array[i];
          minIndex = i;
        }
      }
      return minIndex;
    }

    void PrintResult(int[,] numbers)
    {
      int[,] num = numbers; Console.WriteLine(MinIndex(SumRows(num)));
    }
    PrintResult(numbers);
  }
}