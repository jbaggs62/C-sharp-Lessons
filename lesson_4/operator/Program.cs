// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arithmetic Operators");

Console.WriteLine("Increase and decrease");
int a = 5;
Console.WriteLine($"a: {a}, b:{++a},");


int c = 3;
Console.WriteLine($"c: {c}, d: {--c}");

Console.WriteLine("Regular Math");
int e = 2 + 7;
int f = 9 - 3;
int g = 12 * 4;
int h = 9 / 3;

Console.WriteLine($"e: {e}, f: {f}, g: {g}, h: {h}");


int i = 2 + 16 / 2;
int j = (2 + 16) / 2;
Console.WriteLine($" i:{i}, j:{j}");



// Comparision Operator
Console.WriteLine("Comparison Operator");
int k = 17;
int l = 15;
Console.WriteLine(k > l);
Console.WriteLine(l > k);
Console.WriteLine(k >= l);
Console.WriteLine(l >= k);

// Boolean logical Operator
Console.WriteLine("Boolean Logical Operator");

bool isRegister = false;
Console.WriteLine($"isRegistered: {isRegister}");
Console.WriteLine($"isRegistered NOT: {isRegister}");

Console.WriteLine("Equal Operator");
// Equal Operators
string name = "Jake";
string country = "US";
int luckyNum = 7;
Console.WriteLine(luckyNum != 5);
Console.WriteLine(luckyNum == 7);
Console.WriteLine(name == country);
Console.WriteLine(name.Length == country.Length);
