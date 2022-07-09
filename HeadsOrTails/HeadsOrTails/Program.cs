using System;

namespace HeadsOrTails
{
  class Program {
    public static void Main(string[] args)
    {
      Random random = new Random();
      int headsNum = 0;
      int tailsNum = 0;

      Console.WriteLine("Tossing a coin...");
      for(int i = 1; i <= 3; i++)
      {
        int res = random.Next(2) % 2;
        String coin;
        if(res == 0)
        {
          coin = "Heads";
          headsNum++;
        }
        else
        {
          coin = "Tails";
          tailsNum++;
        }
        Console.WriteLine("Round{0}: " + coin, i);
      }
      Console.WriteLine("Heads: {0}, Tails: {1}", headsNum, tailsNum);
    }
  }
}