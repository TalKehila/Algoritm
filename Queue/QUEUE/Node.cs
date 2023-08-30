using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUEUE
{
    class Queue <T>
    {
        Node<T> head;
        Node<T> tail;

        public void Insert(T item)
        {
            if(head == null)           {
                head = new Node<T>(item);
                tail = head;
            }
            else
            {
                Node < T > n = new Node<T>(item);
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
            Node <T> n = head;       
            string s = "";
            while(n != null)
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

