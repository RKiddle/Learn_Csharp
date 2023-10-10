// Coin toss program
// Author: Richard Kiddle   
// Date: 10/10/23
Random rand = new();
int coin_probabilty = rand.Next(0, 2);
string result = coin_probabilty >= 1 ? "heads" : "tails";
Console.WriteLine($"The coin landed on {result}");





