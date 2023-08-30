using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ecercise_algorithms_14_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] myarr = { { 1, 5, 5, 2 },{ 5, 3, 2, 1 } };
            int count = 0;
            int result = NumTimesInTwoDArray(myarr,count,0,0);
            Console.WriteLine(result);

        }
        // exercise 12 
        public static int SumDigit(int n)
        {
            if (n < 10)
            {
                return n;
            }
            int lastDigit = n % 10;
            int remainigDigits = n / 10;
            int mulDigit = SumDigit(remainigDigits);
            return lastDigit * mulDigit;
        }
        // exercise 13
        public static int PrintOddNumber(int n)
        {
            if (n < 0)
            {
                return n;
            }
            int lastDigit = n % 10;
            int remainigDigits = n / 10;

            if (n % 2 == 1)
            {
                Console.WriteLine(lastDigit);
            }
            PrintOddNumber(remainigDigits);
            return n;


        }
        // exerice 14 
        public static void printOddInArr(int[] arr, int index=0)
        {
            if (arr == null || index == arr.Length)
            {
                return;
            }
            if (index % 2 == 1)
            {
                Console.WriteLine(arr[index]);
            }
            printOddInArr(arr, index + 1);
        }
        // exercise 15 
        public static bool SortedArr(int[] arr, int i = 0)
        {
            if (arr == null || i == arr.Length - 1)
            {
                return true;
            }
            if (arr[i] >= arr[i + 1])
            {
                return false;
            }
           return SortedArr(arr, i+1);
            
        }
        // exercise 16 
       public static int NumTImes( int[]arr , int i = 0, int num=0,int count = 0) 
        {
            if (arr == null || i == arr.Length)
            {
                return count;
            }
            if (arr[i]==num)
            {
                count++;
            }
           return NumTImes(arr, i+1, num,count);
           
        }
        // exericse 17
        public static int NumTimesInTwoDArray(int[,] arr, int count ,int row, int col)
        {    int num = 5;
            if(arr == null || row ==arr.GetLength(0) || col == arr.GetLength(1))
            {
                return count;
            }
            if (arr[row,col] == num)
            {
                count++;
            }
            if (col +1 < arr.GetLength(1))

            count= NumTimesInTwoDArray(arr, count, row, col+1);

           if(row+1 < arr.GetLength(0)) 

             count= NumTimesInTwoDArray(arr,count, row+1, col);

            return count;
        }

    }
}
