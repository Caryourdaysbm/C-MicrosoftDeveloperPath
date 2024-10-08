bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}


// Variable scope Challenge
int[] numbers = { 4, 8, 15, 16, 23, 42 };

int total = 0;
foreach (int number in numbers)
{
    

    total += number;

    if (number == 42)
    {
       bool found = true;
       if (found) 
{
    Console.WriteLine("Set contains 42");

}

    }

}



Console.WriteLine($"Total: {total}");