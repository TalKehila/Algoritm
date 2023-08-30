using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    public class LinkedList
    {
        public class Node
        {
            public int key;
            public Node next;
            public Node(int key)
            {
                this.key = key;
            }
        }

        public Node head;
        public LinkedList()
        {
            head = null;
        }
        public LinkedList(params int[] keys)
        {
            Array.Sort(keys);
            head = new Node(keys[0]);
            Node temp = head.next;
            for (int i = 1; i < keys.Length; i++)
            {
                if (keys[i] != keys[i - 1])
                {
                    temp = new Node(keys[i]);
                    temp = temp.next;
                }
            }
        }
        public LinkedList(LinkedList other)
        {
            Node tempThis = this.head;
            Node tempOther = other.head;
            while (tempOther != null)
            {
                tempThis = new Node(tempOther.key);

                tempThis = tempThis.next;
                tempOther = tempOther.next;
            }
        }

        public void Insert(int key)
        {
            Node newNode = new Node(key);
            if (head == null || key < head.key)
            {
                newNode.next = head;
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null && temp.next.key < key)
            {
                temp = temp.next;
            }

            if (temp.next != null && temp.next.key == key)
                return;

            newNode.next = temp.next;
            temp.next = newNode;
        }
        public void Delete(int key)
        {
            if (head != null)// if i have number in my linked list 
            {
                if (head.key == key)// this if delete it if the key is the same number as head and do head ++ after delete
                {
                    head = head.next;
                    return;
                }
                Node nexthead = head.next;// new index (my next index)
                Node headnow = head;// new index (my now index)
                while (nexthead != null && nexthead.key != key) // if the next member is not null and not the key 
                {
                    headnow = nexthead;// update  for keep checking and process the next node
                    nexthead = nexthead.next;
                }
                if (nexthead != null)// if not null so keep serching
                {
                    headnow.next = nexthead.next;
                }
            }
        }
        public static LinkedList Merge(LinkedList firstlist, LinkedList otherlist)
        {
            LinkedList mergelist = new LinkedList();

            Node node1 = firstlist.head;
            Node node2 = otherlist.head;
            while (node1 != null && node2 != null) //ruuning until 1 of the list is empty
            {
                if (node1.key < node2.key)
                {
                    mergelist.Insert(node1.key);// key will insert into the the merge else node 2 key will do it 
                    node1 = node1.next;
                }
                else
                {
                    mergelist.Insert(node2.key);
                    node2 = node2.next;
                }
            }
            while (node1 != null)
            {
                mergelist.Insert(node1.key);
                node1 = node1.next;
            }
            while (node2 != null)
            {
                mergelist.Insert(node2.key);
                node2 = node2.next;
            }
            return mergelist;
        }
        public override string ToString()
        {
            Node temp = head;
            string str = "[";
            while (temp != null)
            {
                if (temp != head)
                    str += ",";

                str += temp.key;
                temp = temp.next;
            }
            str += "]";
            return str;
        }

        
    }
}
