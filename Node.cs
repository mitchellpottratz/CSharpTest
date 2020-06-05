using System;
using System.Text;

/*
  * The Node class represents an element in a singly linked list.
*/

namespace CSharpTest {

    public class Node {

      private int data;

      // pointer to next node in the list
      private Node next = null; 


      public Node(int data) {
        this.data = data;
      }


      /*
        * uses StringBuilder to convert the Node to a string formatted as: "Node<count>:<value>" 
        *
        * @param  nodeCounter  the count of the current node in the list
        *
        * @return              node converted to a string in "Node<count>:<value>" format
        * 
    */
      public StringBuilder buildNodeString(int nodeCounter) {
        StringBuilder nodeString = new StringBuilder("Node", 9);
        nodeString.Append(Convert.ToString(nodeCounter));
        nodeString.Append(":");
        nodeString.Append(Convert.ToString(getData()));
        return nodeString;
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