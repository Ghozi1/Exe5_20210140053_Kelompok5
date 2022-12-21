using System;
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
               
            }
        }
    }
}