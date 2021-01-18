using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPOC1
{

    class Program 
    {
        static void Main(string[] args)
        {
            CSharpPOC1QS obj = new CSharpPOC1QS();
            Console.WriteLine("List of Solutions\n");
            Console.WriteLine("1. Fibonacci Series till 50.\n2. Consecutive 1's in Binary Equivalent.\n3. Sorted Array\n4. Reverse of String\n5. Swapping Values\n6. Palindrome\n7. ASCII value of all Alphabets\n8. Armstrong Number ");
            var flag = false;
            do
            {
                Console.WriteLine("\nPlease Select the Solution You want to see\n");
                Console.Write("Solution Number: ");
                var solution = Convert.ToInt32(Console.ReadLine());
                switch (solution)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine(obj.fibTillFifty());
                            flag = true;
                            break;
                        }
                    case 2:
                        {
                            Console.Write("\nEnter a Number: ");
                            var input = Console.ReadLine();
                            obj.consecutiveones(input);
                            flag = true;
                            break;
                        }
                    case 3:
                        {
                            var numArray = new int[] { 5, 4, 3, 2, 1, 6, 7, 8, 9, 10 };

                            Console.WriteLine("\nThe Numbers in the Array");
                            Console.WriteLine(string.Join(",", numArray));
                            Console.WriteLine();

                            Console.WriteLine("The Array in Ascending Order");
                            obj.ascending(numArray);
                            Console.WriteLine(string.Join(",", numArray));
                            Console.WriteLine();

                            Console.WriteLine("The Array in Descending Order");
                            obj.descending(numArray);
                            Console.WriteLine(string.Join(",", numArray));
                            Console.WriteLine();
                            flag = true;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nEnter the String");
                            Console.Write("String: ");
                            var input = Console.ReadLine();

                            var charList = input.ToCharArray();
                            var stringList = new List<string>(input.Split(' '));

                            Array.Reverse(charList);

                            stringList.Reverse();

                            Console.WriteLine($"\nReversed String Word by Word\n{string.Join(" ", stringList)}");

                            Console.WriteLine("\nReversed String Letter by Letter");
                            Console.WriteLine(charList);

                            Console.WriteLine();
                            flag = true;
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nGive Two Inputs\n");
                            Console.Write("Input 1: ");
                            var input1 = Console.ReadLine();
                            Console.Write("Input 2: ");
                            var input2 = Console.ReadLine();
                            obj.swapWithAThird(input1, input2);
                            obj.swapWithoutAThird(input1, input2);
                            flag = true;
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("\nEnter String");
                            Console.Write("\nInput: ");
                            var input = Console.ReadLine();
                            obj.palindrome(input);
                            flag = true;
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("\nUpper Case Alphabets with ASCII\n");
                            obj.upperCaseAscii();
                            Console.WriteLine("Lower Case Alphabets with ASCII\n");
                            obj.lowerCaseAscii();
                            flag = true;
                            break;
                        }
                    case 8:
                        {
                            Console.Write("Enter a number:");
                            var input = Convert.ToInt32(Console.ReadLine());
                            obj.armstrong(input);
                            flag = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nError: Invalid Input please try again...");
                            flag = false;
                            break;
                        }
                }
                if(flag == true)
                {
                    while (true)
                    {
                        Console.Write("\nDo you want to see another solution(y/n): ");
                        var neworexit = Console.ReadLine();
                        if (neworexit == "y" || neworexit == "Y")
                        {
                            flag = false;
                            break;
                        }
                        else if (neworexit == "n" || neworexit == "N")
                        {
                            flag = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nError: Wrong Input please try again ");
                            continue;
                        }
                    }
                    
                }
            } while (!flag);
        }
    }
}
