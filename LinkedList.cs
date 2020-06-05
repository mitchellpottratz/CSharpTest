using System;
using System.Collections;
using System.Collections.Generic;


namespace CSharpTest {

  public class LinkedList : IEnumerable<Node> {
    private int size = 0;
    private Node firstNode;
    private Node currentNode; 


    /*
      * appends a Node to the list
      * 
      * @param  newNode   the Node to append       
    */
    public void append(Node newNode) {
      if (isEmpty()) {
        newNode.setNext(null);
        setFirstNode(newNode);
      } else {
        currentNode.setNext(newNode);
      }
      setCurrentNode(newNode); 
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
      * increments the size attribute by 1
    */
    private void incrementSize() {
      size++;
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


    private void setCurrentNode(Node currentNode) {
      this.currentNode = currentNode;
    }

  }

}