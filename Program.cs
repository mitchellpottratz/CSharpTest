using System;
using System.Collections.Generic;


/*
  * Main entry point of the program
*/


namespace CSharpTest {

  class Program {

    static private string DEFAULT_FILE_PATH = "./data/commands.txt";
    static private string FILE_PATH;

    static void Main(string[] args) {
      Program.determineFilePath(args);

      LinkedList list = new LinkedList();
      FileParser fileParser = new FileParser(FILE_PATH);

      // iterates through each string in the file
      foreach (string[] parsedLine in fileParser) {
        char command = Convert.ToChar(parsedLine[0]);
        int data = Convert.ToInt32(parsedLine[1]);
        
        Program.determineListAction(list, command, data);
      }

      Console.WriteLine("\n----- RESULTS -----");  
      list.display();
    }


    /*
      * uses the file path from command line if specified otherwise uses DEFAULT_FILE_PATH
      *
      * @param  args  string array of command the command line arguements
    */
    static private void determineFilePath(string[] args) {
      if (args.Length > 0) {
        FILE_PATH = args[0];
      } else {
        FILE_PATH = DEFAULT_FILE_PATH;
      }
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
