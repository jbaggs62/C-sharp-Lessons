
// use switch statements for big if else clauses
Console.WriteLine("Enter your age");
string? input = Console.ReadLine();
int age = int.Parse(input);

switch (age)
{
 case < 13:
    Console.WriteLine("You are a child");
    break;
 case < 18:
    Console.WriteLine("You are teenager");
    break;
 case < 21:
    Console.WriteLine("You cannot drink");
    break;
 case >= 30:
    Console.WriteLine("You are old");
    break;
 // what your program will return if you don't handle it another case   
 default:
  Console.WriteLine("Every birthday is a blessing");
  break;
}