Console.WriteLine("Please add a whole number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please add another whole number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int addTotal = num1 + num2;
int subtractTotal = num1 - num2;
int multipliedTotal = num1 * num2;
int divideTotal = num1 / num2;

Console.WriteLine(addTotal);
Console.WriteLine(subtractTotal);
Console.WriteLine(multipliedTotal);
Console.WriteLine(divideTotal);
