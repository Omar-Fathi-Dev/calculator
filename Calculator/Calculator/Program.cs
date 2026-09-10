namespace Calculator;

class Program
{
    static void Main(string[] args)
    {

        double number1 ,number2;
        string operation , choice;

        while (true)
        {
            number1 = ValidateInput("number 1");
            number2 = ValidateInput("number 2");
            operation = ValidateOperation();
        
            if (operation == "+")
                Console.WriteLine($"{number1} + {number2} = {AddTwoNumbers(number1, number2)}");
            else if (operation == "-")
                Console.WriteLine($"{number1} - {number2} = {SubtractTwoNumbers(number1, number2)}");
            else if (operation == "*")
                Console.WriteLine($"{number1} * {number2} = {MultiplyTwoNumbers(number1, number2)}");
            else if (operation == "/")
                Console.WriteLine($"{number1} / {number2} = {DivideTwoNumbers(number1, number2)}");
            
            Console.WriteLine("Do you want to perform another calculation?");
            Console.WriteLine("Press any key to continue, or 'N' to exit."); 
            choice = Console.ReadLine();
            if (choice == "N" ||  choice == "n")
                break;
        }
        
        
        


    }
    
    static double DivideTwoNumbers(double number1 , double number2)
    {
        if(number2 == 0)
        Console.WriteLine("Cannot divide by zero. Please enter a non-zero number.");
        return number1 / number2;
    }
    
    
    
    static double MultiplyTwoNumbers(double number1 , double number2)
    {
        return number1 * number2;
    }
    
    static double SubtractTwoNumbers(double number1 , double number2)
    {
        return number1 - number2;
    }

    static double AddTwoNumbers(double number1 , double number2)
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