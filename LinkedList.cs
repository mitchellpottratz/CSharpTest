using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/*
  * The LinkedList class represents a single linked list of Nodes
*/


namespace CSharpTest {

  public class LinkedList : IEnumerable<Node> {
    private int size = 0;
    private Node firstNode;


    /*
      * appends a Node to the list
      * 
      * @param  newNode   the Node to append       
    */
    public void append(Node newNode) {
      Node currentNode = firstNode;

      if (isEmpty()) {
        setFirstNode(newNode);

      } else {
        // traverses to the end of the list to find the last node
        while (currentNode.getNext() != null) {
          currentNode = currentNode.getNext();
        }

        // adds the new node to the end of the list
        currentNode.setNext(newNode);  
      }

      incrementSize();
    }   


    /*
      * removes a Node from the list 
      *
      * @param  nodeData  value of data attribute of the Node to remove    
    */
    public void remove(int nodeData) {
      Node previousNode = firstNode;
      Node nodeToCheck = firstNode;
      
      while (nodeToCheck != null) {

        if (nodeToCheck.getData() == nodeData) {

          // removing the firstNode is performed differently 
          if (nodeToCheck == firstNode) {
            setFirstNode(nodeToCheck.getNext());
          } else {
            previousNode.setNext(nodeToCheck.getNext());     
          }

          decrementSize();
          return;
        }

        previousNode = nodeToCheck;
        nodeToCheck = nodeToCheck.getNext();  
      }  
    }


    /*
      * determines if the list is empty
      *
      * @return    boolean determining if the list is empty
    */
    private bool isEmpty() {
      if (size == 0) {
        return true;
      }  
      return false;
    }


    /*
      * increments the size attribute
    */
    private void incrementSize() {
      size++;
    }


    /*
      * decrements the size attribute 
    */
    private void decrementSize() {
      size--;
    }


    /*
      * prints out each node in the list
    */
    public void display() {
      int nodeCounter = 1;
      Node nodeToCheck = firstNode;

      while (nodeToCheck != null) {
        StringBuilder nodeString = nodeToCheck.buildNodeString(nodeCounter);
        Console.WriteLine(nodeString);

        nodeToCheck = nodeToCheck.getNext();  
        nodeCounter++;
      }  
    }


    /*
      * calls the GetEnumerated method from the generic IEnumerable interface
      *
      * @return    IEnumerator<Node>
    */
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
      return this.GetEnumerator();
    }


    /*
      * method implemented from the Collections.Generic.IEnumerator interface
      * makes the linked list implementation iterable
      * 
      * @return    IEnumerator<Node>
    */
    public IEnumerator<Node> GetEnumerator() {
      Node iteratorNode = firstNode;
      while (iteratorNode != null) {
        yield return iteratorNode;
        iteratorNode = iteratorNode.getNext();
      }  
    }


    /* --- getters and setters --- */

    private void setFirstNode(Node firstNode) {
      this.firstNode = firstNode;
    }


    private Node getFirstNode() {
      return firstNode;
    }


    public int getSize() {
      return size;
    }

  }

}