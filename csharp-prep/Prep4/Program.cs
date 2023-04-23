using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Please enter a list of integers, including positive and negative numbers. Input 0 when you are done.");
    int number = -1;
    List<int> listOfNumbers = new List<int>();
    int sum = 0;
    int average = 0;
    // int smallestPosNum = -1;

    while (number != 0)
    {
      Console.Write("Enter a number: ");
      number = int.Parse(Console.ReadLine());
      listOfNumbers.Add(number);
    }
    for (int i = 0; i < listOfNumbers.Count; i++)
    {
      sum = sum + listOfNumbers[i];
      average = sum / ((listOfNumbers.Count) - 1);
      // THROWS AN EXCEPTION WHEN listOfNumbers[i] equals a negative number
      //   if (listOfNumbers[i] > 0 && listOfNumbers[i] < listOfNumbers[i - 1])
      //   {
      //     smallestPosNum = listOfNumbers[i];
      //   }
    }
    Console.WriteLine($"The sum of the number list is: {sum}");
    Console.WriteLine($"The average of the number list is: {average}");
    int max = listOfNumbers.Max();
    Console.WriteLine($"The largest number in the list is: {max}");
    listOfNumbers.Sort();
    Console.WriteLine("The sorted list is: ");
    foreach (int num in listOfNumbers)
    {
      Console.WriteLine(num);
    }
    // Console.WriteLine($"The smallest positive number in the list is: {smallestPosNum}");
  }
}