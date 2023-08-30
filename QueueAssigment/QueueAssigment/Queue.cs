using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAssigment
{
    class Queue<T>
    {
        Node<T> head;
        Node<T> tail;

        public void Insert(T item)
        {
            if (head == null)
            {
                head = new Node<T>(item);
                tail = head;
            }
            else
            {
                Node<T> n = new Node<T>(item);
                tail.Next = n;
                tail = n;
            }
        }
        public T Remove()
        {
            if (head == null)
            {
                throw new Exception("empty queue ");
            }
            T ans = head.Data;
            head = head.Next;
            return ans;
        }
        public T Pick()
        {
            if (head == null)
            {
                throw new Exception("empty queue");
            }
            T ans = head.Data;
            return ans;
        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public override string ToString()
        {
            Node<T> n = head;
            string s = "";
            while (n != null)
            {
                s += n.ToString();
                n = n.Next;
            }
            return s;
        }
        // 1 
        public int CountOccurrences(T value)
        {
            Node<T> currentNode = head;
            int count = 0;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(value))
                {
                    count++;
                }
                currentNode = currentNode.Next;
            }

            return count;
        }
        //2 
        public T GetValueAtPosition(int position)
        {
            Node<T> currentNode = head;
            int currentPosition = 1;

            while (currentNode != null && currentPosition < position)
            {
                currentNode = currentNode.Next;
                currentPosition++;
            }

            if (currentNode == null)
            {
                throw new IndexOutOfRangeException("Invalid position");
            }

            return currentNode.Data;
        }
        // 3 
        public void RemoveAllOccurrences(T value)
        {
            Node<T> previousNode = null;
            Node<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(value))
                {
                    // Check if the node to be removed is the head
                    if (previousNode == null)
                    {
                        head = currentNode.Next;
                    }
                    // Removing value to the left
                    else
                    {
                        previousNode.Next = currentNode.Next;
                    }

                    // If the removed node was the tail, update the tail reference
                    if (currentNode == tail)
                    {
                        tail = previousNode;
                    }

                    currentNode = currentNode.Next;
                }
                else
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }
        }
        //4 
        public bool IsEqual(Queue<T> otherQueue)
        {
            if (otherQueue == null)
            {
                return false;
            }

            Node<T> currentNode = head;
            Node<T> otherCurrentNode = otherQueue.head;

            while (currentNode != null && otherCurrentNode != null)
            {
                if (!currentNode.Data.Equals(otherCurrentNode.Data))
                {
                    return false;
                }

                currentNode = currentNode.Next;
                otherCurrentNode = otherCurrentNode.Next;
            }

            // Check if both queues reached the end
            if (currentNode == null && otherCurrentNode == null)
            {
                return true;
            }

            return false;
        }
        //5
        public Queue<KeyValuePair<T, int>> GetFrequencyQueue()
        {
            Queue<KeyValuePair<T, int>> frequencyQueue = new Queue<KeyValuePair<T, int>>();

            Node<T> currentNode = head;
            Dictionary<T, int> frequencyDict = new Dictionary<T, int>();

            while (currentNode != null)
            {
                if (frequencyDict.ContainsKey(currentNode.Data))
                {
                    frequencyDict[currentNode.Data]++;
                }
                else
                {
                    frequencyDict[currentNode.Data] = 1;
                }

                currentNode = currentNode.Next;
            }

            foreach (var kvp in frequencyDict)
            {
                frequencyQueue.Insert(new KeyValuePair<T, int>(kvp.Key, kvp.Value));
            }

            return frequencyQueue;
        }
        //6
        public T RemoveMin()
        {
            if (head == null)
            {
                throw new Exception("Empty queue");
            }

            Node<T> currentNode = head;
            Node<T> previousNode = null;
            Node<T> minNode = head;
            Node<T> previousMinNode = null;

            while (currentNode != null)
            {
                if (Comparer<T>.Default.Compare(currentNode.Data, minNode.Data) < 0)
                {
                    minNode = currentNode;
                    previousMinNode = previousNode;
                }

                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            // Remove the minimum node from the queue
            if (previousMinNode == null)
            {
                head = minNode.Next;
            }
            else
            {
                previousMinNode.Next = minNode.Next;
            }

            // Update the tail if the minimum node was the last node
            if (minNode == tail)
            {
                tail = previousMinNode;
            }

            return minNode.Data;
        }
        //7 
        public void Sort()
        {
            List<T> tempList = new List<T>();

            // Move elements from the queue to a temporary list
            while (!IsEmpty())
            {
                tempList.Add(Remove());
            }

            // Sort the temporary list
            tempList.Sort();

            // Insert sorted elements back into the queue
            foreach (T item in tempList)
            {
                Insert(item);
            }
        }

    }
    class Node<T>
    {
        T data;
        Node<T> next;

        public Node(T data)
        {
            this.data = data;
        }
        public Node(T data, Node<T> next)
        {
            this.next = next;
            this.data = data;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return data.ToString();
        }

    }



}
