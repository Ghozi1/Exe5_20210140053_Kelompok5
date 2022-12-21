﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node muhammad, ghifari;
        public queue()
        {
            muhammad = null;
            ghifari = null;
        }

        public void insert()
        {
            string k5;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            k5 = Console.ReadLine();
            newnode.name = k5;
            newnode.next = null;
            if (muhammad == null)
            {
                muhammad = newnode;
                ghifari = newnode;
                return;
            }
            ghifari.next = newnode;
            ghifari = newnode;
        }
        public void delete()
        {
            if (muhammad == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            muhammad = muhammad.next;
            if (muhammad == null)
                ghifari = null;
        }
        public void display()
        {
            if (muhammad == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            Node display;
            for (display = muhammad; display != null; display = display.next)
                Console.WriteLine(display.name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            queue q = new queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            q.insert();
                            break;
                        case '2':
                            q.delete();
                            break;
                        case '3':
                            q.display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}