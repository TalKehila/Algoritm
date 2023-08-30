using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//תרגילים תור
//1.	פעולה המקבלת ערך X ומחזירה את מספר המופעים של הערך X בתור. התור נשאר ללא שינוי.
//2.	פעולה המקבלת מקום N ומחזירה את ערך האיבר הנמצא במקום N בתור. דוגמא: עבור N = 4 יוחזר האיבר ה- 4 מראש התור. הנחה: קיים איבר במקום N בתור.
//3.	פעולה המקבלת ערך X ומוציאה מן התור את כל המופעים של הערך X. סדר האיברים האחרים בתור נשאר ללא שינוי.

//הגדר את הפעולות החיצוניות הבאות:

//4.פעולה המקבלת שני תורים ומחזירה 'אמת' אם הם זהים ו 'שקר' אחרת.
//5.	פעולה המקבלת תור ומחזירה תור אחר בו מבנה כל איבר הוא ערך ושכיחותו, על פי התור המתקבל כפרמטר.
//6.	פעולה המקבלת תור Q ומחזירה את הערך המינימלי בתור, התור מתעדכן להיות ללא האיבר המינימאלי.
//7.	פעולה המקבלת תור Q ומחזירה אותו ממוין מקטן לגדול.
namespace QueueAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 
            Queue<int> queue = new Queue<int>();
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);
            queue.Insert(2);

            int occurrences = queue.CountOccurrences(2);
            Console.WriteLine("Occurrences of 2: " + occurrences);

            //2 
            Queue<string> queue2 = new Queue<string>();
            queue2.Insert("A");
            queue2.Insert("B");
            queue2.Insert("C");
            queue2.Insert("D");

            int position = 4;
            string value = queue2.GetValueAtPosition(position);
            Console.WriteLine("Value at position " + position + ": " + value);
            //3
            Queue<string> queue3 = new Queue<string>();
            queue3.Insert("A");
            queue3.Insert("B");
            queue3.Insert("C");
            queue3.Insert("A");
            queue3.Insert("D");

            Console.WriteLine("Before removal: " + queue.ToString());

            string valueToRemove = "A";
            queue3.RemoveAllOccurrences(valueToRemove);

            Console.WriteLine("After removal of " + valueToRemove + ": " + queue.ToString());

            //4
            Queue<int> queue1 = new Queue<int>();
            queue1.Insert(1);
            queue1.Insert(2);
            queue1.Insert(3);

            Queue<int> queue4 = new Queue<int>();
            queue4.Insert(1);
            queue4.Insert(2);
            queue4.Insert(3);

            bool isEqual = queue1.IsEqual(queue4);
            Console.WriteLine("Queues are equal: " + isEqual);
            //5 
            Queue<string> queue5 = new Queue<string>();
            queue5.Insert("A");
            queue5.Insert("B");
            queue5.Insert("A");
            queue5.Insert("C");
            queue5.Insert("A");
            queue5.Insert("B");

            Queue<KeyValuePair<string, int>> frequencyQueue = queue5.GetFrequencyQueue();

            Console.WriteLine("Frequency Queue:");

            while (!frequencyQueue.IsEmpty())
            {
                KeyValuePair<string, int> pair = frequencyQueue.Remove();
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }
            //6
            Queue<int> queue6 = new Queue<int>();
            queue6.Insert(5);
            queue6.Insert(2);
            queue6.Insert(7);
            queue6.Insert(1);

            int minValue = queue6.RemoveMin();
            Console.WriteLine("Minimum value: " + minValue);

            Console.WriteLine("Updated Queue: " + queue6);
            //7 
            Queue<int> queue7 = new Queue<int>();
            queue7.Insert(5);
            queue7.Insert(2);
            queue7.Insert(7);
            queue7.Insert(1);

            Console.WriteLine("Original Queue: " + queue7);

            queue7.Sort();

            Console.WriteLine("Sorted Queue: " + queue7);

        }
        


        
    }
   
}
