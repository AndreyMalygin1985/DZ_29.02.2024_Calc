class Calculator
{
    static void Main()
    {
        double num1, num2, result;
        char op;

        Console.WriteLine("Простой калькулятор");
        Console.Write("Введите первое число: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите оператор (+, -, *, /): ");
        op = Convert.ToChar(Console.ReadLine());

        Console.Write("Введите второе число: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль.");
                }
                break;
            default:
                Console.WriteLine("Некорректный оператор.");
                break;
        }
    }
}