// See https://aka.ms/new-console-template for more information

//ints

int a = 0;
int b = 2;
int c = -1;

// basic math with ints

int add = b + a;
Console.WriteLine($"result of a + b = {add}");
int sub =  c - b ;
Console.WriteLine($"result of c-b = {sub}");
int multi = a * b;
Console.WriteLine($"result of a * b = {multi}");
int divide = b / c;
Console.WriteLine($"result of b/c = {divide}");


// floats

float f = 3.5f;
Console.WriteLine($"f = {f}");
double g = 7.8d;
Console.WriteLine($"g = {g}");
decimal dec = 7.15m;
Console.WriteLine($"dec = {dec}");

// float maths & precisions when decimals points matters

Console.WriteLine($"float precision is seven digits: {1.2345678f/0.98765432f}");
Console.WriteLine($"float precision is seven digits: {1.2345678d/0.98765432d}");
Console.WriteLine($"float precision is seven digits: {1.2345678m/0.98765432m}");

// characters
char c1 = 'a';
Console.WriteLine($"char: {c1}");

// create a bool & set bools

bool enabled = false;
Console.WriteLine($"bool: {enabled}");

enabled = true;
Console.WriteLine($"bool: {enabled}");

// null value types ?  allows us to make value nullable
// all types in this program are nullable

int? i1 = null;
bool? b1 = null;


