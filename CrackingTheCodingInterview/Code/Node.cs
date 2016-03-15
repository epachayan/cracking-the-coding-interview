﻿using System;

namespace Code
{
    // This Node implementation is directly from the book (modified as needed)
    public class Node<T> where T : class
    {
        public Node(T d)
        {
            Data = d;
        }

        public T Data { get; private set; }

        public Node<T> Next { get; set; }
        
        public void AppendToTail(T d)
        {
            Node<T> end = new Node<T>(d);
            Node<T> n = this;

            while (n.Next != null)
            {
                n = n.Next;
            }

            n.Next = end;
        }

        public Node<T> DeleteNode(Node<T> head, T d)
        {
            Node<T> n = head;

            if (n.Data == d)
            {
                return head.Next; // Moved head
            }

            while (n.Next != null)
            {
                if (n.Next.Data == d)
                {
                    n.Next = n.Next.Next;
                    return head; // head didn't change
                }

                n = n.Next;
            }

            return head;
        } 
    }
}
