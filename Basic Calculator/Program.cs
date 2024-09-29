Console.WriteLine("BASIC CALCULATOR by Christine Arroyo");
Console.Write("Choose an Operations: 1 - Addition, 2 - Subtraction, 3 - Multiplication, 4 - Division ");
Console.WriteLine(" ");
Console.Write("Enter your chosen Operation: ");
string operation = Console.ReadLine();

Console.WriteLine("Enter the First Number:");
int Num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the Second Number:");
int Num2 = int.Parse(Console.ReadLine());

if (operation == "1")
    {
        int result = Num1 + Num2;
        Console.WriteLine("Result: " + result + " is the answer");
        Console.ReadLine();
    }
else if (operation == "2")
    {
        int result = Num1 - Num2;
        Console.WriteLine("Result: " + result + " is the answer");
        Console.ReadLine();
}
else if (operation == "3")
    {
        int result = Num1 * Num2;
        Console.WriteLine("Result: " + result + " is the answer");
        Console.ReadLine();
}
else if (operation == "4")
    {
        int result = Num1 / Num2;
        Console.WriteLine("Result: " + result + " is the answer");
        Console.ReadLine();
    }





