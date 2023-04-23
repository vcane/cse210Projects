using System;

class Program
{
  static void Main(string[] args)
  {
    string play = "yes";

    while (play == "yes")
    {
      Random randomNum = new Random();
      int magicNum = randomNum.Next(1, 101);
      int guessNum;
      int counter = 0;
      Console.WriteLine(magicNum);
      do
      {
        counter++;
        Console.Write("Please enter an integer 1-100: ");
        string guess = Console.ReadLine();
        guessNum = int.Parse(guess);

        if (magicNum < guessNum)
        {
          Console.WriteLine("Your guess is too high!");
        }
        else if (magicNum > guessNum)
        {
          Console.WriteLine("Your guess is too low!");
        }
        else
        {
          Console.WriteLine($"Congratulations, {guessNum} was the correct number!.");
          if (counter == 1)
          {
            Console.WriteLine($"It took {counter} attempt.");
          }
          else
          {
            Console.WriteLine($"It took {counter} attempts.");
          }
        }

      } while (guessNum != magicNum);
      Console.Write("Would you like to play again? ");
      play = Console.ReadLine();
    }
    Console.WriteLine("Come play again sometime!");
  }
}