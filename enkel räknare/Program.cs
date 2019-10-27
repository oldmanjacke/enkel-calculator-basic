﻿using System;

namespace enkel_räknare
{
    class Program
    {
        public string ConsolePrompt;
     
        static void Main(string[] args)
        {

            {
                double firstNum;
                double secondNum;                   //Variables for equation
                string operation;
                double answer;




                Console.WriteLine("Hello, welcome  basic calculator!");
                Console.ReadLine();

                Console.Write("Enter the first number in your basic equation: ");
                firstNum = Convert.ToInt32(Console.ReadLine());

                //User input for equation
                Console.Write("Now enter your second number in the basic equation: ");
                secondNum = Convert.ToInt32(Console.ReadLine()); //något fel här med input
                Console.Write("Ok now enter your operation ( x , / , +, -) ");
                operation = Console.ReadLine();

                var operations = new Dictionary<string, Func<int, int, int>>
                {
                    { "x", (x, y) => x * y }
                    { "x", (x, y) => x / y }
                    { "x", (x, y) => x + y }
                    { "x", (x, y) => x - y }

                };
            }
            var prompter = new ConsolePrompt(null);
            var valdidoperations = new[] { "x", "/", "+", "-" };
            var firstNum = prompter.Prompt<int>("enter first number", PromptOptions.Required);
            var secoundNum = prompter.Prompt<int>("enter your operation", PromptOptions.Required);
            var operation = prompter.Prompt<string>("enter your secound number(" + string.Join(",", valdidoperations) + ")", PromptOptions.Required, validationMethod: x => valdidoperations.Contains(x));

            switch (operation)
                {

                
                
                    case "x":
                    answer = firstNum * secondNum;
                   
                        break; 
                
                   case "/":
                
                    answer = firstNum / secondNum;
                    
                    break;

                    //tanken är att personen ska skriva in sina siffror och ska det sen i slut ändan visas som typ 5x2=10
                    case "+":
                
                    answer = firstNum + secondNum;
                    
                 break;

                    case "-":
                
                    answer = firstNum - secondNum;
                    
                    break; 
                
                  
                
                
                    Console.WriteLine("Sorry that is not correct format! Please restart!");     //Catch
                    Console.ReadLine();
                        
                }
            }
        }
    }

}
    

