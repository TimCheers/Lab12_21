using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleS;

namespace Lab12_21
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<Vehicle> myQueue = new MyQueue<Vehicle>();
            Automobile myAutomobile0 = new Automobile("fulldrive", "left", 1.5, 120, 5);
            Automobile myAutomobile1 = new Automobile("fulldrive","left",1.5,180,5);
            Automobile myAutomobile2 = new Automobile("fulldrive", "right", 1, 120, 7);
            Automobile myAutomobile3 = new Automobile("fulldrive", "center", 2, 200, 3);
            Vehicle[] mas=new Vehicle[3];
            mas[0] = myAutomobile1;
            mas[1] = myAutomobile2;
            mas[2] = myAutomobile3;
            myQueue.Add(myAutomobile1);
            myQueue.Add(myAutomobile2);
            myQueue.Add(myAutomobile3);
            Console.WriteLine(myQueue.First.Show());
            Console.WriteLine(myQueue.Last.Show());
            Console.WriteLine("================================================");
            foreach (Vehicle item in myQueue)
            {
                Console.WriteLine(item.Show());
            }
            Console.WriteLine("================================================");
            myQueue.Dell(2);
            Console.WriteLine("================================================");
            foreach (Vehicle item in myQueue)
            {
                Console.WriteLine(item.Show());
            }
            Console.WriteLine("================================================");
            myQueue.Add(mas);
            Console.WriteLine("================================================");
            foreach (Vehicle item in myQueue)
            {
                Console.WriteLine(item.Show());
            }
            Console.WriteLine("================================================");
            Console.WriteLine(myQueue.Find(myAutomobile1));
            Console.WriteLine("================================================");
            foreach (Vehicle item in myQueue)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(item.Show());
                Console.WriteLine("-----------------------------------");
            }
            Console.WriteLine("================================================");
            MyQueue<Vehicle> myQueue1= myQueue.Clone();
            Console.WriteLine("================================================");
            foreach (Vehicle item in myQueue1)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine(item.Show());
                Console.WriteLine("-----------------------------------");
            }
            Console.WriteLine("================================================");
            //MyQueue<Vehicle> myQueue2 = new MyQueue<Vehicle>(myQueue);
            //Console.WriteLine("================================================");
            //Console.WriteLine(myQueue2.First.Show());
            //Console.WriteLine(myQueue2.Last.Show());
        }
    }

}