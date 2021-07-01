using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    partial class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Reverse text"
                    + "\n6. Even recursion"
                    + "\n7. Fibonacci recursion"
                    + "\n8. Iteration even"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        ReverseText();
                        break;
                    case '6':
                        Even();
                        break;
                    case '7':
                        Fibonnaci();
                        break;
                    case '8':
                        IterationEven();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>

        public ListCapacityDelegate ListCapacity;

        static void ExamineList()
        {
            List<string> parts = new(); // Egen Enumerable?

            //public int Capacity { get; set; }
            //public delegate void Writer(string message);
            // Count is always less than the Capacity
            int listCapacity = parts.Capacity;
            //parts.ListCapacity = new ListCapacityDelegate();


            Console.WriteLine("ExamineList + to add item or - to remove item");
            Console.WriteLine("ExamineList q to quit. p to print current items.");
            Console.WriteLine($"list capacity is {parts.Capacity}");

            bool runLoop = true;
            do 
            {
                
                string input = Console.ReadLine();
                char first = input[0];

                switch (first)
                {
                    case '+':  // not " "
                        input = input.Remove(0, 1);
                        parts.Add(input);
                        // DELEGATE
                        // ListCapacity(listCapacity, value)
                        if (parts.Capacity != listCapacity)
                        { 
                            Console.WriteLine($"List capacity changed from {listCapacity} to {parts.Capacity}");
                            listCapacity = parts.Capacity;
                        }
                        break;
                    case '-':  // not " "
                        input = input.Remove(0, 1);
                        try
                        {
                            parts.Remove(input);
                            Console.WriteLine("item removed");
                            // ListCapacity(listCapacity, value)
                            if (parts.Capacity != listCapacity)
                            {
                                Console.WriteLine($"List capacity changed from {listCapacity} to {parts.Capacity}");
                                listCapacity = parts.Capacity;
                            }
                        }
                        finally
                        {
                            Console.WriteLine("item not in list");
                        }
                        break;
                    case 'q':
                    case 'Q': // OR condition
                        runLoop = false;
                        break;
                    case 'p':
                        foreach (var part in parts)
                        {
                            Console.WriteLine(part);
                        };
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                //Console.WriteLine(input);


            } while (runLoop);
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        /// 

        // Instantiate random number generator.  
        public static Random _random = new Random();

        // Generates a random number within a range.      
        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        private static IEnumerable<int> GetNumbersYield()
        {
            var i = 0;
            while (true)
            {
                yield return (i++); // Returns infinite numbers and adds to i

            }
        }

        //IEnumerable<int> GenerateWithYield()
        //{
        //    var i = 0;
        //    while (i < 5)
        //        yield return ++i;
        //}

        static void ExamineQueue() // Implementera metoden TestQueue. ??
        {

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            bool queueLoop = true;
            //List<T> colorOptions;
            //colorOptions = new List<T>();

            //var colorOptions = new List<string>();

            //List<IEnumerable> elements = new();
            List<int> elements = new();
            //elements.Add(1);

            do
            {
                Console.WriteLine("+ to Enqueue/Add to the ICA queue, - to Dequeue/remove");
                Console.WriteLine("ExamineList q to quit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "+":
                        //elements.Add(GetNumbersYield().Take(1)); Hard to print. Also not correct. Todo, how to operate generators in c#
                        elements.Add(RandomNumber(11, 100));
                        break;
                    case "-":
                        try
                        {
                            elements.RemoveAt(0);
                            break;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("No items to remove");
                            break;
                        }
                        
                        // EXCEPTION
                    case "q":
                    case "Q":
                        queueLoop = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.WriteLine();
                //The result of the Linq query is not a single Int value, but an IEnumerable.
                ////So you need to get a single value out of it, which in your case is the first value:
                elements.ForEach(i => Console.Write("{0},", i));
                Console.WriteLine();




            } while (queueLoop);



        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            bool stackBool = true;
            List<int> elements = new();
            elements.Add(10);
            do
            {
                Console.WriteLine("+ to Add to the ICA STACK, - to UNSTACK/remove last");
                Console.WriteLine("ExamineList q to quit");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "+":
                        elements.Add(RandomNumber(11, 100));
                        break;

                    case "-":
                        if (elements.Any()) //prevent IndexOutOfRangeException for empty list
                        {
                            elements.RemoveAt(elements.Count - 1);
                        }
                        else
                        {
                            Console.WriteLine("No items to remove");
                        }
                        break;
                    case "Q":
                    case "q":
                        stackBool = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input use +, - or q");
                        break;
                }
                Console.WriteLine();
                elements.ForEach(i => Console.Write("{0},", i));
                Console.WriteLine();



            } while (stackBool);
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }


        static void ReverseText()
        {
            string input;
            bool reverseTextBool = true;
            Stack st = new Stack();
            Stack rev = new Stack();
            do
            {
                Console.WriteLine("Enter text to reverse: ");
                input = Console.ReadLine();

                if (!(input is null))
                {
                    char[] array = input.ToCharArray();
                    Array.Reverse(array);
                    foreach (var item in array)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Please enter a String");
                }


                // _ = input ?? throw new ArgumentNullException(nameof(name));


            } while (reverseTextBool);

                //Stack_Array stk1 = newStack_Array(str.Length);
                //foreach (charc in str)
                //    stk1.Push(c);
                //string revString = null;
                //foreach (charc in str)
                //    revString += stk1.Pop();



        }

        static void CheckParanthesis()
        {
            string exampelOne = "new List<int>() { 1, 2, 3, 4 }";
            string exampelTwo = "new List<int>() { 1, 2, 3, 4 )";


            Console.WriteLine($"{ exampelOne} is {CheckParentesis(exampelOne)}");
            Console.WriteLine($"{ exampelTwo} is {CheckParentesis(exampelTwo)}");

            List<string> list = new List<string>() { "(())", "{ }", "[({ })]", "(()])", "[)", "{[()}]" };

            foreach (var item in list)
            {
                Console.WriteLine($"{ item} is {CheckParentesis(item)}");
            }

            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }
        static void Even()
        {
            int number;

            Console.WriteLine("Please enter an even number like 2 or 4.");
            string value = Console.ReadLine();

            bool success = Int32.TryParse(value, out number);
            bool isEven = number % 2 == 0;
            if (success & isEven)
            {
                Console.WriteLine("Converted '{0}' to {1}.", value, number);

                Console.WriteLine($"The {number}th even number is: {RecursiveEven(number)-2}");
            }
            else
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   value ?? "<null>");
            }

        }

        static void Fibonnaci()
        {
            int number;

            Console.WriteLine("Please enter a number less than 20.");
            string value = Console.ReadLine();

            bool success = Int32.TryParse(value, out number);
            bool isEven = number % 2 == 0;
            bool isLessThanTwetenty = number < 20;
            if (success & isEven & isLessThanTwetenty)
            {
                Console.WriteLine("Converted '{0}' to {1}.", value, number);

                Console.WriteLine($"The {number}th Fibonacci number is: {GetNthFibonacci_Rec(number)}");
            }
            else
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   value ?? "<null>");
            }
        }

        static void IterationEven()
        {
            {
                int number;

                Console.WriteLine("Please enter a number like 1 or 4.");
                string value = Console.ReadLine();

                bool success = Int32.TryParse(value, out number);
                if (success)
                {
                    Console.WriteLine("Converted '{0}' to {1}.", value, number);

                    Console.WriteLine($"The {number}st/rd/th even number is: {IterativeEven(number-2)}");
                }
                else
                {
                    Console.WriteLine("Attempted conversion of '{0}' failed.",
                                       value ?? "<null>");
                }

            }



        }

        /// <summary>
        /// Returns even iterations of a number.
        /// </summary>
        public static int IterativeEven(int n)
        {

            if (n == 0)
            {
                return 2;
            }

            int result = 2;

            for (int i = 0; i <= n; i++)
            {
                result += 2;
            }
            return result;

        }









        public static bool CheckParentesis(String str)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < str.Count(); i++)
            {
                char current = str[i];
                if (current == '{' || current == '(' || current == '[') // isin {,(,[ membership
                {
                    stack.Push(current);
                    continue; // start next iteration
                }

                if (current == '}' || current == ')' || current == ']')
                {
                    if (stack.Count == 0) // no left part
                        return false;

                    char last = stack.Peek();
                    if (current == '}' && last == '{' || current == ')' && last == '(' || current == ']' && last == '[')
                        stack.Pop();
                    else
                        return false;
                }

            }

            return (stack.Count == 0);
        }


        public static int RecursiveEven(int n)
        {
            if (n==0)
            {
                return 2;
            }
            
            return (RecursiveEven(n-1) +2);
        }

        //MEMOIZATION IS A GOOD IDEA HERE.
        public static int GetNthFibonacci_Rec(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return (GetNthFibonacci_Rec(n - 1) + GetNthFibonacci_Rec(n - 2));
        }




    }

}

