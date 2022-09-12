namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userConsent = true;

            while (userConsent) ;
            {
                double num1 = 0;  //Sets the variable num1 to 0//
                double num2 = 0;  //Sets the variable num2 to 0//
                double result = 0;  //Sets the variable result to 0//

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());  //Converts the string the use inputted above to a double and sets it a num1//

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());  //Converts the string the use inputted above to a double and sets it a num2// 

                Console.WriteLine("What do you want to do to these two numbers?: ");
                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Subtract");
                Console.WriteLine("* : Times");
                Console.WriteLine("/ : Divide");

                switch (Console.ReadLine())  //Starts a switch and reads the inputted line above//
                {
                    case "+":  //If the users input was + then it does the code indented below//
                        result = num1 + num2;  //Adds num1 and num2//
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;  //Exits the switch loop//

                    case "-":  //If the users input was - then it does the code indented below//
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;  //Exits the switch loop//

                    case "*":  //If the users input was * then it does the code indented below//
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;  //Exits the switch loop//

                    case "/":  //If the users input was / then it does the code indented below//
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        break;  //Exits the switch loop//

                    default:  //This is the default code that will run if none of the other conditions are met//
                        Console.WriteLine("That's not an option");
                        break;  //Exits the switch loop//
                }
                Console.WriteLine("Would you like to do it again? (Y/N): ");
                string userInput = Console.ReadLine();
                userInput.ToUpper();

                if (userInput == "Y")
                {
                    userConsent = true;
                }
                else if (userInput == "N")
                {
                    userConsent = false;
                }
            }
        }
    }
}