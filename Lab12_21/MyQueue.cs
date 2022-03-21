using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using VehicleS;

//удаление коллекции из памяти

namespace Lab12_21
{
    class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }
        public Node()
        {
            data = default(T);
            next = null;
        }
        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
    public class MyQueue<T> : IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public MyQueue()
        {
            head = null;
            tail = null;
        }
        public MyQueue(int copacity)
        {
            for (int i = 0; i < copacity; i++)
            {
                Node<T> node = new Node<T>();
                Node<T> tmpNode = tail;
                tail = node;
                if (count == 0)
                {
                    head = tail;
                }
                else
                {
                    tmpNode.next = tail;
                }
                count++;
            }
        }
        public MyQueue(MyQueue<T> forCopy)
        {
            int tmpCopacity = forCopy.Count;
            for (int i = 0; i < tmpCopacity; i++)
            {
                Node<T> node = forCopy.head;
                Node<T> tmpNode = tail;
                tail = node;
                if (count == 0)
                {
                    head = tail;
                }
                else
                {
                    tmpNode.next = tail;
                }
                count++;
                forCopy.head = forCopy.head.next;
                forCopy.count--;
            }
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public T First
        {
            get
            {
                if (IsEmpty) throw new InvalidOperationException();
                return head.data;
            }
        }
        public T Last
        {
            get
            {
                if (IsEmpty) throw new InvalidOperationException();
                return tail.data;
            }
        }
        public void Add(T obj)
        {
            Node<T> node = new Node<T>(obj);
            Node<T> tmpNode = tail;
            tail = node;
            if (count == 0)
            {
                head = tail;
            }
            else
            {
                tmpNode.next = tail;
            }
            count++;
        }
        public void Add(T[] masObj)
        {
            for (int i = 0; i < masObj.Length; i++)
            {
                Add(masObj[i]);
            }
        }
        public T Dell()
        {
            if (count == 0) throw new InvalidOperationException();
            T output = head.data;
            head = head.next;
            count--;
            return output;
        }
        public void Dell(int copacity)
        {
            for (int i = 0; i < copacity; i++)
            {
                if (count == 0) throw new InvalidOperationException();
                T output = head.data;
                head = head.next;
                count--;
            }
        }
        public bool Find(T obj)
        {
            bool res = false;
            int tmpCount = count;
            for (int i = 0; i < tmpCount; i++)
            {
                T currentFirstElement = Dell();
                if (currentFirstElement.Equals(obj))
                {
                    res = true;
                }
                Add(currentFirstElement);
            }
            return res;
        }
        public MyQueue<T> Clone()
        {
            return new MyQueue<T>(this);
        }
        public MyQueue<T> ShallowCopy()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }//описать??????????
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }
    }
}
