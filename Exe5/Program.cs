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
            Node kel5 = new Node();
            Console.WriteLine("Masukan Elemnet data");
            k5 = Console.ReadLine();
            kel5.name = k5;
            kel5.next = null;
            if (muhammad == null)
            {
                muhammad = kel5;
                ghifari = kel5;
            }
            muhammad.next = kel5;
            muhammad = kel5;
        }

        public void delete()
        {
            if(muhammad == null)
            {
                Console.WriteLine("Queue is empty");
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
        }
    }
}
