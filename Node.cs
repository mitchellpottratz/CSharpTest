using System;

/*
  * The Node class represents an element in a singly linked list.
*/

namespace CSharpTest {

    class Node {

      private int data;

      // pointer to next node in the list
      private Node next; 

      public Node(int data, Node next) {
        this.data = data;
        this.next = next;
      }

      /*
        * @return    the string representation of the data attribute
      */
      public override string ToString() {
        return Convert.ToString(data);
      }

      /* --- getters and setters --- */

      public void setData(int data) {
        this.data = data;
      }

      public int getData() {
        return data;
      }

      public void setNext(Node next) {
        this.next = next;
      }

      public Node getNext() {
        return next;
      }

    }
}