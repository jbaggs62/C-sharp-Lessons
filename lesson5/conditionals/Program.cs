// See https://aka.ms/new-console-template for more information
// if statements

int y = 16;

if (y == 16) {
    Console.WriteLine("the number is 16!");

}

// if else statements

if (y < 16){
    Console.WriteLine("Your number is lower than 16");
}
else{
    Console.WriteLine("Your number is higher than or equal to 16");
}

// chaining if else - else

string name = "James";
if (name == "Jake"){
    Console.WriteLine("Hi, the name is Jake");
}
else if (name == "John"){
    Console.WriteLine("The name is John");
}

else {
    Console.WriteLine("Name is Unknown");
}

// Ternary conditional operator - short hand if else statements

//base case
int x = 4;
// new variable, equal to old variable, output based on value of old variable

string z = x == 4? "4.0" : "3.0";
Console.WriteLine(z);



