// See https://aka.ms/new-console-template for more information
using System.Globalization;

DateTime dob = new DateTime(1990, 1, 10);
Console.WriteLine(dob);
Console.WriteLine($"the day of dob is {dob.DayOfWeek}");
// Compute Datetime 
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
Console.WriteLine($"today is {today}");
Console.WriteLine($"time is {now}");

//Datetime parsing
// local 
DateTime localDate = DateTime.Parse("09.21.1990");
// set date by region
DateTime usDate = DateTime.Parse("09/21/1990", new CultureInfo("en-US"));

Console.WriteLine($"local is {localDate}");
Console.WriteLine($"usDate is {usDate}");


//DateTime Formating

Console.WriteLine(dob.ToString());
Console.WriteLine(dob.ToString(new CultureInfo("es-ES")));
Console.WriteLine(dob.ToString("yyyy-MM-dd"));
