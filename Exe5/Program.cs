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
            
        }
    }


    class Program
    {
        static void Main(string[] args) 
        {
        }
    }
}
