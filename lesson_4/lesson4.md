# Lesson 4

### Datetime

Used for various things like birth dates

https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-8.0

```C#
// use the date time constructor to create differnt date time formats

DateTime dob = new DateTime(1990, 1, 10);

Console.WriteLine(dob);
// remember your string interpolations 
Console.WriteLine($"the day of dob is {dob.DayOfWeek}");

``````

Computing some datetime stuff

```C#
// Compute Datetime 
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
Console.WriteLine($"today is {today}");
Console.WriteLine($"time is {now}");
```
Date time parsing
```c#
//Datetime parsing
// local 
DateTime localDate = DateTime.Parse("09.21.1990");
// set date by region
DateTime usDate = DateTime.Parse("09/21/1990", new CultureInfo("en-US"));
Console.WriteLine($"local is {localDate}");
Console.WriteLine($"usDate is {usDate}");
```

Date time Formatting
```c#
//DateTime Formating
Console.WriteLine(dob.ToString());
Console.WriteLine(dob.ToString(new CultureInfo("en-US")));
Console.WriteLine(dob.ToString("yyyy-MM-dd")); 
```



----

## Operators
increase and decrease a value
```c#
Console.WriteLine("Increase and decrease");
int a = 5;
int b = a++;
Console.WriteLine($"a: {a}, b:{b} ");

int c = 3;
int d = --c;
Console.WriteLine($"c: {c}, d: {d}");

```

## regular math

```c#
Console.WriteLine("Regular Math");
int e = 2 + 7;
int f = 9 -3;
int g = 10 * 4;
int h = 16 / 2;


int i = 2 + 16 /2;
int j = (2+16) /2;
Console.WriteLine($" i:{i}, j:{j}");

```

## comparision operator
```c#
// Comparision Operator
Console.WriteLine("Comparison Operator");
int k = 17;
int l = 15;
Console.WriteLine(k > l);
Console.WriteLine(l > k);
Console.WriteLine(k >= l);
Console.WriteLine(l >= k);
```

## Boolean Logical Operator

```c#
// Boolean logical Operator
bool isRegister = false;
Console.WriteLine($"isRegistered: {isRegister}");
Console.WriteLine($"isRegistered NOT: {isRegister}");
```

## Equal Operators
```c#
Console.WriteLine("Equal Operator");
// Equal Operators
string name = "Jake";
string country = "US";
int luckyNum = 7;
Console.WriteLine(luckyNum !=5 );
Console.WriteLine(luckyNum == 7);
Console.WriteLine( name == country);
```