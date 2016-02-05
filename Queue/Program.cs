using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueClass myQueue = new QueueClass();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Display();
            Console.ReadLine();
        }
    }

    interface QueueADT
    {
        Boolean isEmpty();
        void Enqueue(Object element);
        object Dequeue();
        void Display();
    }

    class QueueClass : QueueADT
    {
        private int QueueSize;
        public int QueueSizeSet
        {
            get { return QueueSize; }
            set { QueueSize = value; }
        }
        public int front;
        public int end;
        public int length;

        Object[] item;
        public QueueClass()
        {
            QueueSize = 10;
            item = new Object[QueueSize];
            front = 0;
            length = 0;
            end = (length + front);
        }

        public bool isEmpty()
        {
            if (front == 0) return true;
            return false;
        }
        public void Enqueue(object element)
        {
            if (length == QueueSize)
            {
                Console.WriteLine("Queue is full!");
            }
            else
            {
                item[end] = element;
                length += 1;
            }


        }
        public object Dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return "No elements";
            }
            else
            {
               Object element = item[front];
                item[front] = default(Object);
                length--;
                front = (front + 1) % QueueSize;
                return element;
            }

        }
        public void Display()
        {
            for (int i = end; i > -1 ; i--)
            {
                Console.WriteLine("Item {0}: {1}", i, item[i]);
            }
        }
    }
}
