using System;
namespace LeetCode
{
     public class SinglyLinkedList 
     {
        private Node first;
        public bool isFirstEmpty() {
            return first == null;
        }

        public Node getFirst(){

            return first;
        }
        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }
        public Node deleteFirst(){
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void displayList() {
            Console.WriteLine("List frome first ----- last");
            Node current = first;
            while(current != null)
            {
                current.displayNode();
                current = current.next;
            }
        }

        public void insertLast(int data)
        {
            Node current = first;
            while(current.next != null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }
    public class Node {
        public int data;
        public Node next;

        public void displayNode(){
            Console.WriteLine($"--<{data}>");
        }
    }
}