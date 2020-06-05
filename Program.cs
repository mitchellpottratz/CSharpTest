using System;
using System.Collections.Generic;


namespace CSharpTest {

  class Program {

    static private string FILE_PATH = "./data/commands.txt";

    static void Main(string[] args) {
      LinkedList list = new LinkedList();
      FileParser fileParser = new FileParser(FILE_PATH);

      foreach (string[] parsedLine in fileParser) {

        char command = Convert.ToChar(parsedLine[0]);
        int data = Convert.ToInt32(parsedLine[1]);

        if (command == 'i') {
          Node newNode = new Node(data); 
          list.append(newNode); 
          Console.WriteLine("Wrote value " + data);
        } else if (command == 'd') {
          list.remove(data);
          Console.WriteLine("Removed value " + data);
        }  else {
          Console.WriteLine("Error determining the command");
        }
      }



    }
  }
}
