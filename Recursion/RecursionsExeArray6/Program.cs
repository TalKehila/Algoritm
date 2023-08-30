using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RecursionsExeArray6
{
    internal class Program
    {
        // רקורסיה שמקבלת מערך ומחזירה את המספר המקסימלי
        static void Main(string[] args)
        {
           
            Console.WriteLine(IsPolindrom("12345",0));
            Console.WriteLine(IsPolindrom("12321",0));
            Console.WriteLine(IsPolindrom("2468",0));
            Console.WriteLine(IsPolindrom("268862", 0));

        }
        public static int PrintMaxNumber(int[]arr, int index)
        {
            if(index== arr.Length-1)
            {
                return arr[index];
            }         
           return Math.Max(arr[index],PrintMaxNumber(arr, index + 1));
        }
        public static bool IsPolindrom(string someting,int index=0)
        {
            if (index==someting.Length/2)
            {
                return true;
            }
            if (someting[index] == someting[someting.Length-1-index])
            {
                return
                IsPolindrom(someting,index+1);
                
            }
            return false;
        }
    }
}
