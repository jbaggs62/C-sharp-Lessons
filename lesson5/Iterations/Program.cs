// while loop

// base case
int a = 2;
// test case
while (a < 5)
{
    // this is the logic that happens while looping
    Console.WriteLine($"while: {a}");
    a++;
}

// do-while
// base case
int b = 1;

do
{
    // the actual doing of something
    Console.WriteLine($"do-while: {b}");
    b++;
}
// test case 
while (b < 4);


// for loop 

// for (logic: base case, test case, iterator)
for (int i = 1; i < 5; i++){
    Console.WriteLine($"for loop: {i}");

}

// for each
List<int> fibNumbers = [0, 1, 1, 2, 3, 5, 8, 13,21,34,55];
foreach (int element in fibNumbers)
{
    Console.WriteLine($"the fib element is: {element} ");
}