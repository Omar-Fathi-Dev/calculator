namespace Calculator;

class Program
{
    static void Main(string[] args)
    {

        

    }
    
    static double DivideToNumbers(double number1 , double number2)
    {
        return number1 / number2;
    }
    
    static double MultiplyToNumbers(double number1 , double number2)
    {
        return number1 * number2;
    }
    
    static double SubtractToNumbers(double number1 , double number2)
    {
        return number1 - number2;
    }

    static double AddToNumbers(double number1 , double number2)
    {
        return number1 + number2;
    }

    static string ValidateOperation()
    {
        string operation;
        while (true)
        {
            Console.WriteLine("Enter the operation (+, -, *, /):");
            operation = Console.ReadLine();
            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                return operation;
        }

    }
    
    static double ValidateInput(string str)
    {
        
        string input = "";
        bool flag = true;
        double number;
        while (true)
        {
            Console.Write($"Please enter a {str}: ");
            input = Console.ReadLine();
            flag= double.TryParse(input, out number);
            if (flag)
                break;
        }
        
        return number;
    }
    
}