//Implict Conversion: No special syntax no data loss no precision loss
// Explicit conversions: Castings potential data loss, pootential precision loss

int age = 31;
float weight = 78.7f;


Console.WriteLine($"age: {age}, weight: {weight}");

//implicit type casting

long myAge = age;
Console.WriteLine(myAge);

//explicit conversions

int lessWeight = (int)weight; // precision loss
int notMyAge = (int)myAge; // no precission loss

Console.WriteLine($"age: {notMyAge}. weight: {lessWeight}");

// values don't fit if converted
long bigNumber = 9223372036854775807;
int smallType = (int)bigNumber;
Console.WriteLine(smallType);


/// strings
string message = "Hello World";
Console.WriteLine(message);

//empty string
string emptyMess = string.Empty;
Console.WriteLine(emptyMess);

// example of using escape characters
string FilePath = "C:\\temp";
Console.WriteLine(FilePath);

// right way to do file paths
string FilePath2 = @"C:\temp";
Console.WriteLine(FilePath2);

// string concentation
string firstName = "Jake";
string lastName = "Baggs";

string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);


//string length
Console.WriteLine(FilePath.Length);


// string interpolation
string fullName2 = $"{firstName} {lastName}";
Console.WriteLine(fullName2);


// substrings

string first3char = fullName.Substring(0,3);
Console.WriteLine(first3char);

// string parsing
string luckyNum = "16";
int parseLuckyNum = int.Parse(luckyNum);
Console.WriteLine(parseLuckyNum);
double temperature = double.Parse("30.7");
Console.WriteLine(temperature);

