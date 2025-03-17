namespace StackZad2
{
    internal class Program
    {
        static bool CheckBalanced(string input)
        {
            Stack<char> stack = new Stack<char>(); 
            var matchingBrackets = new Dictionary<char, char> 
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };

            foreach (char ch in input)
            {
                if (matchingBrackets.ContainsValue(ch)) 
                {
                    stack.Push(ch);
                }
                else if (matchingBrackets.ContainsKey(ch)) 
                {
                    if (stack.Count > 0 && stack.Peek() == matchingBrackets[ch])
                    {
                        stack.Pop(); 
                    }
                    else
                    {
                        return false; 
                    }
                }
            }

            return stack.Count == 0; 
        }
        static void Main()
        {
            string input1 = "{[()()]}";
            string input2 = "{[(])}";

            Console.WriteLine($"Input: {input1} - Balanced: {CheckBalanced(input1)}");
            Console.WriteLine($"Input: {input2} - Balanced: {CheckBalanced(input2)}");

        }
    }
}

