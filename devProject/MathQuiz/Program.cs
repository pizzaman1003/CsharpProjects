//I'll do division at some point. Also need to add a way to restart w/o terminating the program.
Random random = new Random();
int num1 = random.Next(0, 25);
int num2 = random.Next(0, 25);


Console.WriteLine("Welcome to the Math Quiz!");
Console.WriteLine("Select which operation you want to practice:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
int choice = Convert.ToInt32(Console.ReadLine());
int result;
switch (choice)
{
    case 1: Addition(num1, num2); 
    break;

    case 2: Subtraction(num1, num2);
    break;

    case 3: Multiplication(num1, num2);
    break;

}

int Addition(int num1, int num2)
{
    Console.WriteLine($"What is {num1} + {num2}?");
    int result = Convert.ToInt32(Console.ReadLine());
        if (result == num1 + num2)
        {
            Console.WriteLine("Correct!");

        }
        else
        {
            Console.WriteLine($"Incorrect. The correct answer was {num1 + num2}.");
        }
    return result;
}
int Subtraction(int num1, int num2)
{
    Console.WriteLine($"What is {num1} - {num2}?");
    int result = Convert.ToInt32(Console.ReadLine());
    if (result == num1 - num2)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine($"Incorrect. The correct answer was {num1 - num2}.");
    }
    return result;
}
int Multiplication(int num1, int num2)
{
    Console.WriteLine($"What is {num1} * {num2}?");
    int result = Convert.ToInt32(Console.ReadLine());
    
    
    if (result == num1 * num2)
    {
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine($"Incorrect. The correct answer was {num1 * num2}.");
    }
    return result;
}
