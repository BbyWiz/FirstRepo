using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    public class ALinkedList<T>
    {
        //properties
        //Pointer to First node
        public Node<T> First { get; private set; }
        //Pointer to Last node
        public Node<T> Last { get; private set; }
        //How many items are stored? count variable
        public int Count { get; private set; }

        public void AddFirst(Node<T> newNode)
        {
            if (this.First == null)
            {
                //if first node is empty/null | insert a new node on head/tail
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                this.First = newNode;
            }
            Count++;
        }
        public void AddLast(Node<T> newNode)
        {
            if (this.Last == null)
            {
                //if last is empty/null fill in a new tail
                this.Last = newNode;
                this.First = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }
        public void AddAfter(Node<T> newNode, Node<T> existingNode)
        {
            if (this.Last == existingNode)
            {
                Last = newNode;
            }
            newNode.Next = existingNode.Next;
            existingNode.Next = newNode;
            this.Count++;
        }
        public Node<T> Find(T target)
        {
            Node<T> currentNode = First;

            while (currentNode != null && !currentNode.Data.Equals(target))
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }
        public void RemoveFirst()
        {
            //check if there isnt a first to begin with
            if (First == null || this.Count == 0)
            {
                //null so leave
                return;
            }
            //replace the first node after the (last)first was removed
            First = First.Next;
            this.Count--;
        }
        public void Remove(Node<T> doomedNode)
        {
            if (First == null || this.Count == 0)
            {
                return;
            }
            Node<T> previous = First;
            Node<T> current = previous.Next;

            while (current != null && current != doomedNode)
            {
                previous = current;
                current = previous.Next;
            }

            //remove
            if (current != null)
            {
                previous.Next = current.Next;
                this.Count--;
            }
        }
        public void Traverse()
        {
            Console.WriteLine($"First {this.First.Data}");
            Console.WriteLine($"Last {this.Last.Data}");

            Node<T> node = this.First;

            while (node.Next != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }

            //output node
            Console.WriteLine(node.Data);
        }

    }
}