using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    interface IGenericLinkedList<T>
    {
        //Since the type we want has come into this interface as
        //type T, we will use T as the type for the Data.
        //This means that if this linked list is declared with T being
        //a string, this list will hold strings.
        void AddToFront(T GenericData);
        void AddToBack(T GenericData);
        T RemoveFromFront();
        T RemoveFromBack();

        void Display();

        bool IsEmpty { get; }
        int Size { get; }
    }
}
