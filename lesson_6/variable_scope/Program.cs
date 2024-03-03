// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

Console.WriteLine("What is your age?");
string? input = Console.ReadLine();


int age = int.Parse(input);
if (age >= 27 && age <= 43){
    // int age = 55 // will error out because already declared outside of this scope
    string generation = "Millenial";
    Console.WriteLine($"You're a {generation} because you are {age} years old");
}

else if( age < 27) {
    string generation = "Zoomer";
    Console.WriteLine($"Go away {generation}");
}

else{
    string generation = "Boomer";
    Console.WriteLine($"Okay {generation}");
;}



// cannot use geneartion outside of scopes because its defined in scope
// Console.WriteLine(geneation);

// Console.WriteLine("For Loop Example");
// // for (int i =0; i< 10; i++){
// //     Console.WriteLine(i);

// // }

// //Console.WriteLine(i) doesn't work because I was scope for the loop