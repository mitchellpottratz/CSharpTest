using System;

namespace CSharpTest {

  class Program {
    static void Main(string[] args) {
      Node node1 = new Node(1, null);
      Node node2 = new Node(2, null);
      Node node3 = new Node(3, null);
      Node node4 = new Node(4, null);
      Node node5 = new Node(5, null);
      Node node6 = new Node(1, null);

      LinkedList list = new LinkedList();

      list.append(node1);
      list.append(node2);
      list.append(node3);
      list.append(node4);
      list.append(node5);
      list.append(node6);

      list.remove(1);
      list.remove(4);
      list.remove(5);

      foreach (Node node in list) {
        Console.WriteLine(node);
      }
    }
  }
}
