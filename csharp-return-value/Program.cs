Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50,101);


// output

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// You've already examined several topics in this unit. Here's a quick list of what you've covered:

// You've examined how to use a method's return value (when the method provides a return value).
// You've examined how a method can use input parameters that are defined as specific data types.
// You've examined the overloaded versions of some methods that include different input parameters or parameter types.