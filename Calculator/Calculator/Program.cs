namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        
    }
    
    static double validateInput(string str)
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