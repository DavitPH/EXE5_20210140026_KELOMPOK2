using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EXE5
{
    class Node
    {
        public string name;
        public Node next;
    }
    class queue
    {
        Node Renita, Widiastuti;
        public queue()
        {
            Renita = null;
            Widiastuti = null;
        }
        public void insert()
        {
            string k2;
            Node newnode = new Node();
            Console.WriteLine("Masukan Element: ");
            k2 = Console.ReadLine();
            newnode.name = k2;
            newnode.next = null;
            if (Renita == null)
            {
                Renita = newnode;
                Widiastuti = newnode;
                return;
            }
            Renita = newnode;
            Widiastuti = newnode;
        }
        public void delete()
        {
            if (Renita == null)
            {
                Console.WriteLine("Queue is Empty!!!");
                return;
            }
            Renita = Renita.next;
            if (Renita == null)
                Widiastuti = null;
        }
        public void display()
        {
            if (Renita == null)
            {
                Console.WriteLine("Queue is Empty or Filled !!!");
                return;
            }
            Node display;
            for (display = Renita; display != null; display = display.next)
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
                    Console.WriteLine("Check for the values entered");
                }
            }
        }
    }
}
