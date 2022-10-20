using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Palindrome;
public class Program
{
    

    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("xbx");
        linkedList.AddLast("pka");
        linkedList.AddLast("pka");
        linkedList.AddLast("xbx");
    }

    public static bool IsPalindrome<T>(LinkedList<T> linkedList)
    {
        int count = 0;
        LinkedListNode<T> head = linkedList.First;

        LinkedListNode<T> currentNode = head;
        LinkedListNode<T> temp = head;

        while (temp != null)
        {
            temp = temp.Next;
            count++;
        }

        return true;
    }
}

