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
        
    }
}