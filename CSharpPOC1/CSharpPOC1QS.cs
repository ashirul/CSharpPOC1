using System;
using System.Collections.Generic;

namespace CSharpPOC1
{
    public class CSharpPOC1QS
    {
        // Fibonacci Series
        public string fibTillFifty()
        {
            var fib = new List<long>();
            long a = 0, b = 1, c;
            fib.Add(a);
            fib.Add(b);

            for (var i = 1; i <= 48; i++)
            {
                c = a + b;
                fib.Add(c);
                a = b;
                b = c;
            }
            return string.Join(",", fib);
        }

        // Armstrong Number
        public void armstrong(int input)
        {
            var temp = input;
            var inputLength = input.ToString().Length;
            int rem, sum = 0;
            while (temp > 0)
            {
                int pow = 1;
                rem = temp % 10;
                for (var i = 0; i < inputLength; i++)
                    pow = rem * pow;
                sum = sum + pow;
                temp = temp / 10;
            }
            if (sum == input)
                Console.WriteLine("Armstrong");
            else
                Console.WriteLine("Not Armstrong");
        }

        // Decimal to Binary
        public string binary(string input)
        {
            var binBit = new List<long>();
            var temp = Convert.ToInt64(input);
            if (temp != 0)
            {
                while (temp > 0)
                {
                    binBit.Add(temp % 2);
                    temp = temp / 2;
                }
                binBit.Reverse();
                return string.Join("", binBit);
            }
            else if (temp == 0)
                return "0";
            return "";
        }

        // Consecutive 1's in Binary Equivalent
        public void consecutiveones(string bin)
        {
            var tempBin = binary(bin);
            var onlyOnes = tempBin.Split('0');
            var count = 0;
            if (bin == "0")
            {
                Console.WriteLine("Binary Equivalent: 0");
                Console.WriteLine("Maximum number of Consecutive 1's: 0");
            }
            else
            {
                Array.Sort(onlyOnes);
                count = Convert.ToInt32(onlyOnes[onlyOnes.Length - 1].Length);
                Console.WriteLine();
                if (count == 0)
                    count = 1;
                Console.WriteLine("Binary Equivalent: " + tempBin);
                Console.WriteLine("Maximum number of Consecutive 1's: " + count);
            }
        }

        // Sorting Array in Ascending Order
        public void ascending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Sorting Array in Descending Order
        public void descending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Swapping Values using a Third Variable
        public void swapWithAThird(string first, string second)
        {
            string third = second;
            second = first;
            first = third;
            Console.WriteLine("\nSwapping using a Third Variable.");
            Console.WriteLine(String.Format("\nInput 1: {0}\nInput 2: {1}\n", first, second));
        }

        // Swapping Values without using a Third Variable
        public void swapWithoutAThird(string first, string second)
        {
            first = first + " " + second;
            for (var input = 0; input < first.Length; input++)
            {
                if (first[input] == ' ')
                {
                    second = first.Substring(0, input);
                    first = first.Substring(input).Trim();
                }
            }
            Console.WriteLine("Swapping Without using a Third Variable");
            Console.WriteLine(String.Format("\nInput 1: {0}\nInput 2: {1}\n", first, second));
        }

        // Palindrome of String
        public void palindrome(string input)
        {
            var inputLower = input.ToLower();
            var inputLength = input.Length;
            var temp = "";
            for (var i = inputLength - 1; i >= 0; i--)
            {
                temp = temp + inputLower[i];
            }
            if (temp == inputLower)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }

        // To Print ASCII of Upper Case Letters (A to Z)
        public void upperCaseAscii()
        {
            string alphabetArray = "abcdefghijklmnopqrstuvwxyz";
            var counter = 0;
            foreach (var letter in alphabetArray.ToUpper())
            {
                Console.Write(String.Format("{0}: {1}   ", letter, (int)letter));
                counter++;
                if (counter % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
        }

        // To Print ASCII of Lower Case Letters (a to b)
        public void lowerCaseAscii()
        {
            string alphabetArray = "abcdefghijklmnopqrstuvwxyz";
            var counter = 0;
            foreach (var letter in alphabetArray)
            {
                counter++;
                {
                    if (counter == 2)
                        Console.Write(String.Format(" {0}: {1}   ", letter, (int)letter));
                    else if (counter == 3)
                        Console.Write(String.Format(" {0}: {1}   ", letter, (int)letter));
                    else if (counter == 4)
                        Console.Write(String.Format(" {0}: {1}   ", letter, (int)letter));
                    else
                        Console.Write(String.Format("{0}: {1}   ", letter, (int)letter));
                }
                if (counter % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\n");
        }
    }
}
