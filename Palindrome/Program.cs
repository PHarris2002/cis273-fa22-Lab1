using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Palindrome;
public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("0");
        linkedList.AddLast("0");

        IsPalindrome(linkedList);
    }

    public static bool IsPalindrome<T>(LinkedList<T> linkedList)
    {
        LinkedListNode<T> currentNodeStart = linkedList.First;
        LinkedListNode<T> currentNodeEnd = linkedList.Last;
        LinkedListNode<T> startMarker = currentNodeStart;
        LinkedListNode<T> endMarker = currentNodeEnd;

        // are the first and last items the same?
        while (currentNodeStart != null && currentNodeEnd != null)
        {

            if (currentNodeStart.Value.Equals(currentNodeEnd.Value))
            {

                // if so, move toward the middle
                currentNodeStart = currentNodeStart.Next;
                currentNodeEnd = currentNodeEnd.Previous;

                if (currentNodeStart == endMarker && currentNodeEnd == startMarker)
                {
                    return true;
                }
            }

            else
            {
                return false;
            }
        }

        return true;
    }
}

