

using ConsoleUI;

double x = RequestData.GetADouble("Please enter your first number: ");
double y = RequestData.GetADouble("Please enter your second number: ");

double resultAdd = CalculateData.Add(x, y);
double resultSubtract = CalculateData.Subtract(x, y);
double resultMultiply = CalculateData.Multiply(x, y);
double resultDivide = CalculateData.Divide(x, y);

Console.WriteLine($"The sum of {x} and {y} is {resultAdd}.");
Console.WriteLine($"The subtraction of {x} and {y} is {resultSubtract}.");
Console.WriteLine($"The multiplication of {x} and {y} is {resultMultiply}.");
Console.WriteLine($"The divide of {x} and {y} is {resultDivide}.");

Console.ReadLine();