
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BinTree
    {
        public int data;
        public BinTree left;
        public BinTree right;
    }


    internal class Program
    {
        static void Main(string[] args)
        {

        }

        
        // כתבו פעולה שמקבלת את ומחזירה את סכום העלים בעץ
        public int SumIsBts(BinTree root)
        {
            if (root == null)
            {
                return 0;
            }
            if(root.left == null && root.right == null)
                {
                 return root.data;
                }
            return SumIsBts(root.left)+SumIsBts(root.right);
        }
        //כתבו פעולה שמקבלת עץ ומחזירה תשובה אם הוא BST או לא
        public bool IsBst(BinTree root)
        {
            if (root == null)
            {
                return true;
            }

            if (root.left != null && root.left.data >= root.data)
            {
                return false;
            }
            if (root.right != null && root.right.data < root.data)
            {
                return false;
            }
            return IsBst(root.right) && IsBst(root.left);


        }


        public static bool Parentisis(char[] data)
        {
            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < data.Length; i++)
            {
                //סוגר פותח מכניסים למחסנית
                if (data[i] == '(' || data[i] == '[' || data[i] == '{')
                {
                    stk.Push(data[i]);
                }
                else//סוגר סוגר, מוציאים ובודקים נכונות
                {
                    char c = stk.Pop();
                    if (!(data[i] == ')' && c == '(' || data[i] == ']' && c == '[' || data[i] == '}' && c == '{'))
                    {
                        return false;
                    }
                }
            }

            return stk.Count == 0;

        }



        public static void insertSordet(Stack<int> stack, int val)
        {
            if (stack.Count == 0)
            {
                stack.Push(val);
            }

            if (val > stack.Peek())
            {
                stack.Push(val);
            }

            Stack<int> s = new Stack<int>();
            while (stack.Count > 0 && stack.Peek() > val)
            {
                s.Push(stack.Pop());
            }
            stack.Push(val);

            while (s.Count > 0)
            {
                stack.Push(s.Pop());
            }
        }


    }
}
