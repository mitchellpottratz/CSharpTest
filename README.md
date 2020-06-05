# CSharpTest
Mitchell Pottatz

# Run 
- dotnet run
- dotnet run <path_to_file>

# Purpose
To quickly test a candidate’s ability to program in C#. This exercise will require a basic understanding of the linked list data structure, algorithms, recursion, and/or control loops in C#
# Exercise
Create a console-based application in C# which implements a singly linked list. The console based application should read in commands from a text file and display the resulting values of the list to the console when it is done parsing the file. The linked list class you create should be able to insert a new node, delete a node, and traverse the list to find a node. The linked list will be able to store any integer value.

**Do not use any existing linked list library. The exercise is designed to see how well you understand data structures, objected orientated programming and algorithms, not how well you can use an existing library.**

The application should be able to get the path to the file as an argument when executed from the command line.

The application should be able to expect two types of commands. These commands should be parsed and executed sequentially when it parses the input text file. Each command will be separated by new lines.

**Insert i:<value>**

A node can be inserted into the list and store the specified value by i:<value>. For example, seeing i:7 in the input file would insert a node at the end of a list with the value of 7.

**Delete d:<value>**

A node can be deleted from the singly linked list by searching for the value of the node. The command follows the format of d:<value>. If there are multiple nodes with the same value in the list, the first occurance of the node should be deleted. If the value does not exist in the list, then nothing should be changed. 

For example, d:2 would traverse the singly linked list to find the node with value of 2 and delete the node from the list while preserving all other tailing nodes. 

NOTE: the application should look for the node with the value stored in the node and not the position of the node in the list.
When the application has completed parsing the input file, the result of the linked list should be displayed to the console sequentially in the following format.
Node<Index>:<value>

For example, if the input file is

```
i:3
i:6
i:8
i:40
d:8
```

The resulting output displayed to the console should be:

```
Node1:3
Node2:6
Node3:40
```

NOTE: The node with the value of 8 was deleted and should not exist in the list if implemented properly.
See links below for some resources on what a linked list is and how to implement one.

https://www.geeksforgeeks.org/data-structures/linked-list/




