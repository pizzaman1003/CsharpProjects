//Calculator
//4 functions: + - * / = 4 switch cases for x and y
Console.WriteLine("To Use:");
Console.WriteLine("-Entry of Operands");
Console.WriteLine("-Selection of Operator");
Console.WriteLine("Press Enter to Continue");
Console.ReadLine();

Console.WriteLine("Enter your first number:");
decimal num1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter your second number:");
decimal num2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Select operation to be performed:");
Console.WriteLine("-Type 1 for Addition");
Console.WriteLine("-Type 2 for Subtraction");
Console.WriteLine("-Type 3 for Multiplication");
Console.WriteLine("-Type 4 for Division");

int choice = Convert.ToInt32(Console.ReadLine());
decimal result = 0;
switch (choice)
{
    case 1:
    result = Addition(num1, num2);
    break;

    case 2:
    result = Subtraction(num1, num2);
    break;

    case 3:
    result = Multiplication(num1, num2);
    break;

    case 4:
    result = Division(num1, num2);
    break;

    default:
    Console.WriteLine("You did not select an operation");
    break;
}

Console.WriteLine($"The result is: {result}");

decimal Addition(decimal num1, decimal num2)
{
    result = num1 + num2;
    return result;
}
decimal Subtraction(decimal num1, decimal num2)
{
    result = num1 - num2;
    return result;
}
decimal Multiplication(decimal num1, decimal num2)
{
    result = num1 * num2;
    return result;
}
decimal Division(decimal num1, decimal num2)
{
    if (num2 != 0)
    {
        result = num1 / num2;
        return result;
    }
    else
    {
        Console.WriteLine("You cannot divide by zero");
    }
    return 0;
}