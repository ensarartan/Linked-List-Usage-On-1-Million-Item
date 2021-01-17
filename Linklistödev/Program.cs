using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linklistödev
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTimeFirst = DateTime.Now;
            double Speed = Math.Pow(10, 6);
            Random random = new Random((int)Speed);
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < Speed; i++)
            {
                linkedList.AddLast(random.Next((int)Speed));
            }
            DateTime dateTimeSecond = DateTime.Now;
            TimeSpan timeSpan = dateTimeSecond - dateTimeFirst;
            Console.WriteLine("LinkedList'te verinin yüklenme süresi       : " + (int)timeSpan.TotalMilliseconds + " Ms");
            Console.WriteLine("-----------------------------------------------------------------");

            dateTimeFirst = DateTime.Now;
            linkedList.AddFirst(random.Next((int)Speed));
            dateTimeSecond = DateTime.Now;
            timeSpan = dateTimeSecond - dateTimeFirst;
            Console.WriteLine("LinkedList'te ilk kayda ekleme süresi       : " + timeSpan.TotalMilliseconds + " Ms");
            Console.WriteLine("-----------------------------------------------------------------");

            dateTimeFirst = DateTime.Now;
            linkedList.Remove(linkedList.First);
            dateTimeSecond = DateTime.Now;
            timeSpan = dateTimeSecond - dateTimeFirst;
            Console.WriteLine("LinkedList'te ilk kayıt çıkartma süresi     : " + timeSpan.TotalMilliseconds + " Ms");
            Console.WriteLine("-----------------------------------------------------------------");

            dateTimeFirst = DateTime.Now;
            linkedList.AddLast(random.Next((int)Speed));
            dateTimeSecond = DateTime.Now;
            timeSpan = dateTimeSecond - dateTimeFirst;
            Console.WriteLine("LinkedList'te son kayda ekleme süresi       : " + timeSpan.TotalMilliseconds + " Ms");
            Console.WriteLine("-----------------------------------------------------------------");

            dateTimeFirst = DateTime.Now;
            linkedList.Remove(linkedList.Last);
            dateTimeSecond = DateTime.Now;
            timeSpan = dateTimeSecond - dateTimeFirst;
            Console.WriteLine("LinkedList'te son kaydın çıkartma süresi    : " + timeSpan.TotalMilliseconds + " Ms");
            Console.WriteLine("-----------------------------------------------------------------");

            dateTimeFirst = DateTime.Now;
            LinkedListNode<int> linkedListMiddle = LinkedListNodeMiddle(linkedList.First, linkedList.Count / 2 - 1);
            linkedList.AddAfter(linkedListMiddle, random.Next((int)Speed));
            dateTimeSecond = DateTime.Now;
            timeSpan = dateTimeSecond - dateTimeFirst;
            Console.WriteLine("LinkedList'te 500.000 kaydın ekleme süresi  : " + timeSpan.TotalMilliseconds + " Ms");
            Console.WriteLine("-----------------------------------------------------------------");

            dateTimeFirst = DateTime.Now;
            linkedListMiddle = LinkedListNodeMiddle(linkedList.First, linkedList.Count / 2 - 1);
            int Previous = linkedListMiddle.Previous.Value;
            int Next = linkedListMiddle.Next.Value;
            linkedList.Remove(linkedListMiddle);
            dateTimeSecond = DateTime.Now;
            timeSpan = dateTimeSecond - dateTimeFirst;
            Console.WriteLine("LinkedList'te 500.000 kaydın çıkartma süresi: " + timeSpan.TotalMilliseconds + " Ms");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadKey();

        }

        private static LinkedListNode<int> LinkedListNodeMiddle(LinkedListNode<int> first, int v1)
        {
            for (int i = 0; i < v1; i++)
            {
                first = first.Next;
            }
            return first;
        }
    }
    
}
