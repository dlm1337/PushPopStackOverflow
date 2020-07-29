using System;
namespace PushPopStackOverflow
{
    public class UserInput
        {

        public void Input()
        {
            var stack = new Stack();
            Console.WriteLine("Type ! to see the stack so far. type @ to remove an item from the stack. ");
            Console.WriteLine("type what you wish to add to the stack otherwise. type # to clear the list. type $ to exit.");
            do
            {

                Console.WriteLine("Go ahead and type something:");
                string userInput = Console.ReadLine();
                if (userInput != "!" && userInput != "@" && userInput != "#")
                {
                    stack.Push(userInput);

                }
                if (userInput == "!")
                {
                    foreach (var item in stack.PushPopList())
                    {
                        Console.WriteLine(item);
                    }

                }
                if (userInput == "@")
                {
                    try
                    {
                        Console.WriteLine(stack.Pop() + " , this was removed from the stack.");
                    }
                       
                      catch
                    {
                        Console.WriteLine("There is nothing in the stack.");
                             var input = new UserInput();
                             input.Input();
                    }

                }
                if (userInput == "#")
                {
                    stack.Clear();
                }
                if (userInput == "$")
                {
                    Environment.Exit(0);
                }
               
            } while (true);
        }

        }
}
