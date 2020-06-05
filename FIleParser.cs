using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

/*
  * The FileParser class is responsible for reading lines from a file where each line is 
  * formated as <'i' OR 'd'>:<int> 
*/

namespace CSharpTest {

  public class FileParser : IEnumerable<string[]> {
    private string filePath;


    public FileParser(string filePath) {
      this.filePath = filePath;
    } 


    /*
      * creates a stream reader to read the file
      * uses FileStream and BufferedStream as its one of the most 
      * efficient ways to read a file according to...
      * src: https://cc.davelozinski.com/c-sharp/fastest-way-to-read-text-files
      * 
      * @return     StreamReader for the file
    */
    private StreamReader createFileStream() {
      FileStream fileStream = File.Open(filePath, FileMode.Open);
      BufferedStream bufferedStream = new BufferedStream(fileStream);
      return new StreamReader(bufferedStream);
    }
  

    /*
      * splits a string into an array containing the command and data
      *
      * @param  line  string to parse into an array 
      *
      * @return       string array containing command and data
    */
    private string[] parseLine(string line) {
      string[] parsedLine = line.Split(":");
      return parsedLine;
    }


    /*
      * wrapper around this classes GetEnumerator class
      *
      * @return    IEnumerator<string>
    */
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
      return this.GetEnumerator();
    }


    /*
      * method implemented from the Collections.Generic.IEnumerator interface
      * that iterates over lines in the file
      * 
      * @return    IEnumerator<string>
    */
    public IEnumerator<string[]> GetEnumerator() {
      StreamReader streamReader = createFileStream();
      
      string line;
      while ((line = streamReader.ReadLine()) != null) {
        yield return parseLine(line);
      }
    }
  }  
}