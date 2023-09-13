Console.WriteLine("Calculator");
Console.WriteLine("___________");

Console.Write("\nNumber 1: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\nNumber 2: ");

int number2 = Convert.ToInt32(Console.ReadLine());


Console.Write("\nOperation (+ - / *): ");

string operation = Console.ReadLine();

switch(operation){
    case "+":
        Console.WriteLine("\nResult: " + (number1 + number2));
        break;
    case "-":
        Console.WriteLine("\nResult: " + (number1 - number2));
        break;
    case "/":
        Console.WriteLine("\nResult: " + (number1 / number2));
        break;
    case "*":
        Console.WriteLine("\nResult: " + (number1 * number2));
        break;
}