using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = {1,5,3};
            //Console.WriteLine(SortPush(arr));
            string s = "[([])]";
            Console.WriteLine(S(s));
        }
        public static bool S(string someting)
        {

            if (someting == null)
            {
                return true;
            }
            Stack<char> mystack = new Stack<char>();

            for (int i = 0; i < someting.Length; i++)

            {
                if (someting[i] == '[' || someting[i] == '{' || someting[i] == '(')
                {
                    mystack.Push(someting[i]);
                }
                if (someting[i] == ']' || someting[i] == '}' || someting[i] == ')')
                {
                    if (mystack.IsEmpty())
                    {
                        return false;
                    }
                    char c = mystack.Pop();
                    if (someting[i] == ']')
                    {
                        if (c != '[')
                        {
                            return false;
                        }
                    }
                    if (someting[i] == '}')
                    {
                        if (c != '{')
                        {
                            return false;
                        }
                    }
                    if (someting[i] == ')')
                    {
                        if (c != '(')
                        {
                            return false;
                        }
                    }
                }
            }
            if (mystack.IsEmpty())
            {
                return true;
            }
            return false;
        }

        public static int SortPush(int[] someting) 
        { 
            int count = 0;  
            Stack<int> mystack = new Stack<int>();
           
            for (int i = 0; i < someting.Length; i++)
            {              
                if (mystack.IsEmpty() || someting[i] > mystack.Top())
                {                 
                    mystack.Push(someting[i]);
                    count++;
                }                           
                else
                {
                    Stack<int> tempstack = new Stack<int>();
                    while (!mystack.IsEmpty() && mystack.Top() > someting[i])
                    {
                        count++;
                        tempstack.Push(mystack.Pop());
                    }
                    mystack.Push(someting[i]);
                    while (!tempstack.IsEmpty())
                    {
                        count++;
                        mystack.Push(tempstack.Pop());
                    }
                }            
            }
            Console.WriteLine(mystack);
            return count;
        }                  
    }
}
