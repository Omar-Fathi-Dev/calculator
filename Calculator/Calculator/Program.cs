namespace Calculator;

class Program
{
    static void Main(string[] args)
    {

        string operation = ValidateOperation();
        Console.WriteLine(operation);

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