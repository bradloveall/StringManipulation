using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{

    public interface IStringManipulation
    {
        string GetReversedString(string input);
    }

    public static class ExtensionMethods
    {
        /// <summary>
        /// This is probably overkill, but I can imagine it being a nice extension method on a string.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static Stack<char> ToStack(this String obj)
        {
            Stack<char> stack = new Stack<char>();
            char[] letters = obj.ToCharArray();
            foreach (char letter in letters)
                stack.Push(letter);

            return stack;
        }
    }

    public class StringManipulationUsingStacks: IStringManipulation
    {

        public string GetReversedString(string input)
        {
            Stack<char> stack = input.ToStack();
            StringBuilder sb = new StringBuilder();
            while (stack.Count > 0)
                sb.Append(stack.Pop());

            return sb.ToString();
        }             
    }

    public class StringManipulationUsingArrayReverse : IStringManipulation
    {

        public string GetReversedString(string input)
        {
            char[] letters = input.ToCharArray();
            Array.Reverse(letters);
            StringBuilder sb = new StringBuilder();
            foreach (char letter in letters)
                sb.Append(letter);

            return sb.ToString();
        }
    }
}
