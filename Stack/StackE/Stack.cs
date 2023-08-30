using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StackE
{
    internal class Stack<T>
    {
        Node<T> head;

        public void Push(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                return;
            }
            else
            {
                head = new Node<T>(data, head);
            }
        }
        public bool IsEmpty() { return head == null; }
        public T Pop()
        {
            if (head == null)
            {
                throw new Exception("null stack is empty");
            }
            else
            {
                T ans = head.Data;
                head = head.Next;
                return ans;
            }

        }
        public T Top()
        {
            if (head == null)
            {
                throw new Exception("null");
            }
            else
            {
                T ans = head.Data;
                return ans;
            }
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



