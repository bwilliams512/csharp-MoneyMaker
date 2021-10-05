/*
This project uses C# to build a Money Maker: 
a program in which a user enters an amount and gets the minimum number of coins that equal that value.

You have three types of coins:
A bronze coin is worth 1 cent
A silver coin is worth 5 cents
A gold coin is worth 10 cents

For example, 16 cents could be:
16 bronze coins,
3 silver coins and 1 bronze coin, or
1 gold coin, 1 silver coin, 1 bronze coin
*/

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      // Ask user for amount to convert
      Console.WriteLine("Enter an amount to convert to coins:");
      string conversionAmtString = Console.ReadLine();

      // Convert the captured string value to a number
      double conversionAmtDouble = Convert.ToDouble(conversionAmtString);

      // Let the user know what happens next
      Console.WriteLine($"{conversionAmtDouble} cents is equal to...");

      // We need to know the value of each type of coin
      // Define two cariable that hold those values
      int goldValue = 10;
      int silverValue = 5;
      
      // Define maximum number of gold coins that fit into the amount
      double goldCoins = Math.Floor(conversionAmtDouble / goldValue);
      
      // Find the remainder
      double leftOver = (conversionAmtDouble % goldValue);
      
      // Define maximum number of silver coins that fit into the remainder
      double silverCoins = Math.Floor(leftOver / silverValue);

      // Find the adjusted remainder
      leftOver = Math.Floor(leftOver % silverValue);
      
      // Print out all of the coins
      Console.WriteLine($"Gold coins: {goldCoins}\nSilver coins: {silverCoins}\nBronze coins: {leftOver}");

    }
  }
}
