using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntegerLinkedList myLinkedList = new IntegerLinkedList();

            myLinkedList.AddToFront(5);
            myLinkedList.AddToFront(4);
            myLinkedList.AddToFront(3);

            myLinkedList.AddToBack(6);
            myLinkedList.AddToBack(7);
            myLinkedList.AddToBack(8);

            myLinkedList.Display();


            //Generic Linked List which stores strings
            IGenericLinkedList<string> myGenericLinkedList = new GenericLinkedList<string>();

            //Generic linked list whcih can store ANY class which implements IComparable
            IGenericLinkedList<IComparable> myComparableLinkedList = new GenericLinkedList<IComparable>();

            myGenericLinkedList.AddToFront("Dah");
            myGenericLinkedList.AddToFront("Ro");
            myGenericLinkedList.AddToFront("Fus");

            myGenericLinkedList.AddToBack("Wuld");
            myGenericLinkedList.AddToBack("Nah");
            myGenericLinkedList.AddToBack("Kest");

            myGenericLinkedList.Display();

            string frontGuy = myGenericLinkedList.RemoveFromFront();

            Console.WriteLine(frontGuy);

            myGenericLinkedList.Display();
        }
    }
}
