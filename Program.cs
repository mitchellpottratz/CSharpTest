using System;
using System.Collections.Generic;


/*
  * Main entry point of the program
*/


namespace CSharpTest {

  class Program {

    static private string FILE_PATH = "./data/commands.txt";

    static void Main(string[] args) {
      LinkedList list = new LinkedList();
      FileParser fileParser = new FileParser(FILE_PATH);

      foreach (string[] parsedLine in fileParser) {
        char command = Convert.ToChar(parsedLine[0]);
        int data = Convert.ToInt32(parsedLine[1]);
        
        Program.determineListAction(list, command, data);
      }

      list.display();
    }

    /*
      * adds a new node to the list or removes a node depending on the command param
      *
      * @param  list     the LinkedList being manipulated
      * @param  command  if 'i' node is inserted into list, if 'd' node is removed
      * @param  data     the data the new node will contain or data the node being removed contains
    */
    static private void determineListAction(LinkedList list, char command, int data) {
      if (command == 'i') {
        Node newNode = new Node(data); 
        list.append(newNode); 
      } else if (command == 'd') {
        list.remove(data);
      } else {
        Console.WriteLine("Error determining the command");
      }
    } 
   }
}
