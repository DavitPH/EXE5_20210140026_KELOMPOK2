using System;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int davit, hartono, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            davit = -1;
            hartono = -1;
        }
        public void insert(int element)
        {
            if ((davit == 0 && hartono == max - 1) || (davit == hartono + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            if (davit == -1)
            {
                davit = 0;
                hartono = 0;
            }
            else
            {
                if (hartono == max - 1)
                    hartono = 0;
                else
                    hartono = hartono + 1;
            }
            queue_array[hartono] = element;
        }
        public void remove()
        {
            if (davit == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe element deleted from the queue is: " + queue_array[davit] + "\n");
            if (davit == hartono)
            {
                davit = -1;
                hartono = -1;
            }
            else
            {
                if (davit == max - 1)
                    davit = 0;
                else
                    davit = davit + 1;
            }
        }
        public void display()
        {
            int FRONT_position =davit;
            int REAR_position = hartono;
            if (davit == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are ..................\n");
            if (FRONT_position <= REAR_position)
            {
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "      ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                while (FRONT_position <= max - 1)
                {
                    Console.WriteLine(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                FRONT_position = 0;
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Queues q = new Queues();
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
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                q.insert(num);
                            }
                            break;
                        case '2':
                            {
                                q.remove();
                            }
                            break;
                        case '3':
                            {
                                q.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option!!");
                            }
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