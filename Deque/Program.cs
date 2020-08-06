using System;

namespace Deque
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, x;
            DequeA dq = new DequeA(8);
            while (true)
            {
                Console.WriteLine("1.Insert at the front end");
                Console.WriteLine("2.Insert at the rear end");
                Console.WriteLine("3.Delete from the front end");
                Console.WriteLine("4.Delete from the rear end");
                Console.WriteLine("5.Display all elements from the deque");
                Console.WriteLine("6.quit");
                Console.Write("enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 6)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("enter an Element");
                        x = Convert.ToInt32(Console.ReadLine());
                        dq.InserFront(x);
                        break;
                    case 2:
                        Console.Write("enter an Element");
                        x = Convert.ToInt32(Console.ReadLine());
                        dq.InsertRear(x);
                        break;
                    case 3:
                        x = dq.DeleteFront();
                        Console.Write("deleted element is :" + x);
                        break;
                    case 4:
                        x = dq.DeleteFront();
                        Console.Write("deleted element is :" + x);
                        break;
                    case 5:
                        dq.Display();
                        break;
                    default:
                        Console.Write("wring choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
