//Target framework: .NET 7.0

//Functions

// Factoriel ! function
double Factorial(double x)
{
    double i, factorial = 1;

    for (i = 1; i <= x; i++)
        factorial *= i;

    return factorial;
}

// Minimum function
static double Minimum(double x, double y)
{
    double min;

    if (x < y)
        min = x;
    else
        min = y;

    return min;
}

// Power function
static double Power(double x, double y)
{
    if (y == 0)
        return 1;
    else
        return x * Power(x, y - 1);
}

double x, y;
string operation = "";

// Getting value x from user and controling it.
while (true)
{
    Console.Write("Give a number for x between 2 and 50: ");
    var input = Console.ReadLine();
    if (double.TryParse(input, out x) && x >= 2 && x <= 50)
        break;
    else
        Console.Write("Your entry is invalid. Try again!\n");
}

// Getting value y from user and controling it.
while (true)
{
    Console.Write("Give a number for y between 25 and 30: ");
    var input = Console.ReadLine();
    if (double.TryParse(input, out y) && y >= 25 && y <= 30)
        break;
    else
        Console.Write("Your entry is invalid. Try again!\n");
}

// Getting type of the operator from user and controling it.
while (true)
{
    Console.Write("choose a operation between '+' and '*': ");
    operation = Console.ReadLine();
    if (operation == "*" || operation == "+")
        break;
    else
        Console.Write("Your entry is invalid. Try again!\n");
}

// First term
double mathFormulaAddition = Minimum(((2 * x) + (5 * x)), Factorial(y)) / (Power(1, 1) + Power(3, 1));

double mathFormulaMultiply = Minimum(((2 * x) * (5 * x)), Factorial(y)) / (Power(1, 1) + Power(3, 1));

double divide = 0.0;

// selecting users operator.
switch (operation)
{
    case "+":
        for (int i = 2, j = 5, k = 1; i <= 25; i++, j += 3, k += 1) // 24 term, Power, k for Factorial
        {
            for (int l = 2 * 1 - 1; l <= 4 * i - 1; l += 2)
                divide += Power(l, i);

            double result = Minimum((j * x) + ((j + 3) * x), Factorial(y - k)) / divide;

            // -/+
            if (i % 2 == 0)
                // positive
                mathFormulaAddition += result;
            else
                // negative
                mathFormulaAddition -= result;
        }
        Console.WriteLine("The Result is: " + mathFormulaAddition);
        break;

    case "*":
        for (int i = 2,j = 5, k = 1; i <= 25; i++, j += 3, k += 1) // 24 term, Power k for Factorial
        {
            for (int l = 2 * 1 - 1; l <= 4 * i - 1; l += 2)
                divide += Power(l, i);

            double result = (Minimum((j * x) * ((j + 3) * x), Factorial(y - k)) / divide);

            // -/+
            if (i % 2 == 0)
                // positive
                mathFormulaMultiply += result;
            else
                // negative
                mathFormulaMultiply -= result;

        }
        Console.WriteLine("The Result is: " + mathFormulaMultiply);
        break;
}
Console.ReadLine();